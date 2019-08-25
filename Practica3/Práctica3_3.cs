using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    class Práctica3_3
    {
        static void Main(string[] args)
        {
            //Andrés Lemus 24/07/2019
            int num1, num2, num3;
            Console.Write("Primer Número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo Número: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tercer Número: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                if (num2 > num3)
                {
                    Console.WriteLine("Números en orden ASD: {0} {1} {2} ", num3, num2, num1);
                }
                else
                {
                    if (num1 > num3)
                    {
                        Console.WriteLine("Números en orden ASD: {0} {1} {2} ", num2, num3, num1);
                    }
                    else
                    {
                        Console.WriteLine("Números en orden ASD: {0} {1} {2} ", num2, num1, num3);
                    }
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine("Números en orden ASD: {0} {1} {2} ", num1, num3, num2);
                }
                else
                {
                    if (num1 > num3)
                    {
                        Console.WriteLine("Números en orden ASD: {0} {1} {2} ", num3, num1, num2);
                    }
                    else
                    {
                        Console.WriteLine("Números en orden ASD: {0} {1} {2} ", num1, num2, num3);
                    }
                } 
            }
            Console.ReadKey();
        }    
    }
}
