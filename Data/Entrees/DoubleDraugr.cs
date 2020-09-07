using System;
using System.Collections.Generic;
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
    public class DoubleDraugr
    {
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
                bun = value;
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
                ketchup = value;
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
                mustard = value;
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
                pickle = value;
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
                cheese = value;
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
                tomato = value;
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
                lettuce = value;
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
                mayo = value;
            }
        }

        /// <summary>
        /// The price of the Double Draugr
        /// </summary>
        public double Price { get; } = 7.32;

        /// <summary>
        /// The calories of the Double Draugr
        /// </summary>
        public uint Calories { get; } = 843;

        /// <summary>
        /// A list of special instructions to prepare the Double Draugr
        /// </summary>
        public List<string> SpecialInstructions { get; } = new List<string>();
        /// <summary>
        /// Returns a description of the Double Draugr
        /// </summary>
        /// <returns>A string containing the name of the Double Draugr</returns>
        public override string ToString()
        {
            return ("Double Draugr");
        }
    }
}
