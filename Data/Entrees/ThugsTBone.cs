using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /*
    * Author: Zach Hazen
    * Class name: ThugsTBone.cs
    * Purpose: Class used to represent the Briarheart Burger entree via various fields and methods.
    */
    class ThugsTBone
    {
        public double Price { get; }

        public uint Calories { get; }

        public List<string> SpecialInstructions { get; }

        public override string ToString()
        {
            return ("Thugs T-Bone");
        }
    }
}
