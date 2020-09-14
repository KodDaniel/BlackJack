using System;
using System.Collections.Generic;
using GameCardLib;
using GameCardLib.Classes;
using GameCardLib.Interfaces;
using UtilitiesLib;

namespace UserInterface
{
    public enum Face { Ace = 1, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King }

    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Att fixa: Du vill undvika instansmedlemmar på bekostnad av statiska medlemmar
            // TODO: Att fixa: Metoder ska vara så korta som möjligt
            //TODO: Att fixa: Kopiera aldrig kod utan deta på koden i metoder 
            // TODO: Att fixa: Include  at  least  one  interface  to  make  rules  for  subclasses  in  an inheritance  hierarchy
            //TODO: Att fixa: Kommentera syftet med varje metod


            SimulateGamePlay.StartGame();
            Console.ReadLine();


        }

        public static class SimulateGamePlay
        {
            private static Deck deck = new Deck();
            private static Player player = new Player(1,"Daniel Johansson");

            public static void StartGame()
            {
                deck.InitializeDeck();
                foreach (Card o in deck)
                {
                    Console.WriteLine(o);
                }
            }

        }


    }
}
 
