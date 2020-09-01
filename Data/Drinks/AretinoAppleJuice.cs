using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /*
    * Author: Zach Hazen
    * Class name: AretinoAppleJuice.cs
    * Purpose: Class used to represent the Aretino Apple Juice drink via various fields and methods.
    */
    class AretinoAppleJuice
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
                    return 0.62;
                }
                else if (size == Size.Medium)
                {
                    return 0.87;
                }
                else
                {
                    return 1.01;
                }
            }
        }
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 44;
                }
                else if (size == Size.Medium)
                {
                    return 88;
                }
                else
                {
                    return 132;
                }
            }
        }
        public List<string> SpecialInstructions { get; } = new List<string>();

        public override string ToString()
        {
            return (size + " Aretino Apple Juice");
        }
    }
}
