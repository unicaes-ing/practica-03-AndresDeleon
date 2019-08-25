using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    class Práctica3_4
    {
        static void Main(string[] args)
        {
            //Andrés Lemus 24/07/2019
            int min;
            string zona;
            double precio = 0;
            Console.Write("Minutos de duración de la llamada: ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zona de la llamada (C = central, Or = oriental, Oc = Occidental): ");
            zona = Console.ReadLine();
            if (zona == "C")
            {
                precio = 0.25 * Convert.ToDouble(min);
            }
            else
            {
                if (zona == "Or")
                {
                    precio = 0.36 * Convert.ToDouble(min);
                }
                else
                {
                    if (zona == "Oc")
                    {
                        precio = 0.32 * Convert.ToDouble(min);
                    }
                    else
                    {
                        Console.WriteLine("Opción no Válida");
                    }
                }
            }
            Console.WriteLine("Cantidad a pagar: " + precio.ToString("C"));
            Console.ReadKey();

        }
    }
}
