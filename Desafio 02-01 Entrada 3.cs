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
            //Ingreso los datos conocidos
            Console.WriteLine("Ingrese c en grados:");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese z:");
            double z = double.Parse(Console.ReadLine());

            //primero paso de grados a radianes 
            double yrad = c * (Math.PI / 180);

            //despues calculo el valor de y
            double y = z / Math.Tan(yrad);
            Console.WriteLine("El valor de y es:" + Math.Round(y));

            //calculo el valor de la hipotenusa
            double hp = (y * y) + (z * z);
            double t = Math.Sqrt(hp);
            Console.WriteLine("El valor de t es:" + t);

            //calculo el valor de a con coseno y lo pado de radianes a grados
            double acos = Math.Acos(z / t);
            double a = acos * (180 / Math.PI);
            Console.WriteLine("El valor de a es:" + a);

        
        
        }
    }
}
