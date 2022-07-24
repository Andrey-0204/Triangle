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
            for (int i = 0; i < heigth; i++)       //прямоугольник
            {

                for (int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }


                Console.WriteLine();
            }
        }
        static void DrawTriangle(int width, bool vverh)
        {
            if(vverh == true)
            {
                for (int i = 0; i < width; i++)       //треугольник
                {

                    for (int j = width; j > 0; j--)
                    {
                        if (i >= j) Console.Write("*");
                        else Console.Write(" ");
                    }
                    for (int j = 0; j < width; j++)
                    {
                        if (i >= j) Console.Write("*");
                        else Console.Write(" ");
                    }

                    Console.WriteLine();

                }


            }
            else
            {
                for (int i = width; i > 0; i--)       //треугольник
                {

                    for (int j = width; j > 0; j--)
                    {
                        if (i >= j) Console.Write("*");
                        else Console.Write(" ");
                    }
                    for (int j = 0; j < width; j++)
                    {
                        if (i >= j) Console.Write("*");
                        else Console.Write(" ");
                    }

                    Console.WriteLine();

                }
            }

        }


        static void Main(string[] args)
        {
            DrawTriangle(15, true);
            DrawTriangle(15, false);
            //DrawRectangle(5, 5);
            Console.ReadLine();
        }
    }
}
