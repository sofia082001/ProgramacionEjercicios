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
            Console.WriteLine("Ingrese el valor de b en grados:");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de y:");
            float y = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de z:");
            float z = float.Parse(Console.ReadLine());

            //Se usan arctan para hallar el angulo a
            double a = Math.Atan(y / z);
            double aGrados = a * (180 / Math.PI);

            //Se suman los angulos para hallar el angulo del triangulo grande
            double Ang = aGrados + b;
            double AngRad = Ang * (Math.PI / 180);

            // c es el cateto del triangulo grande
            double c = Math.Tan(AngRad) * z;
            double x = c - y;
            Console.WriteLine("El valor de x es:" + Math.Round(x));

        

        }
    }
}
