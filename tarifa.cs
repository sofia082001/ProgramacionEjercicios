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
            // 1 smlmv 877.803
            // 2 smlmv 1'755.606
            // 3 smlmv 2'633.409
            // 4 smlmv 3'511.212
            // 5 smlmv 4'389.015


            Console.WriteLine("Cuantos SMLMV se gana mensualmente? :");
            float salario = float.Parse(Console.ReadLine());

            double smlmv = salario * 877803;
            

            if (smlmv < 1755606) 
            {
                Console.WriteLine("Debe pagar la tarifa A");                
                Console.WriteLine("El valor que debe pagar para entrara los bolos es $20800");
                

            }
            else if (1755606 <= smlmv && smlmv < 3511212 )
            {
                Console.WriteLine("Debe pagar la tarifa B");               
                Console.WriteLine("El valor que debe pagar para entrar a bolos es $22900");
            }
            else
            {
                Console.WriteLine("Debe pagar la tarifa C");                
                Console.WriteLine("El valor que debe pagar mensualmente a bolos es $29300");
            }
        }
    }
}
