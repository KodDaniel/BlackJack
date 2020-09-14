using System;
using System.Reflection.Metadata;
using GameCardLib.Interfaces;

namespace GameCardLib.Classes

{ 

    public class Card
    {
        public EnumSuite Suite { get; }
        public EnumFace EnumFace { get;}
        public string SuiteString { get;}
        public int Value { get; set; } 
        public string ValueString { get; set; } 
        public bool FaceUp { get; set; }

        public Card(EnumSuite suite, EnumFace enumFace)
        {
            Suite = suite;
            SuiteString = suite.ToString();
            EnumFace = enumFace;
            Value = (int)EnumFace;
            ValueString = Value.ToString();
        }

        public override string ToString() =>
            $"(Suite: {Suite}, Face: {EnumFace}, Value: {Value})";


    }
}
