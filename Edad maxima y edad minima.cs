using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while2
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;

            Console.WriteLine("Ingrese el numero de datos(n): ");
            int n = int.Parse(Console.ReadLine());
            int contador = 0, max = 0, min = 200;
            string nombreMayor = " ";
            string nombreMenor = " ";

            while (contador < n)
            {
                Console.WriteLine("Escriba su nombre: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("Edad:");
                int edad = int.Parse(Console.ReadLine());              

                if (edad > max)
                {
                    max = edad;
                    nombreMayor = nombre;
                }

                if (edad < min)
                {
                    min = edad;
                    nombreMenor = nombre;
                }

                total += edad;
                contador++;// esto es lo mismo que decir contador = +1

            }

            //Console.WriteLine("El mayor tiene: " + max);
            Console.WriteLine("El nombre del mayor es: " + nombreMayor + " | Su edad: " + max);
            //Console.WriteLine("El menor tiene: " + min);
            Console.WriteLine("El nombre del menor es: " + nombreMenor + " | Su edad: " + min);
            double promedio = (double) (total) / n;
            Console.WriteLine("Promedio: " + promedio);
        }
    }
}
