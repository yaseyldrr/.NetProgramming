using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            // Part 1
            //string password;
            //Console.Write("Please enter your password: ");
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Correct Password");
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect Password");
            //}


            // Part 2
            //string capital, country;

            //Console.Write("Enter the capital city: ");
            //capital = Console.ReadLine();

            //Console.Write("Enter the country: ");
            //country = Console.ReadLine();


            //if (capital=="Ankara" & country== "Türkiye")
            //{
            //    Console.Write("Verified Data");
            //}
            //else
            //{
            //    Console.Write("Incoorect Data");
            //}

            // Part 3
            //int number;

            //Console.Write("Enter the number: ");

            //number = int.Parse(Console.ReadLine());
            //if (number == 0)
            //{
            //    Console.WriteLine("Correct number");
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect number");
            //}

            // Part 4

            //int exam1, exam2, exam3, average;
            //string result = "Error!"; // eğer sonradan başka değer atanmazsa bu değer kullanılır

            //Console.Write("Exam 1: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Exam 2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Exam 3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Average: " + average);


            //if (average > 0 & average <= 50)
            //{
            //    result = "Result is terrible";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Result is average";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Result is good";
            //}
            //if (average > 84 & average <= 100)
            //{
            //    result = "Result is a great";
            //}
            //Console.WriteLine(result);

            // Part 5

            //Console.Write("Please enter your username: ");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("Invalid Username");
            //}
            //else
            //{
            //    Console.WriteLine("Welcome!");
            //}

            // Part 6














            #endregion

            #region Mod Operations

            // Part 1
            //int number;
            //number = 26;

            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Please enter 1st number: ");
            //int number1 = int.Parse(Console.ReadLine());


            // Part 2

            //Console.Write("Please enter 2nd number: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1%number2;

            //Console.Write("The remainder of the division of the first number by the second number is: " + result);

            // Part 3

            //int number;
            //Console.Write("Please enter the number: ");
            //number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("It's even");
            //}
            //else
            //{
            //    Console.WriteLine("It's odd");
            //}

            // Part 4

            //char team;
            //Console.WriteLine("Please enter the first letter of the team: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'B' || team == 'b')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            //if (team == 'F' || team == 'f')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team == 'G' || team == 'g')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team == 'T' || team == 't')
            //{
            //    Console.WriteLine("Trabzonspor");
            //}
            #endregion

            #region Project Sample


            //Console.WriteLine("****** C# COURSE RESTAURANT ******");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("1-Main Courses");
            //Console.WriteLine("2-Soups");
            //Console.WriteLine("3-Pizzas");
            //Console.WriteLine("4-Beverages");
            //Console.WriteLine("5-Desserts");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------");

            //string menuItem;

            //Console.Write("Menu item for detail review: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Main Courses ----------");
            //    Console.WriteLine();

            //    Console.WriteLine("1-Curry Chicken");
            //    Console.WriteLine("2-Fries Platter");
            //    Console.WriteLine("3-Grilled Salmon");
            //    Console.WriteLine("4-Steak");
            //    Console.WriteLine("5-Lasagna");

            //    Console.WriteLine();
            //    Console.WriteLine("---------- Main Courses ----------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Soups ----------");
            //    Console.WriteLine();

            //    Console.WriteLine("1-Tomato Soup");
            //    Console.WriteLine("2-Minestrone");
            //    Console.WriteLine("3-French Onion Soup");
            //    Console.WriteLine("4-Pumpkin Soup");

            //    Console.WriteLine();
            //    Console.WriteLine("---------- Soups ----------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Pizzas ----------");
            //    Console.WriteLine();

            //    Console.WriteLine("1-Margherita");
            //    Console.WriteLine("2-Pepperoni");
            //    Console.WriteLine("3-Hawaiian Pizza");
            //    Console.WriteLine("4-Mushroom Pizza");

            //    Console.WriteLine();
            //    Console.WriteLine("---------- Pizzas ----------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Beverages ----------");
            //    Console.WriteLine();

            //    Console.WriteLine("1-Mojito");
            //    Console.WriteLine("2-Martini");
            //    Console.WriteLine("3-Margarita");
            //    Console.WriteLine("4-Old Fashioned");

            //    Console.WriteLine();
            //    Console.WriteLine("---------- Beverages ----------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Desserts ----------");
            //    Console.WriteLine();

            //    Console.WriteLine("1-Crème brûlée");
            //    Console.WriteLine("2-Banoffee pie");
            //    Console.WriteLine("3-Eton mess");
            //    Console.WriteLine("4-Tartufo");
            //    Console.WriteLine("5-Tarte Tatin");
            //    Console.WriteLine("6-Chocolate Lava Cake");
            //    Console.WriteLine("7-Sticky Toffee Pudding");

            //    Console.WriteLine();
            //    Console.WriteLine("---------- Desserts ----------");
            //    Console.WriteLine();

            //}


            #endregion

            #region Switch Case

            //Console.Write("Please enter month number: ");
            //int month = int.Parse(Console.ReadLine());

            //switch (month)
            //{
            //    case 1:
            //        Console.WriteLine("January");
            //        break;
            //    case 2:
            //        Console.WriteLine("February");
            //        break;
            //    case 3:
            //        Console.WriteLine("March");
            //        break;
            //    case 4:
            //        Console.WriteLine("April");
            //        break;
            //    case 5:
            //        Console.WriteLine("May");
            //        break;
            //    case 6:
            //        Console.WriteLine("June");
            //        break;
            //    case 7:
            //        Console.WriteLine("July");
            //        break;
            //    case 8:
            //        Console.WriteLine("August");
            //        break;
            //    case 9:
            //        Console.WriteLine("September");
            //        break;
            //    case 10:
            //        Console.WriteLine("October");
            //        break;
            //    case 11:
            //        Console.WriteLine("November");
            //        break;
            //    case 12:
            //        Console.WriteLine("December");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Number");
            //        break ;
            //}












            #endregion

            #region Switch Case Calculator

            int number1, number2, result = -1;
            char symbol;

            Console.Write("Enter the first number: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the oeration symbol: ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = number1 + number2; break;
                case '-':
                    result = number1 - number2; break;
                case '*':
                    result = number1 * number2; break;
                case '/':
                    result = number1 / number2; break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            Console.Write("Result: " + result);
            #endregion

            Console.Read();
        }
    }
}
