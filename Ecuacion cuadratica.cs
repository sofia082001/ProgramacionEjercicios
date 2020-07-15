using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcuacionCuadratica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba los coeficientes de la ecuacion cuadradica que debe ser de la forma ( ax^2 + bx + c = 0)");
            Console.Write("Escriba el coeficiente a:");
            float a = float.Parse(Console.ReadLine());

            Console.Write("Escriba el coeficiente b:");
            float b = float.Parse(Console.ReadLine());

            Console.Write("Escriba el coeficiente c:");
            float c = float.Parse(Console.ReadLine());

            //Realizo la opercion del discriminante
            double dis = Math.Sqrt(b * b - 4 * a * c);

            //Primera condicion= Si el discriminante es mayo a cero se realiza la operacion 
            if (dis > 0)
            {
                double x1 = (-b + dis) / 2 * a;
                double x2 = (-b - dis) / 2 * a;
                Console.WriteLine("Los valores de x1:" + x1);
                Console.WriteLine("Los valores de x2:" + x2);
            }
            //Si no se cumple con el primer parametro entonces llega al segundo y realiza la operacion 
            else if (dis == 0)
            {
                double x = (-b + dis) / 2 * a;
                Console.WriteLine("La ecuacion tiene una unica solucion:");
            }
            //si no se cumple ni con el primero ni con el segundo quiere decir que no tiene solucion 
            else 
            {
                Console.WriteLine("No tiene solucion");
            }
        
            
            

            
        }
    }
}
