using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

/*
 * Author: Zach Hazen
 * Purpose: Class used to represent the Philly Poacher entree via various fields and methods.
 */

namespace BleakwindBuffet.Data.Entrees
{

    /// <summary>
    /// Class used to represent the Philly Poacher entree via various fields and methods.
    /// </summary>
    public class PhillyPoacher : Entree, IOrderItem, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        // Declaring the private backing variables
        private bool sirloin = true;

        private bool onion = true;

        private bool roll = true;

        /// <summary>
        /// If the Philly Poacher is to be served with sirloin
        /// </summary>
        public bool Sirloin
        {
            get
            {
                return sirloin;
            }

            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold sirloin");
                }
                sirloin = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sirloin"));
            }
        }

        /// <summary>
        /// If the Philly Poacher is to be served with onions
        /// </summary>
        public bool Onion
        {
            get
            {
                return onion;
            }

            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold onions");
                }
                onion = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Onion"));
            }
        }

        /// <summary>
        /// If the Philly Poacher is to be served with a roll
        /// </summary>
        public bool Roll
        {
            get
            {
                return roll;
            }

            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold roll");
                }
                roll = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Roll"));
            }
        }

        /// <summary>
        /// The price of the Philly Poacher
        /// </summary>
        public override double Price { get; } = 7.23;

        /// <summary>
        /// The calories of the Philly Poacher
        /// </summary>
        public override uint Calories { get; } = 784;

        /// <summary>
        /// A list of special instructions to be used when preparing the Philly Poacher
        /// </summary>
        public override List<string> SpecialInstructions { get; } = new List<string>();

        /// <summary>
        /// Returns a description of the Philly Poacher
        /// </summary>
        /// <returns>A string containing the name of the Philly Poacher</returns>
        public override string ToString()
        {
            return ("Philly Poacher");
        }
    }
}
