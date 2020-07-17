using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarifa
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese su salario mensual :");
            float salario = float.Parse(Console.ReadLine());
            
            if (salario < 1755606)          
            {
                Console.WriteLine("Debe pagar la tarifa A");                
            }
            
            else if (1755606 <= smlmv && smlmv < 3511212 )
            {
                Console.WriteLine("Debe pagar la tarifa B");                               
            }
            
            else
            {
                Console.WriteLine("Debe pagar la tarifa C");                
            }
        }
    }
}
