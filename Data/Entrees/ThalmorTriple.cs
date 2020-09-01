using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /*
    * Author: Zach Hazen
    * Class name: ThalmorTriple.cs
    * Purpose: Class used to represent the Thalmor Triple entree via various fields and methods.
    */
    class ThalmorTriple
    {

        public double Price { get; }

        public uint Calories { get; }

        public List<string> SpecialInstructions { get; }

        public override string ToString()
        {
            return ("Thalmor Triple");
        }
    }
}
