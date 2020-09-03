using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /*
    * Author: Zach Hazen
    * Class name: DragonbornWaffleFries.cs
    * Purpose: Class used to represent the Dragonborn Waffle Fries side via various fields and methods.
    */
    public class DragonbornWaffleFries
    {
        private Size size = Size.Small;
        
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return 0.42;
                }
                else if (size == Size.Medium)
                {
                    return 0.76;
                }
                else
                {
                    return 0.96;
                }
            }
        }
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 77;
                }
                else if (size == Size.Medium)
                {
                    return 89;
                }
                else
                {
                    return 100;
                }
            }
        }

        public List<string> SpecialInstructions { get; } = new List<string>();

        public override string ToString()
        {
            return (size + " Dragonborn Waffle Fries");
        }
    }
}
