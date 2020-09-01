using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /*
    * Author: Zach Hazen
    * Class name: AretinoAppleJuice.cs
    * Purpose: Class used to represent the Warrior Waterdrink via various fields and methods.
    */
    class WarriorWater
    {
        private bool ice = true;

        private bool lemon = false;

        private Size size = Size.Small;

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
        public bool Lemon
        {
            get
            {
                return lemon;
            }
            set
            {
                if (value == true)
                {
                    SpecialInstructions.Add("Add lemon");
                }
                lemon = value;
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
                    return 0.00;
                }
                else if (size == Size.Medium)
                {
                    return 0.00;
                }
                else
                {
                    return 0.00;
                }
            }
        }
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 0;
                }
                else if (size == Size.Medium)
                {
                    return 0;
                }
                else
                {
                    return 0;
                }
            }
        }
        public List<string> SpecialInstructions { get; } = new List<string>();

        public override string ToString()
        {
            return (size + " Warrior Water");
        }
    }
}
