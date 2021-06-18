using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int leido;
            int suma, cant, cantImpar;
            suma = cant = cantImpar = 0;

            Console.WriteLine("Ejercicio 1 clase 1\n");
            Console.WriteLine("Ingrese un valor (solo números) - Para salir ingrese 0 (cero):");

            while (!int.TryParse(Console.ReadLine(), out leido))
            {
                Console.WriteLine("El valor no pudo ser leido, solo números..\nIntente nuevamente:");
            };

            while (leido != 0)
            {
                suma += leido;
                cant++;
                if ((leido % 2) == 1)
                {
                    cantImpar++;
                }
                Console.Clear();
                Console.WriteLine("Ingrese otro valor (solo números) - Para salir ingrese 0 (cero):");
                while (!int.TryParse(Console.ReadLine(), out leido))
                {
                    Console.WriteLine("El valor no pudo ser leido, solo números..\nIntente nuevamente:");
                };
            }

            Console.WriteLine("La suma total es: " + suma);
            Console.WriteLine("La cantidad leida fue: " + cant);
            Console.WriteLine("Promedio total: " + suma / (float)cant);
            Console.WriteLine("La cantidad de impares fue: " + cantImpar);
            Console.ReadKey();

        }
    }
}