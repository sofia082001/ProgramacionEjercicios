using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Ejercicio_Clase__Boole_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero de votos por el partido 1");
            float Partido1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Numero de votos por el partido 2");
            float Partido2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Numero de votos en blanco");
            float Votosblancos = float.Parse(Console.ReadLine());

            Console.WriteLine("Numero de votos anulados");
            float Votosanulados = float.Parse(Console.ReadLine());

            Console.WriteLine("Numero total habitantes");
            float n = float.Parse(Console.ReadLine());

            Console.WriteLine("porcentaje de la poblacion mayor de edad ");
            float p = float.Parse(Console.ReadLine());

            double porcentaje = p / 100; //pasando a decimales
            double totaldevotantes = Partido2 + Partido1 + Votosanulados + Votosblancos; //sumo todos los votos
            Console.WriteLine("Total de votantes: " + totaldevotantes);

            double mayoresdeedad = n * porcentaje; //calculo los mayores de edad
            Console.WriteLine("Mayores de edad: " + mayoresdeedad);

            double abstencion = mayoresdeedad - totaldevotantes; //calculo la abstencion
            Console.WriteLine("Abstencion: " + abstencion);

            double ab = Partido1 + Partido2; //suma de votos de los dos partidos

            bool a = (ab * 0.30) < Votosanulados; //Si los votos anulados son menos del 30% de los votos A y B combinados
            bool b = ab > Votosblancos;//los votos de A y B combinados son mayores a los votos en blanco
            bool c = abstencion < totaldevotantes; // la abstención es menor al número de votantes

            if ((a || b) && c)
            {
                Console.WriteLine("Las votaciones fueron existosas");

                if (Partido1 > Partido2)
                {
                    Console.WriteLine("Ganador de las elecciones: A");
                }
                else
                {
                    Console.WriteLine("Ganador de las elecciones: B");
                }
            }

            else
            {
                Console.WriteLine("Las votaciones se deben realizar nuevamente");               
                
            }
        }
    }
}
