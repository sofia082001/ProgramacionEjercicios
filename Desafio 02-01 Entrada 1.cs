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
            //ingrese los datos conocidos
            Console.WriteLine("Ingtrese y:");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingtrese z:");
            double z = double.Parse(Console.ReadLine());

            //calculo la hipotenusa
            double t = (y * y) + (z * z);
            double h = Math.Sqrt(t);
            Console.WriteLine("La hipotenusa es:" + h);

            //Math.Asin (valor) me lo calcula en radianes ojo pasarlo primero a grados
            double c = Math.Asin(z / h);
            double cgrados = c * (180 / Math.PI);
            double a = Math.Asin(y / h);
            double agrados = a * (180 / Math.PI);

            Console.WriteLine("Los valores de a en radianes es:" + a);
            Console.WriteLine("Los valores de a en grados es:" + agrados);
            Console.WriteLine("Los valores de c en radianes es:" + c);
            Console.WriteLine("Los valores de c en grados es:" + cgrados);

        }
    }
}
