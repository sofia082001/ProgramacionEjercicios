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
            //Escribo el titulo del programa
            Console.WriteLine("Programa 1");
            Console.WriteLine(" ");
            
            //ingreso de datos conocidos y y z
            Console.Write("Ingrese y:");
            double y = double.Parse(Console.ReadLine());

            Console.Write("Ingrese z:");
            double z = double.Parse(Console.ReadLine());

            //calculo de la hipotenusa (h)
            double t = (y * y) + (z * z);
            double h = Math.Sqrt(t);
            Console.WriteLine("La hipotenusa es:" + h);
            
            //Math.Asin(valor) me lo calcula en radianes OJO pasarlo a grados 
            double c = Math.Asin(z/h);
            double cgrados = c * (180 / Math.PI);
            double a = Math.Asin(y / h);
            double agrados = a * (180 / Math.PI);

            Console.WriteLine("Los valores de a en radianes es:" + a);
            Console.WriteLine("Los valores de a en grados es:" + agrados);
            Console.WriteLine("Los valores de c en radianes es:" + c);
            Console.WriteLine("Los valores de c en grados es:" + cgrados);             
            Console.ReadKey();
            //readkey es leer una tecla
          
            Console.WriteLine("Programa 2");
            Console.WriteLine(" ");

            //ingreso los datos conocidos t y a 
            Console.Write("ingrese t:");
            double t_1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese a en grados:");
            double a_1 = double.Parse(Console.ReadLine());

            // paso de grados a radianes por que o si no me da negativo el resultado
            double zrad = a_1 * (Math.PI / 180);

            //calculo el lado z 
            double z_1 = Math.Cos(zrad) * t_1;
            Console.WriteLine("El valor de z es:" + z_1);

            //ya con z calculo y__ ca es cateto
            double ca = (t_1 * t_1) - (z_1 * z_1);
            double y_1 = Math.Sqrt(ca);
            Console.WriteLine("El valor de y es:" + y_1);

            //hayo el angulo c paso de radianes a grados
            double c_1 = Math.Acos(y_1 / t_1);
            double c_1grados = c_1 * (180 / Math.PI);
            Console.WriteLine("El valor de c es:" + c_1grados);

            Console.Write("Programa 3");
            Console.Write(" ");

            //ingreso los datos conocidos c y z
            Console.Write("Ingrese c en grados: ");
            double c_2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese z:");
            double z_2 = double.Parse(Console.ReadLine());

            // pimero paso de grados a radianes 
            double yrad = c_2 * (Math.PI / 180);

            //despues calculo el valor de y
            double y_2 = z_2 / Math.Tan(yrad);
            Console.WriteLine("El valor de y es:" + y_2);

            //calculo el valor de la hipotenusa 
            double hp = (y_2 * y_2) + (z_2 * z_2);
            double t_2 = Math.Sqrt(hp);
            Console.WriteLine("El valor de t es:" + t_2);

            //calculo el valor de a con coseno y lo paso de radianes a grados
            double a_ = Math.Acos(z_2 / t_2);
            double a_2 = a_ * (180 / Math.PI);
            Console.WriteLine("El valor de a es:" + a_2);    
            Console.ReadKey();
            




        }
    }
}
