using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

/*
 * Author: Zach Hazen
 * Purpose: Class used to represent the Warrior Water drink via various fields and methods.
 */

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class used to represent the Warrior Water drink via various fields and methods.
    /// </summary>
    public class WarriorWater : Drink, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        // Declaring private backing variables
        private bool ice = true;

        private bool lemon = false;

        private Size size = Size.Small;

        /// <summary>
        /// If ice is to be served with the water
        /// </summary>
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
            }
        }
        /// <summary>
        /// If a lemon should be served with the water
        /// </summary>
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
            }
        }
        /// <summary>
        /// The size of the water
        /// </summary>
        public override Size Size {
            get
            {
                return size;
            } 
            set 
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
            } 
        }
        /// <summary>
        /// The price of the water depending on its size
        /// </summary>
        public override double Price
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
        /// <summary>
        /// The calories of the water
        /// </summary>
        public override uint Calories
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
        /// <summary>
        /// A list of special instructions for preparing the water
        /// </summary>
        public override List<string> SpecialInstructions { get; } = new List<string>();

        /// <summary>
        /// Returns a description of the water
        /// </summary>
        /// <returns>A string containing a description of the water</returns>
        public override string ToString()
        {
            return (size + " Warrior Water");
        }
    }
}
