using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int client;
            //int factorial = 1;

            //Console.Write("Введите количество клиентов, сделай свой выбор: ");
            //client = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= client; i++)
            //{
            //    factorial *= i;
            //if (i == client)
            //{
            //    Console.Write("{0}", i);
            //}
            //else
            //{
            //    Console.Write("{0} * ", i);
            //}
            //}

            //Console.Write(" = {0} - количество маршрутов", factorial);
            //Console.ReadKey();
            int client = 0;
            int factorial = 1;
            int marshryt = 1;
            Console.Write("Введите количество клиентов, сделай свой выбор: ");
            client = int.Parse(Console.ReadLine());

            Console.Write("\n\n {0} = " , client + " клиента");

            do
            {
                factorial *= marshryt;
                marshryt++;
            }
            while(marshryt <= client);

            Console.WriteLine(factorial + " маршрутов");
        }
    }
}
    
