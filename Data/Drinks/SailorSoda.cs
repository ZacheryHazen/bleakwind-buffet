using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

/*
 * Author: Zach Hazen
 * Purpose: Class used to represent the Sailor Soda drink via various fields and methods.
 */

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class used to represent the Sailor Soda drink via various fields and methods.
    /// </summary>
    public class SailorSoda : Drink, IOrderItem
    {
        /// <summary>
        /// The event handler to be used when a specific property changes in the object.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;
        // Declaring private backing variables
        private bool ice = true;

        private Size size = Size.Small;

        private Enums.SodaFlavor flavor = SodaFlavor.Cherry;
        /// <summary>
        /// If the soda should be served with ice
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
                else
                {
                    SpecialInstructions.Remove("Hold ice");
                }
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
            }
        }
        /// <summary>
        /// The size of the soda
        /// </summary>
        public override Size Size {
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
        /// The flavor of the soda
        /// </summary>
        public SodaFlavor Flavor {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
            }
        }
        /// <summary>
        /// The price of the soda based on its size
        /// </summary>
        public override double Price {
            get
            {
                if (size == Size.Small)
                {
                    return 1.42;
                }
                else if (size == Size.Medium)
                {
                    return 1.74;
                }
                else
                {
                    return 2.07;
                }
            }
        }
        /// <summary>
        /// The calories of the soda based on its size
        /// </summary>
        public override uint Calories {
            get
            {
                if (size == Size.Small)
                {
                    return 117;
                }
                else if (size == Size.Medium)
                {
                    return 153;
                }
                else
                {
                    return 205;
                }
            }
        }
        /// <summary>
        /// Instructions to be used when preparing the soda
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
        /// Holds the description of the Sailor Soda.
        /// </summary>
        public override string Description
        {
            get
            {
                return "An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.";
            }
        }

        /// <summary>
        /// Returns the name of the soda
        /// </summary>
        /// <returns>A string containing a description of the soda</returns>
        public override string ToString()
        {
            return (size + " " + flavor + " Sailor Soda");
        }
    }
}
