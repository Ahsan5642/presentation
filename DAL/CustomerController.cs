using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Model;
namespace DAL
{
    public class CustomerController
    {

        string connString = MyConnection.ConnectionString;
        string customerID;
        string contactName;
        string address;
        string phone;
       
        public Customers GetFirstCustomer()
        {
            Customers customers = new Customers();
            string query = "SELECT TOP 1 * FROM Customers";
            using (SqlConnection connection = new SqlConnection(connString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            customers = new Customers
                            {
                                CustomerID = reader["CustomerID"].ToString(),
                                ContactName = reader["ContactName"].ToString(),
                                Address = reader["Address"].ToString(),
                                Phone = reader["Phone"].ToString()

                            };

                        }
                        reader.Close();
                    }
                    catch
                    {
                        throw new Exception("Error Loading ");

                    }
                }
            }
            return customers;
        }

        //public List<string> GetLastCustomer()
        //{
        //    List<string[]> customerdata;
        //    using (SqlConnection connection = new SqlConnection(connString))
        //    {
        //        string query = "SELECT Top 1 * FROM Customers ORDER BY CustomerID DESC";
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            try
        //            {
        //                connection.Open();
        //                SqlDataReader reader = command.ExecuteReader();
        //                while (reader.Read())
        //                {



        //                }
        //                reader.Close();
        //                connection.Close();
        //            }
        //            catch
        //            {
        //                throw new Exception("Error Getting Last Customer");
        //            }
        //        }
        //    }
        //    return  customerdata;
        //}
        //public string[] LoadNextCustomer(string ID)
        //{

        //    using (SqlConnection connection = new SqlConnection(connString))
        //    {

        //        SqlCommand command = new SqlCommand("SELECT Top 1 * FROM Customers WHERE CustomerID > @CustomerID ", connection);
        //        try
        //        {
        //            command.Parameters.AddWithValue("@CustomerID", ID);
        //            connection.Open();
        //            SqlDataReader reader = command.ExecuteReader();
        //            while (reader.Read())
        //            {
        //                customer = new Customers
        //                {
        //                    CustomerID = reader["CustomerID"].ToString(),
        //                    ContactName = reader["ContactName"].ToString(),
        //                    Address = reader["Address"].ToString(),
        //                    Phone = reader["Phone"].ToString()
        //                };
        //            }
        //            reader.Close();
        //        }
        //        catch 
        //        {
        //            throw new Exception("Error Loading Customer ");
        //        }
        //        return customer;
        //    }
        //}

        //public Customers LoadPreviousCustomer(string ID)
        //{
        //    Customers customer = new Customers();
        //    using (SqlConnection connection = new SqlConnection(connString))
        //    {
        //        SqlCommand command = new SqlCommand("SELECT Top 1 * FROM Customers WHERE CustomerID < @CustomerID ORDER BY CustomerID DESC", connection);
        //        try
        //        {
        //            command.Parameters.AddWithValue("@CustomerID", ID);
        //            connection.Open();
        //            SqlDataReader reader = command.ExecuteReader();
        //            while (reader.Read())
        //            {
        //                customer = new Customers
        //                {
        //                    CustomerID = reader["CustomerID"].ToString(),
        //                    ContactName = reader["ContactName"].ToString(),
        //                    Address = reader["Address"].ToString(),
        //                    Phone = reader["Phone"].ToString()
        //                };
        //            }
        //            reader.Close();
        //        }
        //        catch 
        //        {
        //            throw new Exception("Error Loading Previous");


        //        }
        //        return customer;
        //    }
        //}
        //public void DeleteCustomerDemo(string ID)
        //{
        //    using (SqlConnection connection = new SqlConnection(connString))
        //    {

        //        string query = "DELETE FROM CustomerCustomerDemo WHERE CustomerID IN (SELECT CustomerID FROM Customers WHERE CustomerID = @CustomerID)";
        //        SqlCommand command = new SqlCommand(query, connection);
        //        try
        //        {
        //            command.Parameters.AddWithValue("@CustomerID", ID);
        //            connection.Open();
        //            command.ExecuteNonQuery();

        //        }
        //        catch 
        //        {
        //            throw new Exception("Error Deleting Customer Order");

        //        }
        //    }
        //}
        //public string DeleteCustomer(string ID)
        //{
        //    string message = null;
        //    using (SqlConnection connection = new SqlConnection(connString))
        //    {
        //        string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";
        //        SqlCommand command = new SqlCommand(query, connection);
        //        try
        //        {
        //            command.Parameters.AddWithValue("@CustomerID", ID);
        //            connection.Open();
        //            command.ExecuteNonQuery();
        //            message = "Successful ";
        //        }
        //        catch 
        //        {
        //            throw new Exception("Unable To Delete Data");


        //        }
        //    }
        //    return message;
        //}
        //public void SaveCustomer(string customerID, string contactname, string address, string contactnumber, bool flag)
        //{
        //    try
        //    {
        //        if (flag == true)
        //        {
        //            using (SqlConnection connection = new SqlConnection(connString))
        //            {
        //                SqlCommand command = new SqlCommand("UPDATE Customers SET CompanyName=@CompName, ContactName= @ContNum, Address=@Addres  WHERE CustomerID = @Id", connection);

        //                command.Parameters.AddWithValue("@Id", customerID);
        //                command.Parameters.AddWithValue("@CompName", contactname);
        //                command.Parameters.AddWithValue("@ContNum", contactnumber);
        //                command.Parameters.AddWithValue("@Addres", address);
        //                connection.Open();
        //                command.ExecuteNonQuery();
        //                connection.Close();

        //            }

        //        }
        //        else
        //        {
        //            CreateNewCustomer(customerID, contactname, address, contactnumber);

        //        }
        //    }
        //    catch
        //    {
        //        throw new Exception("Customer Data not saved");
        //    }

        //}

        //public void CreateNewCustomer(string customerID, string contactname, string address,string contactnumber)
        //{
        //    try
        //    {
        //        string query = "INSERT INTO Customers(CustomerID,CompanyName, ContactName,ContactTitle, Address,City, Region,PostalCode,Country, Phone, Fax) Values (@CustomerID,@CompanyName, @ContactName,@ContactTitle, @Address,@City,@Region,@PostalCode,@Country, @Phone,@Fax)";
        //        using (SqlConnection connection = new SqlConnection(connString))
        //        {
        //            SqlCommand command = new SqlCommand(query, connection);

        //            command.Parameters.AddWithValue("@CustomerID", customerID);
        //            command.Parameters.AddWithValue("@CompanyName", "METRO");
        //            command.Parameters.AddWithValue("@ContactName", contactname);
        //            command.Parameters.AddWithValue("@ContactTitle", "M" + contactname);
        //            command.Parameters.AddWithValue("@Address", address);
        //            command.Parameters.AddWithValue("@City", "RAWALPINDI");
        //            command.Parameters.AddWithValue("@Region", "SOUTH ASIA");
        //            command.Parameters.AddWithValue("@PostalCode", "123");
        //            command.Parameters.AddWithValue("@Country", "PAKISTAN");
        //            command.Parameters.AddWithValue("@Phone", contactnumber);
        //            command.Parameters.AddWithValue("@Fax", "77");
        //            connection.Open();
        //            command.ExecuteNonQuery();
        //            connection.Close();

        //        }
        //    }
        //    catch
        //    {
        //        throw new Exception("Error creating new customer");
        //    }


        //}

    } 
}
