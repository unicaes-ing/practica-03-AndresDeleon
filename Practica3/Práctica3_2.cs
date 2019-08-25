using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    class Práctica3_2
    {
        static void Main(string[] args)
        {
            //Andrés Lemus 24/07/2019
            Random alea = new Random();
            int num = alea.Next(1,101);
            Console.WriteLine("Número: " + num);
            if (num % 2 == 0)
            {
                Console.WriteLine("El número es par");
            }
            else
            {
                Console.WriteLine("El número es impar");
            }
            Console.ReadKey();
        }
    }
}
