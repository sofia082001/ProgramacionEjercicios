using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casa_Version_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int vida = 3;
            int acumulaDobles = 0;
            int puntos = 0;
            int pierdeVida = 0;
            string continuar = "s";
            int dadoA = 0;
            int dadoB = 0;
            int dadoC = 0;
            Random aletorio = new Random();
            Console.WriteLine("| Bienvenido al juego |");
            Console.WriteLine("| Vida incial: " + vida);

            while (continuar == "s" && vida > 0 && puntos < 100)
            {
                dadoA = aletorio.Next(1, 7);
                Console.WriteLine(" \n Dado A: " + dadoA);
                puntos += dadoA;
                //Console.WriteLine("Puntos")
                pierdeVida++; //contador para que le reste una vida cada dos turnos
                acumulaDobles++;

                if (pierdeVida == 2)
                {
                    vida--;
                    pierdeVida = 0; //esto es para que se reinicie el contador una vez ya halla entrado por el if
                    Console.WriteLine(" --vida: " + vida + "--");
                    if (vida == 0) //si la vida ya llega a cero pierde inmediatamente
                    {
                        Console.WriteLine("Se le acabaron las vidas, Ha perdido :( ");
                        break;
                    }
                }
                if (acumulaDobles == 3)  // este es el contador para sacar dobles cada tres turnos
                {
                    dadoB = aletorio.Next(1, 7);
                    Console.WriteLine(" Dado B: " + dadoB);
                    dadoC = aletorio.Next(1, 7);
                    Console.WriteLine(" Dado C: " + dadoC);
                    puntos += dadoB + dadoC;
                    acumulaDobles = 0; // se reinica el contador

                    if (dadoB == dadoC) //cuando los dos dados sean iguales (Dobles) entra por esta condicion 
                    {
                        vida++;
                        Console.WriteLine(" Saco Dobles, se le otorga una vida, VIDA: " + vida);
                    }
                }
                Console.WriteLine(" Puntos totales: " + puntos); //se suman los puntos
                if (puntos > 100) Console.WriteLine("Obtuvo mas de 100 puntos, ¡Ha ganado!");
                Console.WriteLine(" \n | ¿Desea continuar el juego? |");
                continuar = Console.ReadLine();
                

            }
        }
    }
}
