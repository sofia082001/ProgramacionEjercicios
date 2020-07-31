using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] carta = new int[10]; //Esta matriz contiene los elementos de la matriz [1] a la matriz [10]. 
            int[] carta2 = new int[10]; //espacios de valores           
            int total1 = 0;
            string respuesta = "s";
            bool primerTurno = true;
            Random aleatorio = new Random();
            int i = 0;
            

            Console.WriteLine("| Bienvenido al juego |");
            //Console.WriteLine("Jugador");

            while (total1 < 21 && respuesta == "s" && i < 11)
            {
                if (primerTurno)
                {
                    carta[i] = aleatorio.Next(1, 11);
                    carta2[i] = aleatorio.Next(1, 11);
                    total1 = carta[i] + carta2[i];
                    Console.WriteLine("Carta A: " + carta[i] + " Carta B: " + carta2[i]);
                    Console.WriteLine("Total: " + total1);
                    primerTurno = false;
                }
                else
                {
                    carta[i] = aleatorio.Next(1, 11);
                    total1 += carta[i];
                    Console.WriteLine("Carta: " + carta[i]);
                    Console.WriteLine("Total: " + total1);
                }
                               

                if (total1 < 21)
                {
                    Console.Write("| ¿Desea continuar con otra carta? | (s/n): ");
                    respuesta = Console.ReadLine();
                }
                else if (total1 == 21)
                {
                    Console.WriteLine("Ganaste el juego");
                    break;
                }
                else
                {
                    Console.WriteLine("Perdiste");
                    break;
                }
                i++;
                





                /*/* i = 0;
                Console.WriteLine("Jugador 2");
                while (total1 < 21 && respuesta == "s" && i < 11)
                {
                    carta[i] = aleatorio.Next(1, 11);
                    carta[i] = aleatorio.Next(1, 11);
                    total1 += carta[i] + carta2[i];
                    Console.WriteLine("Carta 1: " + carta[i] + "Carta 2: " + carta[2]);
                    Console.WriteLine("El total es: " + total1);

                    if (total1 < 21)
                    {
                        Console.WriteLine(" Desea continuar con otra carta? (s/n): ");
                        respuesta = Console.ReadLine();
                    }
                    else if (total1 == 21)
                    { 
                        Console.WriteLine("Ganaste el juego");
                        //Console.WriteLine("Total: " + total1);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Perdiste el juego"); 
                        //Console.WriteLine("Total: " + total1);
                        break;
                    }
                }

                if (total > total1)
                {
                    Console.WriteLine("El jugador 1 es el ganador");                
                }
                else if (total == total1) 
                {
                    Console.WriteLine("Empate");                
                }
                else Console.WriteLine("El jugador 2 es el ganador");
                */










            }
            Console.WriteLine(" | Fin del juego |");
        }
    }
}
