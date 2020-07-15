using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se ingresan los datos de entrada en este caso el peso y la altura

            Console.WriteLine("Ingrese su peso en Kg:");
            float kg = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su estatura en metros:");
            float m = float.Parse(Console.ReadLine());

            double m2 = m * m;
            double imc = kg / m2;

            Console.WriteLine("El indice de masa corporal es:" + imc);

            if (imc < 18.5)
            {
                Console.WriteLine("Su peso esta por debajo de lo normal");
            }
            else if (18.5 <= imc && imc <= 24.9)
            {
                Console.WriteLine("Su peso esta dentro lo normal");
            }
            else if (25.0 <= imc && imc <= 29.9)
            {
                Console.WriteLine("Su peso es superior a lo normal, tiene sobrepeso! ");
            }
            else if (imc > 30.0)
            { Console.WriteLine("Sufre obesidad, por favor deje de tragar!"); }

            }
        }
    }

