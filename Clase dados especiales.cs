
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_dados
{
    class Program
    {
        static void Main(string[] args) 
        {
            Random aleatorio = new Random();
            int puntos = 0;
            int vida = 3;
            int dadoA = 0;
            int dadoB = 0;
            int dadoC = 0;
            int pierdeVida = 0;
            int acumulavida = 0;                      
            string continuar = "s";
            string seguir = "s";
            bool especiales = true;
            bool controlVidas = false;
            

            Console.WriteLine("| Bienvenido al juego | ");
            
            while (seguir == "s" && vida > 0 && puntos < 100)
            {

                if (especiales) // esta condicion es para validar la pregunta si usa los dados especiales
                {
                    Console.WriteLine("| Desea gastar los dados especiales | (s/n)");
                    continuar = Console.ReadLine();
                }

                if (continuar == "s" && especiales == true) // esta condicion es para validar los dados especiales
                {
                    dadoB = aleatorio.Next(1, 13);
                    Console.Write("Dado B: " + dadoB);

                    dadoC = aleatorio.Next(1, 13);
                    Console.Write(" | Dado C: " + dadoC);

                    puntos = dadoB + dadoC;

                    if (dadoB == 1) pierdeVida++; //cuando dado es igual a uno se acumula una pierdevida
                    if (dadoC == 1) pierdeVida++; //cuando dado es igual a uno se acumula una pierdevida  

                    if (pierdeVida >= 2)  //cuando acumular dos veces una pierdevida entra al if 
                    {
                        vida--;
                        puntos = puntos - 10;
                        Console.WriteLine("Ha perdido una vida, su total de vidas es: " + vida);
                        Console.WriteLine("Puntos acumulados: " + puntos);
                        pierdeVida = 0;
                    }
                   
                    if (dadoC == 6 && dadoB == 6)
                    {
                        vida++;
                        if (vida >= 3) vida = 3;
                        Console.WriteLine("Obtuvo dos seis consecutivos, recupera una vida: " + vida);
                        acumulavida = 0; // se inicializa la vida en cero para que se vuelve a contar cada vez que saque dos seis seguidos
                        dadoC = 0;
                        dadoB = 0; //con esto evitamos que no se meta en la condicion de abajo 
                        controlVidas = false;
                    }

                    if (dadoC == 6 || dadoB == 6)
                    {
                        acumulavida++;
                        controlVidas = true;
                    }

                    especiales = false;
                }
                else
                {
                    dadoA = aleatorio.Next(1, 7);
                    Console.WriteLine(" | Dado A: " + dadoA);
                    puntos += dadoA;
                    Console.WriteLine("Puntos: " + puntos);

                    if (dadoA == 1) pierdeVida++; // si en el dado A saca un uno pierde una vida

                    if (dadoA == 6) // si en el dado A saca seis entra al if ( esta condicion la hacemos por que queremos que sea consecutivo) 
                    {
                        if (controlVidas) // si seis viene verdadero de alguno de los dados de las doce caras entonces
                        {
                            acumulavida++; //acumula una vida 
                            controlVidas = false; // se inicializa la bandera
                        }
                        else // si algunos de los dados no viene con seis pero de todas formas el dado A es igual a 6 se acumula una vida y se pone en verdadero el bool
                        {
                            acumulavida++;
                            controlVidas = true;
                        }
                    }
                    else // si el dado A NO SACA SEIS es el bool se vuelve falso esto es necesario por si algunos de los dados vienen en positivo. 
                    {
                        controlVidas = false;
                        acumulavida = 0;
                    }

                    if (pierdeVida >= 2)
                    {
                        vida--;
                        puntos = puntos - 10;
                        Console.WriteLine("Ha perdido una vida, su total de vidas es: " + vida);
                        Console.WriteLine("Puntos acumulados: " + puntos);
                        pierdeVida = 0;
                    }
                     
                    if (acumulavida >=2)
                    {
                        Console.WriteLine("Obtuvo dos seis consecutivos, recupera una vida: " + vida);
                        vida++;
                        if (vida >= 3) vida = 3; // la vida no puede ser mayor a tres debe ser igual a tres
                        acumulavida = 0;
                        controlVidas = false;
                    }
                }
                Console.WriteLine(" | Desea continuar el juego: ");
                seguir = Console.ReadLine();
                if (vida == 0) Console.WriteLine("se le acabaron las vidas");
                if (vida > 100) Console.WriteLine("Gano el juego con mas de 100 puntos");
            }
                
        }
    }
}
