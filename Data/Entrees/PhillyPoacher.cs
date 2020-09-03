using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /*
    * Author: Zach Hazen
    * Class name: PhillyPoacher.cs
    * Purpose: Class used to represent the Philly Poacher entree via various fields and methods.
    */
    public class PhillyPoacher
    {
        private bool sirloin = true;

        private bool onion = true;

        private bool roll = true;

        public bool Sirloin
        {
            get
            {
                return sirloin;
            }

            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold sirloin");
                }
                sirloin = value;
            }
        }

        public bool Onion
        {
            get
            {
                return onion;
            }

            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold onions");
                }
                onion = value;
            }
        }

        public bool Roll
        {
            get
            {
                return roll;
            }

            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold roll");
                }
                roll = value;
            }
        }

        public double Price { get; } = 7.23;

        public uint Calories { get; } = 784;

        public List<string> SpecialInstructions { get; } = new List<string>();

        public override string ToString()
        {
            return ("Philly Poacher");
        }
    }
}
