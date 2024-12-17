using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crud-> Create, Read, Update, Delete

            Console.WriteLine("***** Menu Panel *****");
            Console.WriteLine();
            Console.WriteLine("-------------------------");

            #region Add Category 
            //Console.Write("Category Name You Wish To Add:  ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection
            //    ("Data Source = YASEMONSTER\\MSSQLSERVER01;" +
            //    "initial catalog= educationDB; integrated security = true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into Category (categoryName) values (@p1)", connection);

            //command.Parameters.AddWithValue("@p1",categoryName);

            //command.ExecuteNonQuery(); // koşulsuz bi şekilde sorguyu çalıştır, direkt

            //connection.Close();

            //Console.WriteLine("Succesfully added.");
            #endregion

            #region Add Product 

            //string productName;
            //decimal productPrice;
            ////productStatus;

            //Console.Write("Product Name: ");
            //productName = Console.ReadLine();

            //Console.Write("Product Price: ");
            //productPrice = decimal.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection
            //    ("Data Source= YASEMONSTER\\MSSQLSERVER01; " +
            //    "initial catalog= educationDB; " +
            //    "integrated security= true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into Product " +
            //    "(productName, productPrice, productStatus) values " +
            //    "(@productName, @productPrice, @productStatus)", connection);

            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);

            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Succesfully added.");

            #endregion

            #region List Product

            //SqlConnection connection = new SqlConnection
            //    ("Data Source= YASEMONSTER\\MSSQLSERVER01;" +
            //    "Initial Catalog= educationDB;" +
            //    "Integrated Security= true");
            //try
            //{
            //    connection.Open();

            //    SqlCommand command = new SqlCommand
            //        ("Select * from Product", connection);

            //    SqlDataAdapter adapter = new SqlDataAdapter(command);
            //    DataTable dt = new DataTable();
            //    adapter.Fill(dt);

            //    foreach (DataRow row in dt.Rows) // Row okuma
            //    {
            //        foreach (var item in row.ItemArray)
            //        {
            //            Console.Write(item.ToString() + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}



            #endregion

            #region Delete Product

            //Console.Write("Enter the Product ID You Wish to Delete: ");


            //int productID = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection
            //    ("Data Source= YASEMONSTER\\MSSQLSERVER01;" +
            //    "Initial Catalog= educationDB;" +
            //    "Integrated Security= true");

            //connection.Open ();

            //SqlCommand command = new SqlCommand
            //    ("Delete From Product where productID=@productID", connection);
            //command.Parameters.AddWithValue("@productID", productID);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Succesfully deleted.");


            #endregion

            #region Update Product

            Console.Write("Prodcut ID: ");
            int productID = int.Parse(Console.ReadLine());

            Console.Write("Prodcut Name: ");
            string productName = Console.ReadLine();

            Console.Write("Product Price: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());
        

            SqlConnection connection = new SqlConnection
                ("Data Source= YASEMONSTER\\MSSQLSERVER01;" +
                "Initial Catalog= educationDB;" +
                "Integrated Security= true");
            connection.Open ();

            SqlCommand cmd = new SqlCommand ("Update Product Set " +
                "productName= @productName," +
                "productPrice=@productPrice where productID=@productID", connection);

            cmd.Parameters.AddWithValue ("@productName",productName);
            cmd.Parameters.AddWithValue ("@productPrice",productPrice);
            cmd.Parameters.AddWithValue ("@productID",productID);
            cmd.ExecuteNonQuery();


            connection.Close ();

            Console.WriteLine("Succesfully updated.");  

            #endregion

            Console.Read();
        }
    }
}
