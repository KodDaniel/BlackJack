using System;
using System.Collections.Generic;
using System.Text;

namespace GameCardLib.Classes

{
    public class Player
    { 
    public int PlayerID { get; }
    public string Name { get; }
    public Hand Hand { get; private set; }
    public bool IsFinisihed { get; private set; }
    public bool IsThick => (Hand.Score > 21);

    public Player(int playerId, string name)
    {
        PlayerID = playerId;
        Name = name;
        Hand = new Hand();
    }


    //// Privat stödmetod och därför inte med i interfacet 
    //private void Reset()
    //{
       
    //}

    public override string ToString() =>
        $"PlayerID is: {PlayerID} and player name is {Name}";

    }
}
