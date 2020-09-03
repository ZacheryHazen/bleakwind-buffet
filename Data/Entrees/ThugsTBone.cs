using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /*
    * Author: Zach Hazen
    * Class name: ThugsTBone.cs
    * Purpose: Class used to represent the Thugs T-Bone entree via various fields and methods.
    */
    public class ThugsTBone
    {
        public double Price { get; } = 6.44;

        public uint Calories { get; } = 982;

        public List<string> SpecialInstructions { get; } = new List<string>();

        public override string ToString()
        {
            return ("Thugs T-Bone");
        }
    }
}
