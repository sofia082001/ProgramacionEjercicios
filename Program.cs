﻿using System;
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
            //se le indica al usuario que ingrese el numero binario uno por uno
            Console.WriteLine("ingrese el primer digito:");
            int b0 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el segundo digito:");
            int b1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el tercer digito:");
            int b2 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el cuarto digito:");
            int b3 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el quinto digito:");
            int b4 = int.Parse(Console.ReadLine());

            // se multiplica por los numeros correspondientes 
            int d0 = (b0 * 16);
            int d1 = (b1 * 8);
            int d2 = (b2 * 4);
            int d3 = (b3 * 2);
            int d4 = (b4 * 1);

            //mas ordenado
            int ndecimal = (d0 + d1 + d2 + d3 + d4);

            // Sale el resultado en decimal
            Console.WriteLine("El numero decimal es:" + ndecimal);

        }
    }
}
