using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    class Práctica3_5
    {
        static void Main(string[] args)
        {
            int num;
            string nomb = "";
            Console.WriteLine("Ingrese un número entre 1 y 10");
            num = Convert.ToInt32(Console.ReadLine());
            if (num == 1)
            {
                nomb = "Uno";
            }
            else
            {
                if (num == 2)
                {
                    nomb = "Dos";
                }
                else
                {
                    if (num == 3)
                    {
                        nomb = "Tres";
                    }
                    else
                    {
                        if (num == 4)
                        {
                            nomb = "Cuatro";
                        }
                        else
                        {
                            if (num == 5)
                            {
                                nomb = "Cinco";
                            }
                            else
                            {
                                if (num == 6)
                                {
                                    nomb = "Seis";
                                }
                                else
                                {
                                    if (num == 7)
                                    {
                                        nomb = "Siete";
                                    }
                                    else
                                    {
                                        if (num == 8)
                                        {
                                            nomb = "Ocho";
                                        }
                                        else
                                        {
                                            if (num == 9)
                                            {
                                                nomb = "Nueve";
                                            }
                                            else
                                            {
                                                if (num == 10)
                                                {
                                                    nomb = "Diez";
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Número no Válido");
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("El nombre del número es: " + nomb);
            Console.ReadKey();
        }
    }
}
