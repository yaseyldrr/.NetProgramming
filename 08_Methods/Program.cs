using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Methods

            //void CustomerList()
            //{
            //    Console.WriteLine("Yasemin Yıldırır");
            //    Console.WriteLine("Merve Çınar");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Mehmet Yıldız");
            //}
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();

            #endregion

            #region Void Methods with Parameters

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Yase");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine($"Customer: {name} {surname}");
            //}
            //CustomerCard("Yasemin","Yıldırır");
            //CustomerCard("Mehmet","Yıldız");

            #endregion

            #region Void Methods with Int Parameter

            //void Sum(int num1, int num2, int num3)
            //{
            //    int result = num1 + num2 + num3;
            //    Console.WriteLine(result);
            //}

            //Sum(2,3,4);



            #endregion

            #region Returning Methods

            //string CustomerName()
            //{
            //    return "Yasemin Yıldırır";
            //}

            //Console.WriteLine(CustomerName());


            #endregion

            #region Returning Methods With Parameters

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Country = " +  countryName + " " + capital + " " + flagColor;
            //    return cardInfo;
            //}

            //string ex = CountryCard("Turkey", "Ankara", "Red and White");
            //Console.WriteLine("Ex: " + ex);

            //string x, y, z;
            //Console.WriteLine("Enter Country Name: ");
            //x = Console.ReadLine();

            //Console.WriteLine("Enter Capital Name: ");
            //y = Console.ReadLine();

            //Console.WriteLine("Enter Flag Color: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x,y,z));


            #endregion

            #region Returning Methods With Int Parameters

            //int Sum(int num1, int num2)
            //{
            //    int result = num1 + num2;
            //    return result;
            //}

            //Console.WriteLine("Sum: " + Sum(1, 2));

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;

                if (result >= 50)
                {
                    return "Passed.";
                }
                else
                {
                    return "Failed";
                }
            }

                Console.WriteLine("Exam: " + ExamResult("Yasemin Yıldırır", 45, 56, 78));

            #endregion

            Console.Read();
        }
    }
}
