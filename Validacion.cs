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
            Random aleatorio = new Random();
            int suma = 0;
            int a = 0;
            int b = 0;
            int contador = 0;
            a = aleatorio.Next(1, 11);
            b = aleatorio.Next(1, 11);
            suma = a + b;
            //primer intento
            Console.WriteLine("El digito a: " + a);
            Console.WriteLine("El digito b: " + b);
            Console.WriteLine(" | Sume los digitos a y b, escriba la respuesta: ");
            int respuesta = int.Parse(Console.ReadLine());

            //si responde mal tiene otros dos intentos
            while (suma != respuesta && contador != 2)
            {
                a = aleatorio.Next(1, 11);
                b = aleatorio.Next(1, 11);
                suma = a + b;
                Console.WriteLine("validacion incorrecta");
                Console.WriteLine("El digito a: " + a);
                Console.WriteLine("El digito b: " + b);
                Console.WriteLine(" | Sume los digitos a y b, escriba la respuesta: ");
                respuesta = int.Parse(Console.ReadLine());
                contador++;
                if (contador == 2 && suma != respuesta) Console.WriteLine(" | Numero de intentos acabados | ");
            }

            if (suma == respuesta) Console.WriteLine("| Puede continuar...");

        }
    }
}
