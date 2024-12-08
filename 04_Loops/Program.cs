using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For

            // breakpoint ler çalışma prensibini görmek için kullanılan işaretlerdir
            // f11'ler ile atanan değerleri ve console çıktısını sırayla görebiliriz
            //for (int i = 1; i < 5; i++)
            //{
            //    Console.WriteLine("C# Course " + i);
            //}

            //for (int i = 3; i <= 50; i+= 3) // i nin son değeri 51 olur fakat yazılmaz
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("How many of: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Happy Coding!");
            //}

            #endregion

            #region Decision Structures with For Loop

            // Part 1

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}


            // Part 2

            //int totalValue = 0;

            //for (int i = 0; i <= 10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            // Part 3

            //int total = 0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        total += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("---");
            //Console.WriteLine(total);


            // Part 4

            //int count = 0;

            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            // Bir bkateri türü her saatin sonunda kendini 2'ye bölerek çoğaltmaktadır.
            // 2 saatte 4, 3 saatte 8 bakteri oluyor.
            // 24 saat sonun kaç bakteri olur, bunu hesaplayan programı yazınız.

            //int bacteria = 1;

            //for (int i = 1; i <= 24; i++)
            //{

            //    bacteria *= 2;
            //    Console.WriteLine(i + " hours later: " + bacteria + " bacteria");
            //}
            #endregion

            #region While

            // Part 1

            //int number = 1;
            //while (number <= 10)
            //{
            //    Console.WriteLine("Happy Coding!");
            //    number++;
            //}

            // Part 2

            //int i = 1;

            //while (i < 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            // Part 3

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            #endregion

            #region Question

            // Klavyeden girilen 3 basamaklı sayının basamaklarını toplayan kodu yazınız.

            Console.Write("Please enter a three-digit number: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while (number > 0)
            {

                sum += (number % 10);
                number = number / 10;
            }
            Console.Write(sum);

            #endregion

            Console.Read();
        }
    }
}
