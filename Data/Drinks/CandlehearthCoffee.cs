﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public class CandlehearthCoffee : Drink, IOrderItem
    {
        /// <summary>
        /// The event handler to be used when a specific property changes in the object.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;
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
                else
                {
                    SpecialInstructions.Remove("Add ice");
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
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
                else
                {
                    SpecialInstructions.Remove("Leave room for cream");
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
            }
        }

        /// <summary>
        /// The size of the coffee
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
        /// The price of the coffee depending on its size
        /// </summary>
        public override double Price
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
        public override uint Calories
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
        /// Holds the description of the Candlehearth Coffee.
        /// </summary>
        public override string Description
        {
            get
            {
                return "Fair trade, fresh ground dark roast coffee.";
            }
        }

        /// <summary>
        /// Returns the name of the coffee
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
