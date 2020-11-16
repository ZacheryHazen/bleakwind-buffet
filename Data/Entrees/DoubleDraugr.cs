using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

/*
 * Author: Zach Hazen
 * Purpose: Class used to represent the Double Draugr entree via various fields and methods.
 */

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class used to represent the Double Draugr entree via various fields and methods.
    /// </summary>
    public class DoubleDraugr : Entree, IOrderItem
    {
        /// <summary>
        /// The event handler to be used when a specific property changes in the object.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;
        // Declaring private backing variables
        private bool bun = true;

        private bool ketchup = true;

        private bool mustard = true;

        private bool pickle = true;

        private bool cheese = true;

        private bool tomato = true;

        private bool lettuce = true;

        private bool mayo = true;

        /// <summary>
        /// If the Double Draugr is to be served with a bun
        /// </summary>
        public bool Bun
        {
            get
            {
                return bun;
            }

            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold bun");
                }
                else
                {
                    SpecialInstructions.Remove("Hold bun");
                }
                bun = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
            }
        }
        /// <summary>
        /// If the Double Draugr is to be served with ketchup
        /// </summary>
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }

            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold ketchup");
                }
                else
                {
                    SpecialInstructions.Remove("Hold ketchup");
                }
                ketchup = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
            }
        }

        /// <summary>
        /// If the Double Draugr is to be served with mustard
        /// </summary>
        public bool Mustard
        {
            get
            {
                return mustard;
            }

            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold mustard");
                }
                else
                {
                    SpecialInstructions.Remove("Hold mustard");
                }
                mustard = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
            }
        }

        /// <summary>
        /// If the Double Draugr is to be served with pickles
        /// </summary>
        public bool Pickle
        {
            get
            {
                return pickle;
            }

            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold pickle");
                }
                else
                {
                    SpecialInstructions.Remove("Hold pickle");
                }
                pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
            }
        }

        /// <summary>
        /// If the Double Draugr is to be served with cheese
        /// </summary>
        public bool Cheese
        {
            get
            {
                return cheese;
            }

            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold cheese");
                }
                else
                {
                    SpecialInstructions.Remove("Hold cheese");
                }
                cheese = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
            }
        }

        /// <summary>
        /// If the Double Draugr is to be served with tomatoes
        /// </summary>
        public bool Tomato
        {
            get
            {
                return tomato;
            }

            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold tomato");
                }
                else
                {
                    SpecialInstructions.Remove("Hold tomato");
                }
                tomato = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
            }
        }

        /// <summary>
        /// If the Double Draugr is to be served with lettuce
        /// </summary>
        public bool Lettuce
        {
            get
            {
                return lettuce;
            }

            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold lettuce");
                }
                else
                {
                    SpecialInstructions.Remove("Hold lettuce");
                }
                lettuce = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
            }
        }

        /// <summary>
        /// If the Double Draugr is to be served with mayo
        /// </summary>
        public bool Mayo
        {
            get
            {
                return mayo;
            }

            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold mayo");
                }
                else
                {
                    SpecialInstructions.Remove("Hold mayo");
                }
                mayo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
            }
        }

        /// <summary>
        /// The price of the Double Draugr
        /// </summary>
        public override double Price { get; } = 7.32;

        /// <summary>
        /// The calories of the Double Draugr
        /// </summary>
        public override uint Calories { get; } = 843;

        /// <summary>
        /// A list of special instructions to prepare the Double Draugr
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
        /// Holds the description of the Double Draugr.
        /// </summary>
        public override string Description
        {
            get
            {
                return "Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo.";
            }
        }

        /// <summary>
        /// Returns the name of the Double Draugr.
        /// </summary>
        /// <returns>A string containing the name of the Double Draugr.</returns>
        public override string ToString()
        {
            return ("Double Draugr");
        }
    }
}
