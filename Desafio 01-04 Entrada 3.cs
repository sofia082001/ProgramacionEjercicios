using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresamos los datos conocidos
            Console.WriteLine("Ingrese el valor de w:");
            float w = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de d en grados:");
            float d = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de x:");
            float x = float.Parse(Console.ReadLine());

            //Primero hallo el cateto c del triangulo mas grande

            double dRad = d * (Math.PI / 180);
            double c = Math.Cos(dRad) * w;

            double y = c - x;
            Console.WriteLine("El valor de y es:" + Math.Round(y));

          
        }
    }
}
