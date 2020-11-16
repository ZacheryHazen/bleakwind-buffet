using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

/*
 * Author: Zach Hazen
 * Purpose: Class used to represent the Aretino Apple Juice drink via various fields and methods.
 */

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class used to represent the Aretino Apple Juice drink via various fields and methods.
    /// </summary>
    public class AretinoAppleJuice : Drink, IOrderItem
    {
        /// <summary>
        /// The event handler to be used when a specific property changes in the object.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;
        // Declaring backing variables
        private bool ice = false;

        private Size size = Size.Small;

        /// <summary>
        /// If the apple juice is served with ice
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
                else
                {
                    SpecialInstructions.Remove("Add ice");
                }
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
            }
        }

        /// <summary>
        /// The size of the apple juice
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
        /// The price of the apple juice depending on its size
        /// </summary>
        public override double Price
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
        
        /// <summary>
        /// The calories of the apple juice depending on its size
        /// </summary>
        public override uint Calories
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
        /// <summary>
        /// A list of special instructions for preparing the apple juice.
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
        /// Holds the description of the Aretino Apple Juice.
        /// </summary>
        public override string Description
        {
            get
            {
                return "Fresh squeezed apple juice.";
            }
        }

        /// <summary>
        /// Returns the name of the Aretino Apple Juice.
        /// </summary>
        /// <returns>A string containing a description of the apple juice.</returns>
        public override string ToString()
        {
            return (size + " Aretino Apple Juice");
        }
    }
}
