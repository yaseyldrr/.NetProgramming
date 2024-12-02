using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            #region WriteCommands
            // eğer mor renkte bir küp varsa bu bir metoddur

            //Console.Write("Hello World!"); // imleci yazılan metnin sonuna koyar
            //Console.WriteLine("Hello!"); // imleci bir alt satıra geçirir

            //Console.WriteLine("***** Menu Sections *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Soups");
            //Console.WriteLine("2-Salads");
            //Console.WriteLine("3-Appetizers (Hot)");
            //Console.WriteLine("4-Cold Appetizers");
            //Console.WriteLine("5-Main Courses");
            //Console.WriteLine("6-Seafood");
            //Console.WriteLine("7-Desserts");
            //Console.WriteLine("8-Pastries");
            //Console.WriteLine("9-Grills");
            //Console.WriteLine("10-Vegetable Dishes");
            //Console.WriteLine("11-Breakfast Items");
            //Console.WriteLine("12-Snacks");
            //Console.WriteLine("13-Beverages");
            //Console.WriteLine();
            //Console.WriteLine("***** Menu Sections *****");


            // ekranın beklemesini sağlamak için read metodu kullanılır
            // enter a basınca console kapanır
            //Console.Read();
            #endregion

            #region Variables
            #region String

            // veriler üzerinde işlem yapmamızı sağlayan
            // geçici olarak RAM de tutulan program değerleridir

            //string customerName; // declared : tanımlandı
            //string customerSurname;
            //string customerPhoneNumber;
            //string customerEmail, customerDistrict, customerCity;



            //customerName = "Yase";
            //customerSurname = "Test";
            //customerPhoneNumber = "+90 933 33 99";
            //customerEmail = "customer.test@gmail.com";
            //customerDistrict = "Kadikoy";
            //customerCity = "Istanbul";

            //Console.WriteLine("****** Reservation Card ******");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Customer: " + customerName + " " + customerSurname);
            //Console.WriteLine("Contact: " + customerPhoneNumber);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("Adres: " + customerDistrict + "/" + customerCity);
            //Console.WriteLine("------------------------------");

            //customerName = "Aysegul";
            //customerSurname = "Kaya";   
            //customerPhoneNumber = "+90 400 60 60";
            //customerEmail = "customer1.test@gmail.com";
            //customerDistrict = "Sapanca";
            //customerCity = "Sakarya";

            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Customer: " + customerName + " " + customerSurname);
            //Console.WriteLine("Contact: " + customerPhoneNumber);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("Adres: " + customerDistrict + "/" + customerCity);
            //Console.WriteLine("------------------------------");

            #endregion

            #region Integer

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("***** Restaurant Menu Prices *****");
            Console.WriteLine();
            Console.WriteLine("--Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("--Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("--Fries: " + friesPrice + " TL");
            Console.WriteLine("--Coke: " + cokePrice + " TL");
            Console.WriteLine("--Lemonade: " + lemonadePrice + " TL");
            Console.WriteLine("--Water: " + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("***** Restaurant Menu Prices *****");

            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalPrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;  
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalPrice = 0;

            int totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            int totalPizzaPrice = pizzaPrice * pizzaCount;
            int totalFriesPrice = friesPrice * friesCount;  
            int totalCokePrice = cokePrice * cokeCount;
            int totalLemonadePrice = lemonadePrice * lemonadeCount;
            int totalWaterPrice = waterPrice * waterCount;
            totalPrice = totalHamburgerPrice + totalPizzaPrice+ totalFriesPrice+ totalCokePrice + totalLemonadePrice + totalWaterPrice;

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Total Hamburger Price: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Total Pizza Price: " + totalPizzaPrice + " TL");
            Console.WriteLine("Total Fries Price: " + totalFriesPrice + " TL");
            Console.WriteLine("Total Coke Price: " + totalCokePrice + " TL");
            Console.WriteLine("Total Lemonade Price: " + totalLemonadePrice + " TL");
            Console.WriteLine("Total Water Price: " + totalWaterPrice + " TL");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("TOTAL: " + totalPrice + " TL");




            #endregion
            #endregion
            Console.Read();
        }
    }
}
