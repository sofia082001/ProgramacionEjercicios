using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos_de_contrato
{
    class Program
    {

        static void Main(string[] args)
        {
            int smmlv = 877803;
            double pension; //declare primero las variables de deducciones
            double EPS;
            double prima;
            double valor_cotizacion;
            int clase_riesgo = 0;
            double salario_real_mensual = 0;
            double riesgo = 0;
            double deducciones = 0;
            int arl = 0;

            Console.Write("Escriba su salario mensual:");
            double salario_mensual = double.Parse(Console.ReadLine());

            Console.Write("Cual es su tipo de contrato? Escriba (1) si es dependiente, escriba (2) si es independiente:");
            int tc = int.Parse(Console.ReadLine());

            if(tc == 2)
            {
            Console.Write("Ingrese un numero de 1 a 5 equivalente a la clase de riesgo de en su trabajo:");
            clase_riesgo = int.Parse(Console.ReadLine());
            }

            //Salidas:
            //Salario real mensual: salario mensual -deducciones 
            //Salario anual con deducciones y con bonificación.El salario anual(12 meses) incluye una bonificación(prima), si y sólo si es contrato laboral(dependiente)

            if (tc == 1) //contrato dependiente
            {                                        
                valor_cotizacion = salario_mensual * 0.4; //calculo el 40% del salario mensual para saber la base de cotizacion 

                if (valor_cotizacion < smmlv) //si el 40% es menor que el salario minimo 
                {
                    valor_cotizacion = smmlv;// establesco que el salario=salario minimo                  
                }
               
                pension = valor_cotizacion * 0.04; //al valor que me de en la cotizacion le saco el 4% 
                Console.WriteLine("El valor de la pension es..........:{0:C}\n", pension);
                EPS = valor_cotizacion * 0.04;
                Console.WriteLine("El valor de la EPS es..........:{0:C}\n", EPS);
                prima = salario_mensual; // la prima es igual al salario mensual

                //imprimo la salida 
                deducciones = pension + EPS + arl;//sumo todas las deducciones 
                salario_real_mensual = salario_mensual - deducciones;//Resto el salario mensual con la suma de las reducciones para obtener el salario real
                Console.Write("El salario real mensual es:...........{0:C}\n" , salario_real_mensual);

                double salario_anual = (salario_mensual * 12) - (deducciones * 12) + prima;//Se multiplica por 12 meses luego se restan el salario mensual con las deducciones
                Console.WriteLine("El salario anual es:............{0:C}\n" , salario_anual);
                Console.WriteLine("El valor de la prima es..........:{0:C}\n", prima);
            }


            else if (tc == 2)//Contrato independiente, no podemos obviar que sea otro valor diferente a dos por eso se pone el else if
            {
               
                valor_cotizacion = salario_mensual * 0.4; //calculo el 40% del salario mensual para saber la base de cotizacion 

                if (valor_cotizacion < smmlv) //si me da menor que el smmlv 
                {
                    valor_cotizacion = smmlv;//realizo esta relacion
                }               
                pension = valor_cotizacion* 0.16; //se opera con el porcentaje correspondiente
                Console.WriteLine("El valor de la pension es..........:{0:C}\n", pension);
                EPS = valor_cotizacion * 0.125;// se opera con el porcentaje correspondiente
                Console.WriteLine("El valor de la EPS es.........:{0:C}\n", EPS);

                //se pone la condicion dependiendo de lo que ponga el usuario
                if (clase_riesgo == 1) 
                {
                    riesgo = valor_cotizacion * 0.00522;
                    Console.WriteLine("El valor de riesgo:", riesgo);
                }

                if (clase_riesgo == 2)
                {
                    riesgo = valor_cotizacion * 0.01044;
                    Console.WriteLine("El valor de riesgo "+ riesgo);
                }

                if (clase_riesgo == 3)
                {
                    riesgo = valor_cotizacion * 0.02436;
                    Console.WriteLine("El valor de riesgo:", riesgo);
                }

                if (clase_riesgo == 4)
                {
                    riesgo = valor_cotizacion * 0.0435;
                    Console.WriteLine("El valor de riesgo:"+ riesgo);
                }

                if (clase_riesgo == 5)
                {
                    riesgo = valor_cotizacion * 0.0696;
                    Console.WriteLine("El valor de riesgo:"+ riesgo);
                }

                //imprimo la salida

                deducciones = pension + EPS + riesgo; //sumo las deducciones 
                salario_real_mensual = salario_mensual - deducciones; 
                Console.WriteLine("El salario real mensual es..........:{0:C}\n" , salario_real_mensual);               

                double salario_anual = (salario_mensual * 12) - (deducciones * 12);
                Console.WriteLine("El salario anual es..........:{0:C}\n", salario_anual);
            }
            
             



        }
    }
}
