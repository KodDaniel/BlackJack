using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UtilitiesLib;

namespace GameCardLib.Classes

{
    public class Deck : IEnumerable
    {
        private readonly List<Card> _cards;
        public int NumberOfDecks { get; private set; } = 1; 
        public static int CardCount { get; private set; }
        public Card this[int index] => _cards[index];

        public Deck() => _cards = new List<Card>();

        public Deck(int numberOfDecks)
        {
            _cards = new List<Card>();
            NumberOfDecks = numberOfDecks;
        }


        public void InitializeDeck()
        {
            FillDeckWithCards();
            Shuffle();
        }

        public void FillDeckWithCards()
        {
            while (NumberOfDecks > 0)
            {
                for (int face = 1; face < 14; face++)
                {
                    for (int color = 0; color < 4; color++)
                    {
                        _cards.Add(new Card((EnumSuite)color, (EnumFace)face));
                    }

                
                }
                NumberOfDecks--;
            }
          
            // Hitta ett snyggare sätt att hålla kolla på counten utan att upprepa massa kod i olika metoder
            CardCount = _cards.Count;

        }

        private void Shuffle() => _cards.Shuffle();

        public IEnumerator GetEnumerator() => _cards.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();




    }
}