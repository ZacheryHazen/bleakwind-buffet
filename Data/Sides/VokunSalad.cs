using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

/*
 * Author: Zach Hazen
 * Purpose: Class used to represent the Vokun Salad side via various fields and methods.
 */

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class used to represent the Vokar Salad side via various fields and methods.
    /// </summary>
    public class VokunSalad
    {
        // Declaring the private backing variable
        private Size size = Size.Small;

        /// <summary>
        /// The size of the Vokun Salad
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
        /// The price of the Vokun Salad depending on the size
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return 0.93;
                }
                else if (size == Size.Medium)
                {
                    return 1.28;
                }
                else
                {
                    return 1.82;
                }
            }
        }
        /// <summary>
        /// The calories of the Vokun Salad depending on the size
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 41;
                }
                else if (size == Size.Medium)
                {
                    return 52;
                }
                else
                {
                    return 73;
                }
            }
        }

        /// <summary>
        /// A list of special instructions to be used when preparing the Vokun Salad
        /// </summary>
        public List<string> SpecialInstructions { get; } = new List<string>();

        /// <summary>
        /// Returns a description of the Vokun Salad
        /// </summary>
        /// <returns>A string containing the description of the Vokun Salad</returns>
        public override string ToString()
        {
            return (size + " Vokun Salad");
        }
    }
}
