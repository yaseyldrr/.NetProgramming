using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ado.net
            string tablenumber;



            Console.WriteLine("***** C# Product-Category Info System *****");
            Console.WriteLine();

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("1-Categories");
            Console.WriteLine("2-Products");
            Console.WriteLine("3-Orders");
            Console.WriteLine("4-Exit");
            Console.WriteLine("-------------------------------------------");
            Console.Write("Please enter the table you wish to access: ");
            tablenumber = Console.ReadLine();
            Console.WriteLine("-------------------------------------------");

            SqlConnection connection = new SqlConnection("Data Source = YASEMONSTER\\MSSQLSERVER01; initial Catalog = educationDB; integrated security = true");
            connection.Open();

            SqlCommand command = new SqlCommand("Select * from Category;", connection);   
            SqlDataAdapter adapter = new SqlDataAdapter(command); // Köprü

            DataTable dataTable = new DataTable(); // verileri belleğe almamı sağlar (RAM)
            adapter.Fill(dataTable);

            foreach (DataRow row in dataTable.Rows) // var her türü üzerine alan bir değişken
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString() + " ");
                }
                Console.WriteLine();
            }

            connection.Close();





            Console.Read();
        }
    }
}
