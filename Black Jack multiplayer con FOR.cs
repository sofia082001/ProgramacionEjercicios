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
            //int total = 0;
            string respuesta = "s";
            bool primerTurno = true;
            int jugadores = 0;
            int turnos = 0;
            int max = 0; //para saber el jugador que mas obtuvo puntos          
            int empate = 0; //por si hay algunos jugadores que obtiene el mismo resultado
            int nadieGana = 0; //cuando nadie ha ganado xd
            string[] nombres = new string[5];
            int[] puntaje = new int[5];
            double diferencia = 0;
            double min = 20000; //se pone el valor grande para que pueda entrar a la condicion
            int eLMasCercanoA21 = 0;
            string elNombreCercano = " ";

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

            for (int i = 0; i < jugadores; i++)
            {
                Console.WriteLine("Escriba el nombre de los jugadores: ");
                nombres[i] = Console.ReadLine(); 
            }

            while (turnos < jugadores) //mientras que los turnos (que se van sumando) sean menores al numero de jugadores ingresados entonces se cumple el while
            {
                while (respuesta == "s") //mientras la respuesta sea s y no sigue sea diferente de no sigue 
                {

                    if (primerTurno) // e; bool primer turno viene verdadero y entra al if luego se le pone en falso para que no vuelva a entrar
                    {
                        //jugador++; //empieza el conteo de jugadores
                        Console.WriteLine("\n Bienvenid@: " + nombres[turnos]); //se menciona el jugador del turno en que este ej turno [o] llama al jugasdor que este en la casilla [0]
                        carta = aleatorio.Next(1, 12); //el jugador recibe dos cartas al iniciar el primer turno
                        carta2 = aleatorio.Next(1, 12);
                        puntaje[turnos] = carta + carta2;
                        Console.WriteLine("Carta A: " + carta + " Carta B: " + carta2);
                        Console.WriteLine("Total: " + puntaje[turnos]);
                        primerTurno = false; // declaro falso el bool llamado primer turno para que no vuelva a entrar 

                    }

                    else //viene falso es decir que se le seguira dando solo una carta
                    {
                        carta = aleatorio.Next(1, 12);
                        puntaje[turnos] += carta;
                        Console.WriteLine("Carta: " + carta);
                        Console.WriteLine("Total: " + puntaje[turnos]);
                    }


                    if (puntaje[turnos] < 21) // si el total es menor a 21 se le sigue preguntando
                    {
                        if (puntaje[turnos] > max) // si el total que ya viene es mayor que el maximo entonces el maximo se convierte en el total 
                        {
                            max = puntaje[turnos];  //el puntaje que viene en el turno del indici del arreglo                                               
                        }

                        Console.Write("| ¿Desea continuar con otra carta? | (s/n): ");
                        respuesta = Console.ReadLine();

                        while (respuesta != "s" && respuesta != "n") 
                        {
                            Console.WriteLine("Respuesta inconrecta, vuelva a ingresar (s/n)");
                            respuesta = Console.ReadLine();
                        }
                    }
                    else if (puntaje[turnos] == 21) //si es iguala 21 el maximo se vuelve el total y se pone "no sigue" para que no siga en el while y se pone el nombre del jugador
                    {
                        max = puntaje[turnos];                                              
                        Console.WriteLine("Obtuvo 21 :D");
                        empate++; // se suma el contador de empate por si ocurre un posible empate entre los jugadores 
                        break;                       
                    }
                    else //si es mayor que 21 se inicializa la variable max (por que solo es hasta 21) y se pone break para que no entre otra vez al while
                    {
                        max = 0;                      
                        Console.WriteLine("Obtuvo mas que 21 :(");
                        nadieGana++; //se acumula por si todos sacan mas de 21 
                        break;
                    }
                }

                turnos++; // se suman los turnos llevados 
                respuesta = "s"; //la respuesta se debe reiniciar para el nuevo jugador               
                primerTurno = true; //se vuelve a poner el bool para que vuelva a entrar en el if de las dos primeras cartas               
            }

            for (int i = 0; i < jugadores; i++) //organizar los datos de menor a mayor se hace el proceso tanto veces como jugadores halla
            {
                for (int k = 0; k < jugadores-1; k++) //organizar los datos "bubble sort" 
                {
                    if (puntaje[k] > puntaje[k + 1]) //si el puntaje de la casilla o es mayor a el de la casilla 1 enonces entra a el if 
                    {
                        int temp = puntaje[k]; //se pone un temporal para poner el puntaje k + 1 con el dato correcto
                        puntaje[k] = puntaje[k+1];
                        puntaje[k + 1] = temp;            

                        string temp2 = nombres[k];
                        nombres[k] = nombres[k + 1];
                        nombres[k + 1] = temp2;
                    }                  
                }
                Console.WriteLine("Nombre: " + nombres[i] + " | " + "puntaje: " + puntaje[i] );

            }

            for (int i = 0; i < jugadores ; i++)
            {
                diferencia = Math.Abs(puntaje[turnos] - 21); //aqui resto 21 al puntaje total de cada turno para obtener el valor mas pequeno 
                

                if (diferencia < min) //si la resta es menor al minimo, con este se calcula la estatura mas cercana al promedio
                {
                    min = diferencia; //el minimos se vuelve la resta entre el puntaje y 21
                    eLMasCercanoA21 = puntaje[turnos]; //el mas cercano es 
                    elNombreCercano = nombres[turnos];

                }                
            }
            Console.WriteLine("El ganador es: " + elNombreCercano);


            if (nadieGana == jugadores) // esto quiere decir que si todos sacaron mas de 21 nadie gana (si el contador de los que sacaron > 21 es igual al numero de jugadores quiere decir que nadie gana) 
            {
                Console.WriteLine("Nadie gano >:(");
            }
            else if (empate >= 2) // si el acumulador de empate es igual o mayor a dos existieron dos o mas personas ganadoras 
            {
                Console.WriteLine("Hubo empate :o ");
            }

            
        }
    }
}
