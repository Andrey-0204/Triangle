using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());
            int summ = 0;
            for (int i = a + 1; i < b; i++)
            if (i % 2 == 0)
            {
                Console.WriteLine("Четное число - {0}", i);
            }

            for (int i = a + 1; i < b; i++)
            {
                summ += i;
            }



            Console.WriteLine($"Сумма - {summ}");
            Console.ReadKey();



        }
    }
}
