using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglo_de_datos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombre = { "Tanjiro", "Nezuko", "Zentitsu", "Inosuke", "Genya", "Kanao", "Tamioka" };
            double[] estatura = { 165, 153, 164.5, 164, 180, 156, 176 };
            double total = 0;
            double distancia = 0;
            double min = 2000;
            string elMasCercanoAlPromedio = " ";

            for (int i = 0; i < estatura.Length ; i++) //doble tab, no olvidar .lenght
            {
                total += estatura[i];
            }

            double promedio = total / estatura.Length; //math.abs
            
            for (int i = 0; i < estatura.Length ; i++)
            {
                distancia = Math.Abs(promedio - estatura[i]); // Se resta el promedio con cada estatura, valor absoluto para calcular en valores positivos
                Console.WriteLine("La distancia que hay entre el promedio: " + promedio + "  y  " + estatura[i] + "  Es: " + distancia);

                if (distancia  < min) //si la resta es menor al minimo, con este se calcula la estatura mas cercana al promedio
                {
                    min = distancia;
                    elMasCercanoAlPromedio = nombre[i];   
                }

            }
            Console.WriteLine("El promedio es: " + promedio);
            Console.WriteLine("\n El mas cercano al promedio es: " + elMasCercanoAlPromedio);

            
            for (int i = 0; i < estatura.Length; i++) // ESTATURAS ORGANIZADAS DE MENOR A MAYOR
            {
                for (int k = 0; k < estatura.Length-1; k++) // se le resta -1 al numero total de arreglos para que no me compare el ultimo con nada
                {
                    if(estatura[k] > estatura[k+1]) //si la estatura en la posicion k es mayor a la estatura en la posicion k+1
                    {
                        double temporal = estatura[k]; //se declara una variable para que el numero quede en la posicion anterior a la que ya remplazo 
                        estatura[k] = estatura[k + 1]; // la estatura en la posicion k se reemplaza por la estatura en la posicion k+1
                        estatura[k + 1] = temporal;// la estatura de la posicion k + 1 toma el lugar de la k y por eso se le debe poner que es igual a k 
                      
                        string nombretemporal = nombre[k]; 
                        nombre[k] = nombre[k + 1];
                        nombre[k + 1] = nombretemporal;
                        
                    }

                    
                }

                Console.WriteLine(nombre[i] + " " + estatura[i]);
            }


        }
    }
}
