using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

/*
 * Author: Zach Hazen
 * Purpose: Class used to represent the Mad Otar Grits side via various fields and methods.
 */

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class used to represent the Mad Otar Grits side via various fields and methods.
    /// </summary>
    public class MadOtarGrits : Side, IOrderItem
    {
        // Declaring the private backing variable
        private Size size = Size.Small;

        /// <summary>
        /// The size of the Mad Otar Grits
        /// </summary>
        public override Size Size
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
        /// The price of the Mad Otar Grits depending on the size
        /// </summary>
        public override double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return 1.22;
                }
                else if (size == Size.Medium)
                {
                    return 1.58;
                }
                else
                {
                    return 1.93;
                }
            }
        }
        /// <summary>
        /// The calories of the Mad Otar Grits depending on the size
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 105;
                }
                else if (size == Size.Medium)
                {
                    return 142;
                }
                else
                {
                    return 179;
                }
            }
        }

        /// <summary>
        /// A list of special instructions to be used when preparing the Mad Otar Grits
        /// </summary>
        public override List<string> SpecialInstructions { get; } = new List<string>();

        /// <summary>
        /// Returns a description of the Mad Otar Grits
        /// </summary>
        /// <returns>A string containing the description of the Mad Otar Grits</returns>
        public override string ToString()
        {
            return (size + " Mad Otar Grits");
        }
    }
}
