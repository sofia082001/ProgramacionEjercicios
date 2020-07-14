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
            Console.WriteLine("Ingrese el valor de d en grados:");
            float d = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de b en grados:");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de y:");
            float y = float.Parse(Console.ReadLine());

            //Se usan arctan para hallar el angulo a
            double bd = b + d;
            double e = 180 - bd;

            //Ya con el valor de e puedo hallar el valor de c
            double c = 180 - e;
            //Paso de grados a radianes
            double cRad = c * (Math.PI /180 );
            //Hallo el lado de z con tangente
            double z = Math.Tan(cRad) * y;
            Console.WriteLine("El valor de z es:" + z);
        }
    }
}
