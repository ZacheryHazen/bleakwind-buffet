using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

/*
 * Author: Zach Hazen
 * Purpose: Class used to represent the Briarheart Burger entree via various fields and methods.
 */

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class used to represent the Briarheart Burger entree via various fields and methods.
    /// </summary>
    public class BriarheartBurger : Entree, IOrderItem
    {
        // Declaring private backing variables
        private bool bun = true;

        private bool ketchup = true;

        private bool mustard = true;

        private bool pickle = true;

        private bool cheese = true;

        /// <summary>
        /// If the Briarheart Burger is to be served with a bun
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
        /// If the Briarheart Burger is to be served with ketchup
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
        /// If the Briarheart Burger is to be served with mustard
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
        /// If the Briarheart Burger is to be served with pickles
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
        /// If the Briarheart Burger is to be served with cheese
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
        /// The price of the Briarheart Burger
        /// </summary>
        public override double Price { get; } = 6.32;

        /// <summary>
        /// The calories of the Briarheart Burger
        /// </summary>
        public override uint Calories { get; } = 743;

        /// <summary>
        /// A list of special instructions for preparing the Briarheart Burger
        /// </summary>
        public override List<string> SpecialInstructions { get; } = new List<string>();

        /// <summary>
        /// Returns a description of the Briarheart Burger
        /// </summary>
        /// <returns>A string containing a simple description of the Briarheart Burger</returns>
        public override string ToString()
        {
            return ("Briarheart Burger");
        }
    }
}