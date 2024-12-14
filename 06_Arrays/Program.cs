using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Basic Array Examples

            //string[] colors = new string[4];
            //colors[0] = "blue";
            //colors[1] = "white";
            //colors[2] = "yellow";
            //colors[3] = "red";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapest";
            //cities[2] = "Lyon";
            //cities[3] = "Cairo";
            //cities[4] = "Skopje";

            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;

            //Console.WriteLine(numbers[4]); // default -> 0

            //string[] cities = { "Prague", "Rome", "Athena", "Ankara", "Bursa" };

            //Console.WriteLine(cities[2]);


            #endregion

            #region Listing All Elements Of An Array

            //string[] colors = { "yellow", "red", "pink", "orange", "black", "white","green"};

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 12, 34, 567, 889, 7876, 4634, 2424, 5778, 1123 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}


            //int[] myArray = {12,47,78,89,4590,34,56,77,66,14,91,949};

            //int maxNum = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNum)
            //        maxNum = myArray[i];
            //}
            //Console.WriteLine(maxNum);

            //string[] persons = {"Ali","Ahmet", "Ayşe", "Buse", "Cem","Deniz"};
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };


            //// Sorting
            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Console.WriteLine("------");

            //// Reversing
            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++) {
            //    Console.WriteLine(numbers[i]);
            //}

            /* int[] numbers = { 5, 3, 8, 1 };
            Array.Sort(numbers);  // Küçükten büyüğe sıralar
            Array.Reverse(numbers);  // Büyükten küçüğe çevirir
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
            */


            #endregion

            #region Array Methods

            //string[] persons = { "yase", "yldrr", "code", "software" };
            //int index = Array.IndexOf(persons, "yase");
            //Console.WriteLine(index);

            //int[] numbers = { 1, 45, 67, 3, 89, 90, 8, 0 };
            //Console.WriteLine("Max: " + numbers.Max());
            //Console.WriteLine("Min: " + numbers.Min());

            #endregion

            #region Getting Input From User

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Please enter the {i + 1}. city you want to add to the list: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine("--------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine($"{i+ 1}. City: " + cities[i]);
            //}

            int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };

            Console.WriteLine("Even Numbers: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            Console.WriteLine("----------------");

            Console.WriteLine("Odd Numbers: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            #endregion

            Console.Read();
        }
    }
}
