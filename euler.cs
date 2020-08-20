using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euler
{
    class Program
    {
        static void Main(string[] args)

        {
            //entrada el valor de x=3
            //salida el valor de e^x
            int x = 3;
            double potencia = 0;
            double total = 0;
            

                for (int i = 0; i < 100; i++)
                {               
                    potencia = Math.Pow(x,(i))/Factorial(i);
                    total += potencia;   
                }
            Console.WriteLine("euler:" + total);
        }

        

        static double Factorial(double valor)
        {
            if (valor <= 1) return 1;
            return valor * Factorial(valor - 1);
        }
    }
}
