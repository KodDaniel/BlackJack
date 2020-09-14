using System;
using System.Collections.Generic;
using System.Text;
using GameCardLib.Classes;

namespace GameCardLib.Interfaces
{
    interface IPlayer
    {
        public int PlayerID { get; }
        public string Name { get; }
        public IHand Hand { get; set; }
        public bool IsFinisihed { get; set; }
        public bool IsThick { get; set; }
        
    }
}
