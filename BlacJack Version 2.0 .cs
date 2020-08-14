using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack_Multiplayer
 {
    class Program
    {
        static void Main(string[] args)
        {
            int carta = 0;  
            int carta2 = 0;           
            int total = 0;
            string respuesta = "s";
            bool primerTurno = true;
            int jugadores = 0;
            int turnos = 0;
            int max = 0; //para saber el jugador que mas obtuvo puntos
            int  jugador = 0;
            string nombreJugador = " ";
            string Sigue = " ";
            int empate = 0; //por si hay algunos jugadores que obtiene el mismo resultado
            int nadieGana = 0; //cuando nadie ha ganado xd
            Random aleatorio = new Random();
           

            Console.WriteLine("| Bienvenido al juego |");
            Console.WriteLine("Numero de jugadores min 2 y max 5: ");
            jugadores = int.Parse(Console.ReadLine());

            while (jugadores < 2 || jugadores > 5) //para obligar a los jugadores a responder 
            {
                Console.WriteLine("! NO es posible ese numero de jugadores!");
                Console.WriteLine("Numero de jugadores: ");
                jugadores = int.Parse(Console.ReadLine());
            }

            while (turnos < jugadores) //mientras que los turnos (que se van sumando) sean menores al numero de jugadores ingresados entonces se cumple el while
            {
                while (respuesta == "s" && Sigue != "no sigue") //mientras la respuesta sea s y no sigue sea diferente de no sigue 
                {

                    if (primerTurno) // e; bool primer turno viene verdadero y entra al if luego se le pone en falso para que no vuelva a entrar
                    {
                        jugador++; //empieza el conteo de jugadores
                        Console.WriteLine("\n Bienvenido jugador #: " + jugador); //se menciona el jugador 
                        carta = aleatorio.Next(1, 12); //el jugador recibe dos cartas al iniciar el primer turno
                        carta2 = aleatorio.Next(1, 12);
                        total = carta + carta2;
                        Console.WriteLine("Carta A: " + carta + " Carta B: " + carta2);
                        Console.WriteLine("Total: " + total);
                        primerTurno = false; // declaro falso el bool llamado primer turno para que no vuelva a entrar 

                    }

                    else //viene falso es decir que se le seguira dando solo una carta
                    {
                        carta = aleatorio.Next(1, 12);
                        total += carta;
                        Console.WriteLine("Carta: " + carta);
                        Console.WriteLine("Total: " + total);
                    }


                    if (total < 21) // si el total es menor a 21 se le sigue preguntando
                    {
                        if (total > max) // si el total que ya viene es mayor que el maximo entonces el maximo se convierte en el total 
                        {
                            max = total;
                            nombreJugador = jugador.ToString();  //esto quiere decir que el nombre del jugador va ser el puesto que le toque, indicado en el contador de jugadores ejemplo nombreJugadoor = 1
                                                                 //converti el int jugador en string
                        }
                        Console.Write("| ¿Desea continuar con otra carta? | (s/n): ");
                        respuesta = Console.ReadLine();

                    }
                    else if (total == 21) //si es iguala 21 el maximo se vuelve el total y se pone "no sigue" para que no siga en el while y se pone el nombre del jugador
                    {
                        max = total;
                        Sigue = "no sigue";
                        nombreJugador = jugador.ToString();
                        Console.WriteLine("Obtuvo 21 :D");
                        empate++; // se suma el contador de empate por si ocurre un posible empate entre los jugadores 

                    }
                    else //si es mayor que 21 se inicializa la variable max (por que solo es hasta 21) y se pone no sigue y respuesta "n" para que no entre otra vez al while
                    {
                        max = 0;
                        respuesta = "n";
                        Sigue = "no sigue";
                        Console.WriteLine("Obtuvo mas que 21 :(");
                        nadieGana++; //se acumula por si todos sacan mas de 21 
                    }
                }

                turnos++; // se suman los turnos llevados 
                respuesta = "s"; //la respuesta se debe reiniciar para el nuevo jugador
                total = 0; //el total se debe reiniciar parael nuevo jugador
                primerTurno = true; //se vuelve a poner el bool para que vuelva a entrar en el if de las dos primeras cartas
                Sigue = " "; //se inicializa no sigue para que pueda entrar al while 
            }
            if (nadieGana == jugadores) // esto quiere decir que si todos sacaron mas de 21 nadie gana (si el contador de los que sacaron > 21 es igual al numero de jugadores quiere decir que nadie gana) 
            {
                Console.WriteLine("Nadie gano >:(");
            }
            
            else if (empate >= 2) // si el acumulador de empate es igual o mayor a dos existieron dos o mas personas ganadoras 
            {
                Console.WriteLine("Hubo empate :o ");
            }
            else
            {
                Console.WriteLine("\n El ganador es:" + nombreJugador);
            }
            Console.WriteLine(" | Fin del juego |");
        }
    }
}
