﻿
using System;
using System.Diagnostics;

//juego de blackjack 21


// declaracion de variables  y paquetes a utilizar
int totalJugador = 0;
int totalDealer = 0;
int num = 0;
int coins = 0;
string mensaje = "";
string controlOtraCarta = "";
string switchControl = "menu";
System.Random random = new System.Random();



// para tener una continuidad como de un juego utilizo un ciclo wile para que se repita el juego una ve4s finalizADO
while (true)
{

    Console.WriteLine("Bienvenido al Casino");
    Console.WriteLine("Cuantos Creditos deseas? \n" + "recuerda que necesitas 1 por ronda");
    coins = int.Parse(Console.ReadLine());


    for (int i = 0; i < coins; i++)
    {



        //reinicio las variables cada ves que empiesa el juego
        totalJugador = 0;
        totalDealer = 0;


        // creo un swich para que dividir las instanias del juego si estas en el menu o en juego 
        switch (switchControl)
        {
            case "menu":

                Console.WriteLine("escribe : " + "A para facil , B para medio o C para dificil");
                switchControl = Console.ReadLine();
                i = i - 1;
                break;

            case "A":

                do
                {


                    num = random.Next(1, 12);
                    totalJugador = totalJugador + num;
                    Console.WriteLine($"{coins}");
                    Console.WriteLine("Toma tu carta , Jugador");
                    Console.WriteLine($"te salio el : {num} ");
                    Console.WriteLine("¿Queres otra carta?");
                    Console.WriteLine($"Tienes : {totalJugador}");
                    controlOtraCarta = Console.ReadLine();

                }
                // como persisto en el do wile
                while (controlOtraCarta == "si" || controlOtraCarta == "SI" || controlOtraCarta == "Si" || controlOtraCarta == "yes");


                // indico un numero random con 2 parametros para el dealer
                totalDealer = random.Next(12, 28);

                Console.WriteLine($"el Dealer tiene {totalDealer} ! ");


                // declaro las reglas del juego que deben cumplirse

                if (totalJugador > totalDealer && totalJugador <= 21)
                {
                    mensaje = "Le Ganaste a la Casa Felicidades";
                    //saco al jugador al menu
                    switchControl = "menu";
                }
                else if (totalJugador <= totalDealer)
                {
                    mensaje = "Perdiste. la Casa Gana";
                    //saco al jugador al menu
                    switchControl = "menu";
                }
                else if (totalJugador > 22)
                {
                    mensaje = "Perdiste, Te pasaste. la Casa Gana";
                }
                else
                {
                    mensaje = "condicion no valida";
                }

                Console.WriteLine(mensaje);
                break;

         

            case "B":
                do
                {


                    num = random.Next(1, 12);
                    totalJugador = totalJugador + num;
                    Console.WriteLine("Toma tu carta , Jugador");
                    Console.WriteLine($"te salio el : {num} ");
                    Console.WriteLine("¿Queres otra carta?");
                    Console.WriteLine($"Tienes : {totalJugador}");
                    controlOtraCarta = Console.ReadLine();

                }
                // como persisto en el do wile
                while (controlOtraCarta == "si" || controlOtraCarta == "SI" || controlOtraCarta == "Si" || controlOtraCarta == "yes");


                // indico un numero random con 2 parametros para el dealer
                totalDealer = random.Next(15, 23);

                Console.WriteLine($"el dealer tiene {totalDealer} ! ");


                // declaro las reglas del juego que deben cumplirse

                if (totalJugador > totalDealer && totalJugador <= 21)
                {
                    mensaje = "Ganaste a la Casa Felicidades";
                    //saco al jugador al menu
                    switchControl = "menu";
                }
                else if (totalJugador <= totalDealer)
                {
                    mensaje = "Perdiste. la Casa Gana";
                    //saco al jugador al menu
                    switchControl = "menu";
                }
                else if (totalJugador > 22)
                {
                    mensaje = "Perdiste Te pasaste. la Casa Gana";
                }
                else
                {
                    mensaje = "condicion no valida";
                }

                Console.WriteLine(mensaje);
                break;

            case "C":
                do
                {


                    num = random.Next(1, 12);
                    totalJugador = totalJugador + num;
                    Console.WriteLine("Toma tu carta , Jugador");
                    Console.WriteLine($"te salio el : {num} ");
                    Console.WriteLine("¿Queres otra carta?");
                    Console.WriteLine($"Tienes : {totalJugador}");
                    controlOtraCarta = Console.ReadLine();

                }
                // como persisto en el do wile
                while (controlOtraCarta == "si" || controlOtraCarta == "SI" || controlOtraCarta == "Si" || controlOtraCarta == "yes");


                // indico un numero random con 2 parametros para el dealer
                totalDealer = random.Next(18, 21);

                Console.WriteLine($"el dealer tiene {totalDealer} ! ");


                // declaro las reglas del juego que deben cumplirse

                if (totalJugador > totalDealer && totalJugador <= 21)
                {
                    mensaje = "Ganaste a la Casa Felicidades";
                    //saco al jugador al menu
                    switchControl = "menu";
                }
                else if (totalJugador <= totalDealer)
                {
                    mensaje = "Perdiste. la Casa Gana";
                    //saco al jugador al menu
                    switchControl = "menu";
                }
                else if (totalJugador > 22)
                {
                    mensaje = "Perdiste Te pasaste. la Casa Gana";
                }
                else
                {
                    mensaje = "condicion no valida";
                }

                Console.WriteLine(mensaje);
                break;





            default:
                
                Console.WriteLine("Este lUGAR NO ES PERMITIDO EN MI CASINO");
               
                break;





        }
        





    }

}