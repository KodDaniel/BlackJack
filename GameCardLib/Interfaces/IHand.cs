using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using GameCardLib.Classes;

namespace GameCardLib.Interfaces
{
    public interface IHand
    {
        public bool LastCard { get; set; }
        public int NumberOfCards { get; set; }
        public int Score { get; set; }
        void AddCard(Card card);
        void Clear();
        IEnumerator GetEnumerator();
    }
}
