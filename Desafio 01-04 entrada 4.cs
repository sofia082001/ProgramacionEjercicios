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

            Console.WriteLine("Ingrese el valor de t:");
            float t = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de c en grados:");
            float c = float.Parse(Console.ReadLine());

            //Se pasa de grados a radianes y luego se opera
            double cRad = c * (Math.PI / 180);
            double y = Math.Cos(cRad) * t;

            double cat = (t * t) - (y * y);
            double z = Math.Sqrt(cat);

            double cat2 = (w * w) - (z * z);
            double catetogrande = Math.Sqrt(cat2);
            double x = catetogrande - y; 
            Console.WriteLine("El valor de x es:" + Math.Round(x));
        }
    }
}
