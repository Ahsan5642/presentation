using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using System.Configuration;

namespace DAL
{

    public class OrderController
    {

        string connString = MyConnection.ConnectionString;
        //    public List<Orders> GetOrdersByCustomer(string customerid)
        //    {
        //        List<Orders> orders = new List<Orders>();
        //        using (SqlConnection connection = new SqlConnection(connString))
        //        {
        //            SqlCommand command = new SqlCommand("SELECT * FROM Orders WHERE CustomerID = @CustomerID ", connection);
        //            try
        //            {
        //                command.Parameters.AddWithValue("@CustomerID", customerid);
        //                connection.Open();
        //                SqlDataReader reader = command.ExecuteReader();
        //                while (reader.Read())
        //                {
        //                    Orders order = new Orders
        //                    {
        //                        OrderID =  Convert.ToInt32(reader["OrderID"]),
        //                        CustomerID = reader["CustomerID"].ToString(),
        //                        EmployeeID = reader["EmployeeID"].ToString(),
        //                        ShipVia = reader["ShipVia"].ToString(),
        //                        ShipName = reader["ShipName"].ToString(),
        //                        ShipAddress = reader["ShipAddress"].ToString(),
        //                        ShipRegion = reader["ShipRegion"].ToString()

        //                    };
        //                    orders.Add(order);
        //                }
        //                reader.Close();
        //            }
        //            catch 
        //            {
        //                throw new Exception("Error occured getting orders");
        //            }
        //        }
        //        return orders;
        //    }

        public void SaveOrder(string customerID, int productID)
        {
            int orderid = 1;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    string insertOrder = "INSERT INTO Orders (CustomerID,EmployeeID,OrderDate,RequiredDate,ShippedDate,ShipVia,Freight,ShipName,ShipAddress,ShipCity,ShipRegion,ShipPostalCode,ShipCountry) VALUES (@CustomerID,EmployeeID,OrderDate,RequiredDate,ShippedDate,ShipVia,Freight,ShipName,ShipAddress,ShipCity,ShipRegion,ShipPostalCode,ShipCountry)";
                    SqlCommand cmd = new SqlCommand(insertOrder, conn, transaction);
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);
                    cmd.ExecuteNonQuery();
                    string queryy = "SELECT Top 1 OrderID FROM Orders WHERE CustomerID = @CustomerID  Order By OrderID DESC";
                    SqlCommand com = new SqlCommand(queryy, conn, transaction);
                    com.Parameters.AddWithValue("@CustomerID", customerID);
                    SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        Orders order = new Orders
                        {
                            OrderID = Convert.ToInt32(reader["OrderID"]),
                        };
                        orderid = order.OrderID;

                    }
                    reader.Close();
                    string query = "INSERT INTO [Order Details](OrderID, ProductID, UnitPrice, Quantity, Discount) VALUES (@orderid, @productid, unitprice, quantity, discount)";
                    SqlCommand command = new SqlCommand(query, conn, transaction);
                    command.Parameters.AddWithValue("@orderid", orderid);
                    command.Parameters.AddWithValue("@productid", productID);
                    command.ExecuteNonQuery();
                    transaction.Commit();


                }
                catch
                {
                    throw new Exception("Error Saving Order Data");

                }
            }
        }
        public void DeleteOrderDetails(int Orderid)
        {
            string order = Orderid.ToString();
            using (SqlConnection connection = new SqlConnection(connString))
            {
                string query = "DELETE FROM [Order Details] WHERE OrderID = @Orderid";
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    command.Parameters.AddWithValue("@Orderid", order);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch
                {
                    throw new Exception("No Related Orders found in Order Details Table ");
                }
                connection.Close();

            }
        }
        public void DeleteFromOrderDetails(string customerid)
        {

            //List<Orders> OrderIDToDelete = GetOrdersByCustomer(customerid);
            //for (int i = 0; i < OrderIDToDelete.Count; i++)
            //{
            //    try
            //    {
            //        DeleteOrderDetails(OrderIDToDelete[i].OrderID);
            //    }
            //    catch
            //    {
            //        throw new Exception("Customer Order not Deleted");
            //    }

            //}
        }

        public void DeleteCustomerOrder(string id)
        {
            DeleteFromOrderDetails(id);
            using (SqlConnection connection = new SqlConnection(connString))
            {
                string query = "DELETE FROM Orders WHERE CustomerID IN (SELECT CustomerID FROM Customers WHERE CustomerID = @CustomerID)";
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    command.Parameters.AddWithValue("@CustomerID", id);
                    connection.Open();
                    command.ExecuteNonQuery();

                }
                catch
                {
                    throw new Exception("Error Deleting Customer Order");

                }
            }
        }
    }
}


