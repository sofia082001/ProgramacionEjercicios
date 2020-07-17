using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuotaModeradora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su salario en pesos:");
            float salario = float.Parse(Console.ReadLine());

            if (salario < 1755606)
            {
                Console.WriteLine("Debe pagar la tarifa A");
                Console.WriteLine("El valor para una cita general es $3.400");

            }
            else if (1755606 <= salario && salario < 4389015)
            {
                Console.WriteLine("Debe pagar la tarifa B");
                Console.WriteLine("El valor para una cita general es $13.500");
            }
            else
            {
                Console.WriteLine("Debe pagar la tarifa C");
                Console.WriteLine("El valor para una cita general es $35.600");

            }           
        }
    }
}
        
    

