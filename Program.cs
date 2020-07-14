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
            Console.WriteLine("Ingtrese t:");
            double t = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingtrese a en grados:");
            double a = double.Parse(Console.ReadLine());

            //paso de grados a radianes por que o si no me da negativo
            double zrad = a * (Math.PI / 180);

            //calculo el lado z
            double z = Math.Cos(zrad) * t;
            Console.WriteLine("El valor de z es:" + z);

            //ya con z calculo y (ca:cateto)
            double ca = (t * t) - (z * z);
            double y = Math.Sqrt(ca);
            Console.WriteLine("El valor de y es:" + y);

            //hayo el angulo c, paso de radianes a grados
            double c = Math.Acos(y / t);
            double cgrados = c * (180 / Math.PI);
            Console.WriteLine("El valor de c es:" + cgrados);
            
        }
    }
}
