using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = 6, spaces, stars, i;         

            for (i = 0; i < height / 2; i++)
            {
                spaces = height - (i + 4);
                stars = 1 + (i * 2);

                for (int q = 0; q < spaces; q++)
                    Console.Write(" ");
                for (int q = 0; q < stars; q++)
                    Console.Write("*");

                //int shirina = 10;
                //int visota = 8;

                //for (int i = 0; i < visota; i++)
                //{
                //    for (int j = 0; j < shirina; j++)
                //    {
                //        Console.Write("*");
                //    }

                Console.WriteLine();
            }

            Console.ReadKey();


        }
    }
}
