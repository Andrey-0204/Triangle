using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //for (int i = 0; i < 10; i++)       //треугольник
            //{

            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }


            //    Console.WriteLine();
            //}

            //Console.WriteLine("\n");

            int height = 9, spaces, stars, i;         //ромб

            for (i=0; i < height/2; i++)
            {
                spaces = height - (i + 1);
                stars = 1 + (i * 2);

                for (int q = 0; q < spaces; q++)
                    Console.Write(" ");
                for (int q = 0; q < stars; q++)
                    Console.Write("*");


                Console.WriteLine();
            }

            for (; i >= 0; i--)
            {
                spaces = height - (i + 1);
                stars = 1 + (i * 2);

                for (int q = 0; q < spaces; q++)
                    Console.Write(" ");
                for (int q = 0; q < stars; q++)
                    Console.Write("*");

                Console.WriteLine();

            }

            Console.ReadKey();

            //Console.WriteLine("\n");                      //прямоугольник

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.Write("[]");
            //    }

            //    Console.WriteLine();
            //}



            //Console.ReadKey();


        }

    }
}
