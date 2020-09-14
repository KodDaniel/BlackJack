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


            Deck n = new Deck(2);
            n.FillDeckWithCards();
            foreach (Card card in n)
            {
                Console.WriteLine(card);
                
            }

            Console.WriteLine(Deck.CardCount);
            Console.ReadLine();







        }


    }
}
 
