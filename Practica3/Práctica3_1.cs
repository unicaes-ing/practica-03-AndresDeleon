using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    class Práctica3_1
    {
        static void Main(string[] args)
        {
            //Andrés Lemus 24/07/2019
            TimeSpan hora;
            Console.WriteLine("Ingrese la cantidad de horas a convertir");
            hora = TimeSpan.Parse(Console.ReadLine());
            double min = hora.TotalMinutes;
            double sec = hora.TotalSeconds;
            if (min > 0)
            {
                Console.WriteLine("Minutos: " + min);
                Console.WriteLine("Segundos: " + sec);
            }
            else
            {
                Console.WriteLine("El valor no puede ser negativo");
            }
            Console.ReadKey();
        }
    }
}
