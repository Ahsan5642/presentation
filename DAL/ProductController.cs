using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class ProductController
    {
        //string connString = MyConnection.ConnectionString;
        //Products product = new Products();
        //static int increment = 1;
        //public List<Products> GetProducts()
        //{
        //    List<Products> products = new List<Products>();
        //    using (SqlConnection connection = new SqlConnection(connString))
        //    {
        //        string query = "SELECT TOP 20 ProductID, ProductName FROM Products ORDER BY ProductID";
        //        SqlCommand command = new SqlCommand(query, connection);
        //        try
        //        {
        //            connection.Open();
        //            SqlDataReader reader = command.ExecuteReader();
        //            while (reader.Read())
        //            {
        //                Products product = new Products
        //                {
        //                    ProductID = Convert.ToInt32(reader["ProductID"]),
        //                    ProductName = reader["ProductName"].ToString(),

        //                };
        //                products.Add(product);
        //            }

        //            reader.Close();
        //        }
        //        catch
        //        {
        //            throw new Exception("Error Getting Products Data");

        //        }
        //    }
        //    return products;
        //}


        //public int GetProductID(string productname)
        //{

        //    string query = "SELECT ProductID,ProductName FROM Products WHERE ProductName = @ProductName";
        //    try
        //    {
        //        using (SqlConnection connection = new SqlConnection(connString))
        //        {
        //            connection.Open();
        //            SqlCommand command = new SqlCommand(query, connection);

        //            command.Parameters.AddWithValue("@ProductName", productname);
        //            SqlDataReader reader = command.ExecuteReader();
        //            while (reader.Read())
        //            {
        //                product = new Products
        //                {
        //                    ProductID = Convert.ToInt32(reader["ProductID"]),

        //                };
        //            }
        //            reader.Close();
        //        }
        //    }
        //    catch
        //    {
        //        throw new Exception("Not Product found with this ID");
        //    }

        //    return product.ProductID;

        //}
        //public List<Products> GetNextProducts(int productid)
        //{

        //    List<Products> products = new List<Products>();
        //    using (SqlConnection connection = new SqlConnection(connString))
        //    {
        //        string query = "SELECT TOP 20 * FROM Products Where ProductID > @ProductID";
        //        SqlCommand command = new SqlCommand(query, connection);
        //        try
        //        {
        //            connection.Open();
        //            command.Parameters.AddWithValue("@ProductID", productid);
        //            SqlDataReader reader = command.ExecuteReader();
        //            while (reader.Read())
        //            {
        //                Products product = new Products
        //                {
        //                    ProductID = Convert.ToInt32(reader["ProductID"]),
        //                    ProductName = reader["ProductName"].ToString(),

        //                };
        //                products.Add(product);
        //            }
        //            reader.Close();
        //        }
        //        catch
        //        {
        //            throw new Exception("Error Getting Products Data");

        //        }
        //    }

        //    return products;


        //}
        //public List<Products> PreviousProducts(int productid)
        //{
            
        //    List<Products> products = new List<Products>();
        //    using (SqlConnection connection = new SqlConnection(connString))
        //    {
        //        SqlCommand command = new SqlCommand("SELECT Top 20 * FROM Products WHERE ProductID < @ProductID ORDER BY ProductID DESC", connection);
        //        try
        //        {
        //            command.Parameters.AddWithValue("@ProductID", productid);
        //            connection.Open();
        //            SqlDataReader reader = command.ExecuteReader();
        //            while (reader.Read())
        //            {
        //                Products product = new Products
        //                {
        //                    ProductID = Convert.ToInt32(reader["ProductId"]),
        //                    ProductName = reader["ProductName"].ToString()

        //                };
        //                products.Add(product);
        //            }
        //            reader.Close();
        //        }
        //        catch
        //        {
        //            throw new Exception("Error Loading Previous");


        //        }
        //        return products;

        //    }
        //}
    }
}
