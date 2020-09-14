using System;
using System.Collections.Generic;
using System.Text;
using GameCardLib.Classes;

namespace GameCardLib.Interfaces
{
    public interface ICard
    {
        public EnumSuite Suite { get; }
        public EnumFace EnumFace { get; }
        public string SuiteString { get; }
        public int Value { get; }
        public string ValueString { get; }
        public bool FaceUp { get; set; }
    }
}
