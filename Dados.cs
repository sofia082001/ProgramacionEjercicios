using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dadoA = 0, dadoB = 0;
            string continuar = "s";
            int totalAcumulado = 0;
            int turnos = 0; 
            Console.WriteLine("| Bienvendo al juego |");
            int pares = 0;
            int totalDados = 0;
            double porcentaje = 0;
                      

            while (continuar == "s") // || (dadoA !=1 && dadoB !=1)
            {
                dadoA = aleatorio.Next(1, 7);
                dadoB = aleatorio.Next(1, 7);
                totalDados = dadoA + dadoB;
                totalAcumulado += dadoA + dadoB;

                if (dadoA == 1 && dadoB == 1)
                {
                    totalAcumulado = 0;
                    Console.WriteLine("Ha perdido");
                    break;
                }

                else if (totalDados  >= 6)//Si la suma de los dos dados da mayor a 6 se suman los turnos 
                {
                    turnos += 1;
                    Console.WriteLine("Turno: " + turnos);
                }
                if (totalAcumulado >= 100)
                {
                    Console.WriteLine("Gano el juego");
                    break;
                }
                                              
                else
                {
                    if (dadoA == dadoB) pares += 1;
                    else pares = 0;
                    Console.WriteLine( "dado A: " + dadoA + " " + "dado B: " + dadoB);
                    Console.WriteLine("Total Acumulado: " + totalAcumulado);
                    Console.WriteLine("Total de los dados: " + totalDados);
                    Console.WriteLine("| ¿Desea continuar con el juego? | (s/n) ");
                    continuar = Console.ReadLine();
                    if (pares == 3)
                    {
                        Console.WriteLine("Gano el juego por 3 veces par");
                        break;
                        
                    }
                }
            }

            porcentaje = (double)(turnos * 100) / totalAcumulado;
            Console.WriteLine("Porcentaje: " + porcentaje);
            Console.WriteLine("Total: " + totalAcumulado);

        }
    }
}
