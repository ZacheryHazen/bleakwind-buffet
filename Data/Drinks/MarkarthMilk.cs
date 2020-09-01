using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /*
    * Author: Zach Hazen
    * Class name: MarkarthMilk.cs
    * Purpose: Class used to represent the Markarth Milk drink via various fields and methods.
    */
    class MarkarthMilk
    {
        private bool ice = false;

        private Size size = Size.Small;

        public bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                if (value == true)
                {
                    SpecialInstructions.Add("Add ice");
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
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return 1.05;
                }
                else if (size == Size.Medium)
                {
                    return 1.11;
                }
                else
                {
                    return 1.22;
                }
            }
        }
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 56;
                }
                else if (size == Size.Medium)
                {
                    return 72;
                }
                else
                {
                    return 93;
                }
            }
        }
        public List<string> SpecialInstructions { get; } = new List<string>();

        public override string ToString()
        {
            return (size + " Markarth Milk");
        }
    }
}
