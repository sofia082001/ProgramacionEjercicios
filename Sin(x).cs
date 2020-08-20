using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seno
{
    class Program
    {
        static void Main(string[] args)
        {
            //entrada es x
            //salida es sin(x)

            double x = 0.5;
            double operacion = 0;
            double total = 0;

            for( int i = 0; i < 100; i++)
            {
                operacion = Math.Pow(-1, i) * Math.Pow(x, (2 * i) + 1) / Factorial((2*i) + 1);
                total += operacion;
            }
            Console.WriteLine("El valor aprocimado de sin(x) es: " + total);

        }

        static double Factorial(double valor)
        {
            if (valor <= 1) return 1;
            return valor * Factorial(valor - 1);
        }

    }
}
