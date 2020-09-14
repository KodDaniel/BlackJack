using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using GameCardLib.Interfaces;

namespace GameCardLib.Classes
{ 
    public class Hand:IEnumerable
    {
        private readonly List<Card> _cards;
        public bool LastCard { get; set; }
        public int NumberOfCards { get; set; } 
        public int Score { get; set; }
        // Om index faller utanför listan, undvik exception och returna null istället
        public Card this[int index] => (index >= _cards.Count || index < 0) ? null : _cards[index];

        public Hand() => _cards = new List<Card>();

        public void AddCard(Card card) => _cards.Add(card);
        public void Clear() => _cards.Clear();
        

        public IEnumerator GetEnumerator() => _cards.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator () => GetEnumerator();

        public override string ToString() =>
            $"LastCard:{LastCard}, NumberOfCards: {NumberOfCards}, Score:{Score}";
        
    }
}

