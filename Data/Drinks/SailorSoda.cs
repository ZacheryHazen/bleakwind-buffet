using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /*
    * Author: Zach Hazen
    * Class name: SailorSoda.cs
    * Purpose: Class used to represent the Sailor Soda drink via various fields and methods.
    */
    public class SailorSoda
    {
        private bool ice = true;

        private Size size = Size.Small;

        private Enums.SodaFlavor flavor = SodaFlavor.Cherry;
        public bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold ice");
                }
                ice = value;
            }
        }
        public Size Size {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }
        public SodaFlavor Flavor {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
            }
        }
        public double Price {
            get
            {
                if (size == Size.Small)
                {
                    return 1.42;
                }
                else if (size == Size.Medium)
                {
                    return 1.74;
                }
                else
                {
                    return 2.07;
                }
            }
        }
        public uint Calories {
            get
            {
                if (size == Size.Small)
                {
                    return 117;
                }
                else if (size == Size.Medium)
                {
                    return 153;
                }
                else
                {
                    return 205;
                }
            }
        }
        public List<string> SpecialInstructions { get; } = new List<string>();

        public override string ToString()
        {
            return (size + " " + flavor + " Sailor's Soda");
        }
    }
}
