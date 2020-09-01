using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /*
    * Author: Zach Hazen
    * Class name: BriarheartBurger.cs
    * Purpose: Class used to represent the Briarheart Burger entree via various fields and methods.
    */
    class BriarheartBurger
    {
        bool bun = true;

        bool ketchup = true;

        bool mustard = true;

        bool pickle = true;

        bool cheese = true;

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
            }
        }

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
            }
        }

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
            }
        }

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
            }
        }

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
            }
        }

        public double Price { get; } = 6.32;

        public uint Calories { get; } = 743;

        public List<string> SpecialInstructions { get; } = new List<string>();

        public override string ToString()
        {
            return ("Briarheart Burger");
        }
    }
}