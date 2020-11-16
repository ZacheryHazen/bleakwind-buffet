using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

/*
 * Author: Zach Hazen
 * Purpose: Class used to represent the Dragonborn Waffle Fries side via various fields and methods.
 */

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class used to represent the Dragonborn Waffle Fries side via various fields and methods.
    /// </summary>
    public class DragonbornWaffleFries : Side, IOrderItem
    {
        /// <summary>
        /// The event handler to be used when a specific property changes in the object.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;
        // Declaring the private backing variable
        private Size size = Size.Small;
        
        /// <summary>
        /// The size of the Dragonborn Waffle Fries
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        /// <summary>
        /// The price of the Dragonborn Waffle Fries depending on the size
        /// </summary>
        public override double Price
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

        /// <summary>
        /// The calories of the Dragonborn Waffle Fries depending on the size
        /// </summary>
        public override uint Calories
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

        /// <summary>
        /// A list of special instructions to be used when preparing the Dragonborn Waffle Fries
        /// </summary>
        public override List<string> SpecialInstructions { get; } = new List<string>();

        /// <summary>
        /// Simply holds the value of the ToString() method in a string.
        /// </summary>
        public string Name
        {
            get
            {
                return ToString();
            }
        }

        /// <summary>
        /// Holds the description of the Dragonborn Waffle Fries.
        /// </summary>
        public override string Description
        {
            get
            {
                return "Crispy fried potato waffle fries.";
            }
        }

        /// <summary>
        /// Returns the name of the Dragornborn Waffle Fries
        /// </summary>
        /// <returns>A string containing the description of the Dragonborn Waffle Fries</returns>
        public override string ToString()
        {
            return (size + " Dragonborn Waffle Fries");
        }
    }
}
