using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class Program
    {
        static void DrawRectangle(int heigth, int width)
        {
            for (int i = 0; i < heigth; i++)       //треугольник
            {

                for (int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }


                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            DrawRectangle(4, 15);
            Console.ReadLine();
        }
    }
}
