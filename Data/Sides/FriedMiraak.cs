using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /*
    * Author: Zach Hazen
    * Class name: FriedMiraak.cs
    * Purpose: Class used to represent the Fried Miraak side via various fields and methods.
    */
    public class FriedMiraak
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
                    return 1.78;
                }
                else if (size == Size.Medium)
                {
                    return 2.01;
                }
                else
                {
                    return 2.88;
                }
            }
        }
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 151;
                }
                else if (size == Size.Medium)
                {
                    return 236;
                }
                else
                {
                    return 306;
                }
            }
        }

        public List<string> SpecialInstructions { get; } = new List<string>();

        public override string ToString()
        {
            return (size + " Fried Miraak");
        }
    }
}
