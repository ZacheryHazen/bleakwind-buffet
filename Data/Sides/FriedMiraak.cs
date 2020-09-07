﻿using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

/*
 * Author: Zach Hazen
 * Purpose: Class used to represent the Fried Miraak side via various fields and methods.
 */

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class used to represent the Fried Miraak side via various fields and methods.
    /// </summary>
    public class FriedMiraak
    {
        // Declaring the private backing variable
        private Size size = Size.Small;

        /// <summary>
        /// The size of the Fried Miraak
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
        /// The price of the Fried Miraak depending on the size
        /// </summary>
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
        /// <summary>
        /// The calories of the Fried Miraak depending on the size
        /// </summary>
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

        /// <summary>
        /// A list of special instructions to be used when preparing the Fried Miraak
        /// </summary>
        public List<string> SpecialInstructions { get; } = new List<string>();

        /// <summary>
        /// Returns a description of the Fried Miraak
        /// </summary>
        /// <returns>A string containing the description of the Fried Miraak</returns>
        public override string ToString()
        {
            return (size + " Fried Miraak");
        }
    }
}
