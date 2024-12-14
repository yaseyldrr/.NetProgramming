using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForEachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region

            //string[] cities = { "Ankara", "İstanbul", "Malatya", "Trabzon" };

            // foreach (string s in cities)
            // {
            //     Console.WriteLine(s);
            // }

            //int[] ints = { 1, 2, 56, 673, 45354, 234, 56767, 1112, 7681 };

            //foreach(int i in ints)
            //{
            //    if(i %2 == 0)
            //    Console.WriteLine(i);
            //}

            //int[] ints = { 1, 2, 56, 673, 45354, 234, 56767, 1112, 7681 };

            //int total = 0;

            //foreach (var item in ints)
            //{
            //    total += item;
            //}
            //Console.WriteLine(total);


            //List<int> list = new List<int>()
            //{ 1,2,3,4,5,8 }; // instance yani örnek alma

            //// Console.WriteLine(list); // Metinsel ifade döndürür

            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            //string word = Console.ReadLine();

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Grade System App

            Console.Write("***** C# Education Exam App *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // Sınıftaki öğrenci sayısını alma
            Console.WriteLine("-----------------------------");
            Console.Write("How many student in your class: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------");

            // Öğrenci isimlerini ve not ortalamalarını saklayan diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAverage = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. Student's name: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                // Her öğrenci için 3 sınav notu alma

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} named student's  {j + 1}. exam: ");
                    double value = double.Parse(Console.ReadLine());

                    totalExamResult += value; // notları topla
                }
                Console.WriteLine();
                studentExamAverage[i] = totalExamResult/3;
            }
            // Sınav ortalamaları

            Console.WriteLine("---------------------------------------------");
            for (int i = 0; i < studentCount; i++)
            {
                
                Console.WriteLine($"{studentNames[i]} named student's average: {studentExamAverage[i]}");

                // Öğrencilerin geçip kalma durumları

                if (studentExamAverage[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} named student: PASSED");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} named student: FAILED");
                }
                Console.WriteLine("---------------------------------------------") ;

            }

            #endregion


            Console.Read();
        }
    }
}
