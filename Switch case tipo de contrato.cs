using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba su salario mensual:");
            int salario_mensual = int.Parse(Console.ReadLine());            

            double pension= 0, EPS= 0, arl= 0; 
            int prima = 0;       
            double salario_real_mensual = 0;
            double riesgo = 0;
            double deducciones = 0;            
            double salario_anual = 0;
            bool valido = true;

            int smmlv = 877803;

            double base_cotizacion = salario_mensual * 0.4; //calculo el 40% del salario mensual para saber la base de cotizacion

            if (base_cotizacion < smmlv) base_cotizacion = smmlv; //condicion de la base de cotizacion

            Console.Write("Cual es su tipo de contrato? Escriba (1) si es dependiente, escriba (2) si es independiente:");
            int tipo_contrato = int.Parse(Console.ReadLine());

            switch (tipo_contrato)
            {
                case 1:
                    pension = base_cotizacion * 0.04; //al valor que me de en la cotizacion le saco el 4%                
                    EPS = base_cotizacion * 0.04; // al valor que me de la en la cotizacion le saco el 4%                             
                    arl = 0;
                    prima = salario_mensual;
                    break;

                case 2: //Contrato independiente, no podemos obviar que sea otro valor diferente a dos por eso se pone el else if
                                                  
                    pension = base_cotizacion * 0.16; //se opera con el porcentaje correspondiente
                    EPS = base_cotizacion * 0.125;// se opera con el porcentaje correspondiente

                    Console.Write("Ingrese un numero de 1 a 5 equivalente a la clase de riesgo de en su trabajo:");
                    arl = double.Parse(Console.ReadLine()); 

                    switch (arl)
                    {
                        case 1: riesgo = 0.00522; break;
                        case 2: riesgo = 0.01044; break;
                        case 3: riesgo = 0.02436; break;
                        case 4: riesgo = 0.0435; break;
                        default: riesgo = 0.0696; break;                        
                    }

                    base_cotizacion *= riesgo;
                    arl = base_cotizacion;
                    prima = 0;
                    break;

                default: Console.WriteLine("opcion invalida");

                    valido = false;
                    break;
            }

            if (valido)

            {
                deducciones = pension + EPS + arl;//sumo todas las deducciones 
                salario_real_mensual = salario_mensual - deducciones;//Resto el salario mensual con la suma de las reducciones para obtener el salario real
                Console.Write("El salario real mensual es:...........{0:C}\n", salario_real_mensual);
                salario_anual = (salario_real_mensual * 12) + prima;//Se multiplica por 12 meses + la prima 
                Console.WriteLine("El salario anual es:............{0:C}\n", salario_anual);
            }

        }
    }
}
