using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    class Práctica_3_7
    {
        static void Main(string[] args)
        {
            double conv = 0, valor = 0;
            int op1, op2;
            Console.WriteLine("CONVERTIDOR DE UNIDADES DE MASA");
            Console.WriteLine("====================================");
            Console.WriteLine("[1] Onza");
            Console.WriteLine("[2] Libra");
            Console.WriteLine("[3] Gramo");
            Console.WriteLine("[4] Tonelada");
            Console.WriteLine("Unidad que se quiere convertir");
            op2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Valor de la unidad: ");
            valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Seleccione la unidad a la que desea convertir:");
            op1 = Convert.ToInt32(Console.ReadLine());
            switch (op1)
            {
                case 1:
                    if (op2 == 2)
                    {
                        conv = valor / Convert.ToDouble(0.0625);
                    }
                    else
                    {
                        if (op2 == 3)
                        {
                            conv = valor / Convert.ToDouble(28.3495);
                        }
                        else
                        {
                            if (op2 == 4)
                            {
                                conv = valor * Convert.ToDouble(35274);
                            }
                            else
                            {
                                Console.WriteLine("Opción no Válida");
                            }
                        }
                    }
                    break;
                case 2:
                    if (op2 == 1)
                    {
                        conv = valor / Convert.ToDouble(16);
                    }
                    else
                    {
                        if (op2 == 3)
                        {
                            conv = valor / Convert.ToDouble(453.592);
                        }
                        else
                        {
                            if (op2 == 4)
                            {
                                conv = valor / Convert.ToDouble(0.000453592);
                            }
                            else
                            {
                                Console.WriteLine("Opción no Válida");
                            }
                        }
                    }
                    break;
                case 3:
                    if (op2 == 1)
                    {
                        conv = valor / Convert.ToDouble(0.035274);
                    }
                    else
                    {
                        if (op2 == 2)
                        {
                            conv = valor / Convert.ToDouble(0.00220462);
                        }
                        else
                        {
                            if (op2 == 4)
                            {
                                conv = valor / Convert.ToDouble(1000000);
                            }
                            else
                            {
                                Console.WriteLine("Opción no Válida");
                            }
                        }
                    }
                    break;
                case 4:
                    if (op2 == 1)
                    {
                        conv = valor / Convert.ToDouble(35274);
                    }
                    else
                    {
                        if (op2 == 2)
                        {
                            conv = valor / Convert.ToDouble(2204.62);
                        }
                        else
                        {
                            if (op2 == 3)
                            {
                                conv = valor / Convert.ToDouble(1000000);
                            }
                            else
                            {
                                Console.WriteLine("Opción no Válida");
                            }
                        }
                    }
                    break;
            }
            Console.WriteLine("Su conversión es: " + conv);
            Console.ReadKey();
        }
    }
}
