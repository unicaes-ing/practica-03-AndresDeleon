using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    class Práctica3_6
    {
        static void Main(string[] args)
        {
            decimal precio = 0, desc = 0, vF;
            Console.WriteLine("Ingrese el precio del producto");
            precio = Convert.ToDecimal(Console.ReadLine());
            if (precio >= 0 && precio <= 100)
            {
                desc = 0;
            }
            else
            {
                if (precio > 100 && precio <= 200)
                {
                    desc = precio * Convert.ToDecimal(0.12);
                }
                else
                {
                    if (precio > 200 && precio <= 500)
                    {
                        desc = precio * Convert.ToDecimal(0.15);
                    }
                    else
                    {
                        if (precio > 500)
                        {
                            desc = precio * Convert.ToDecimal(0.2);
                        }
                        else
                        {
                            Console.WriteLine("Precio no Válido");
                        }
                    }
                }
            }
            vF = precio - desc;
            Console.WriteLine("Precio a pagar: " + vF.ToString("C2"));
            Console.WriteLine("Descuento realizado: " + desc.ToString("C2"));
            Console.ReadKey();
        }
    }
}
