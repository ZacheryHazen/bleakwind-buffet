﻿using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

/*
 * Author: Zach Hazen
 * Purpose: Class used to represent the Markarth Milk drink via various fields and methods.
 */

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class used to represent the Markarth Milk drink via various fields and methods.
    /// </summary>
    public class MarkarthMilk
    {
        // Declaring private backing variables
        private bool ice = false;

        private Size size = Size.Small;

        /// <summary>
        /// If ice should be added to the milk
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
        /// The size of the milk
        /// </summary>
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
        /// <summary>
        /// The price of the milk based on its size
        /// </summary>
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
        /// <summary>
        /// The calories of the milk based on its size
        /// </summary>
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
        /// <summary>
        /// A list of special instructions for preparing the milk
        /// </summary>
        public List<string> SpecialInstructions { get; } = new List<string>();

        /// <summary>
        /// Returns a description of the milk to be served.
        /// </summary>
        /// <returns>Returns a string containing a description of the milk</returns>
        public override string ToString()
        {
            return (size + " Markarth Milk");
        }
    }
}
