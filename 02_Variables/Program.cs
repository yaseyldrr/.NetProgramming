using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double

            //double number; // declared
            //number = 4.85; // Kodda nokta, çıktıda virgül olarak görürüz
            //Console.WriteLine(number);

            //Console.WriteLine("***** PRICE LIST *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;
            //// ctrl + space (otomatik tamamlar)

            //Console.OutputEncoding = System.Text.Encoding.Unicode;
            //// Unicode ayarlamak için kullanılır (özel karakterler için örn: ş, ğ, ₺)
            //Console.WriteLine("--Apple Unit Price:  " + applePrice + " ₺"); // Altgr + T
            //Console.WriteLine("--Orange Unit Price:  " + orangePrice + " ₺");
            //Console.WriteLine("--Strawberry Unit Price:  " + strawberryPrice + " ₺");
            //Console.WriteLine("--Patato Unit Price:  " + potatoPrice + " ₺");
            //Console.WriteLine("--Tomato Unit Price:  " + tomatoPrice + " ₺");
            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;  
            //double strawberryTotalPrice = strawberryPrice * strawGram;
            //double potatoTotalPrice = potatoPrice * potatoGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;

            //Console.WriteLine( "Purchased Item: Apple - " + "Unit Price: " + applePrice + " - Gram: " + appleGram + " - Total: " + appleTotalPrice + " ₺");
            //Console.WriteLine( "Purchased Item: Orange - " + "Unit Price: " + orangePrice + " - Gram: " + orangeGram + " - Total: " + orangeTotalPrice + " ₺");
            //Console.WriteLine( "Purchased Item: Strawberry - " + "Unit Price: " + strawberryPrice + " - Gram: " + strawGram + " - Total: " + strawberryTotalPrice + " ₺");
            //Console.WriteLine( "Purchased Item: Potato - " + "Unit Price: " + potatoPrice + " - Gram: " + potatoGram + " - Total: " + potatoTotalPrice + " ₺");
            //Console.WriteLine( "Purchased Item: Tomato - " + "Unit Price: " + tomatoPrice + " - Gram: " + tomatoGram + " - Total: " + tomatoTotalPrice + " ₺");

            //double totalPurchase = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine("Total Cost: " + totalPurchase + " ₺");

            #endregion

            #region Char

            //char symbol = 'A';
            //Console.WriteLine(symbol);

            #endregion

            #region Keyboard Input(String)

            //Console.WriteLine("******C# Airlines passenger Information*****");
            //Console.WriteLine();

            //// ctrl + f ile toplu isim değiştirebilirsin
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerID;

            //Console.Write("Passenger Name: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Passenger Surname: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Passenger District: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Passenger City: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Passenger Age: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Passenger ID: ");
            //passengerID = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("----------------------");
            //Console.WriteLine("ID: " + passengerID);
            //Console.WriteLine("Passenger: " + passengerName + " " + passengerSurname);
            //Console.WriteLine("Location: " + passengerDistrict + "/" + passengerCity);
            //Console.WriteLine("Age: " + passengerAge);

            #endregion

            #region Keyboard Input(Integer) and Conversion

            // C# programlama dili console dan alınan değerlerin hepsini string olarak alır;
            // yani bir alfabetik değer olarak alır, bunu dönüştürmek gerekir.

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Please enter the total number of shoes you have purchased: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Please enter the total number of computer you have purchased: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Please enter the total number of chair you have purchased: ");
            //chairCount  = int.Parse(Console.ReadLine());

            //Console.Write("Please enter the total number of TV you have purchased: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = (shoesCount*shoesPrice) + (computerCount*computerPrice)
            //    + (chairCount*chairPrice) + tvCount*tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Total Price: " + totalPrice);


            #endregion

            #region Keyboard Input(Decimal Numbers) and Operations

            //double exam1, exam2, exam3, averageGrade;

            //Console.WriteLine("Please enter 1st exam grade: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Please enter 2nd exam grade: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Please enter 3rd exam grade: ");
            //exam3 = double.Parse(Console.ReadLine());


            //averageGrade = (exam1 + exam2 + exam3)/3;
            //Console.WriteLine("Your average grade for the exams is: " + averageGrade);

            #endregion

            #region Keyboard Input(Character)

            //char gender;
            //Console.WriteLine("Select a gender");
            //gender = char.Parse(Console.ReadLine());
            //Console.WriteLine("Gender: " + gender);

            #endregion

            Console.Read();
        }
    }
}
