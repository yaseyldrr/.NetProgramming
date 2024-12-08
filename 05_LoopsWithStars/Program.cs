using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ten Stars Vertically

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}
            #endregion

            #region Ten Stars Horizontally

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region Right-Angled Triangle

            //String star = "*";
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(star);
            //    star += "*";
            //}

            //Console.WriteLine("---------------------");


            //for (int i = 0; i <= 10; i++)
            //{
            //    for (int j = 0; j <= i; j++) // Her adımda i kadar yazdırcak, 0dan başlayarak
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Inverted Right-Angled Triangle

            //for (int i = 10; i >= 0; i--)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}



            #endregion

            #region Question
            //for (int i = 0; i <= 10; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 10; i >= 0; i--)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Lozenge Shape

            //int height = 5;

            //for (int i = 1; i <= height; i++)
            //{
            //    for (int j = height - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //int height = 5; // Üçgenin yüksekliği

            //for (int i = 1; i <= height; i++)
            //{
            //    // Boşluklar
            //    for (int j = height - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    // Yıldızlar
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            //for (int i = height - 1; i >= 1; i--) 
            //{
            //    // Boşluklar
            //    for (int j = height - i; j > 0; j--) 
            //    {
            //        Console.Write(" ");
            //    }
            //    // Yıldızlar
            //    for (int k = 1; k <= 2 * i - 1; k++) 
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Pyramid Shape

            int n = 5;
            for (int i = 1; i <= n; i++)
            {

                for (int j = n - i; j > 0; j--) // Boşluklar
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2*i - 1; k++) // Yıldızlar
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }


                #endregion

                Console.ReadLine();
        }
    }
}
