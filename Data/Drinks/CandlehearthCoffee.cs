using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

/*
 * Author: Zach Hazen
 * Purpose: Class used to represent the Candlehearth Coffee drink via various fields and methods.
 */

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class used to represent the Candlehearth Coffee drink via various fields and methods.
    /// </summary>
    public class CandlehearthCoffee
    {
        // Declaring backing variables
        private bool ice = false;

        private bool decaf = false;

        private bool roomForCream = false;

        private Size size = Size.Small;

        /// <summary>
        /// IF the coffee is iced
        /// </summary>
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

        /// <summary>
        /// If the coffee is decaf
        /// </summary>
        public bool Decaf
        {
            get
            {
                return decaf;
            }
            set
            {
                decaf = value;
            }
        }

        /// <summary>
        /// If there should be room left for cream so the coffee can later be served with cream
        /// </summary>
        public bool RoomForCream
        {
            get
            {
                return roomForCream;
            }
            set
            {
                roomForCream = value;
                if (value == true)
                {
                    SpecialInstructions.Add("Leave room for cream");
                }
            }
        }

        /// <summary>
        /// The size of the coffee
        /// </summary>
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

        /// <summary>
        /// The price of the coffee depending on its size
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return 0.75;
                }
                else if (size == Size.Medium)
                {
                    return 1.25;
                }
                else
                {
                    return 1.75;
                }
            }
        }
        /// <summary>
        /// The calories of the coffee depending on its size
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 7;
                }
                else if (size == Size.Medium)
                {
                    return 10;
                }
                else
                {
                    return 20;
                }
            }
        }

        /// <summary>
        /// A list of special instructions for preparing the coffee
        /// </summary>
        public List<string> SpecialInstructions { get; } = new List<string>();

        /// <summary>
        /// Returns a description of the coffee
        /// </summary>
        /// <returns>A string containing a description of the coffee</returns>
        public override string ToString()
        {
            if (decaf)
            {
                return (size + " Decaf Candlehearth Coffee");
            }
            else
            {
                return (size + " Candlehearth Coffee");
            }
        }
    }
}
