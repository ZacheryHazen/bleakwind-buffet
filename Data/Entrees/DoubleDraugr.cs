﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /*
    * Author: Zach Hazen
    * Class name: DoubleDraugr.cs
    * Purpose: Class used to represent the Double Draugr entree via various fields and methods.
    */
    class DoubleDraugr
    {
        private bool bun = true;

        private bool ketchup = true;

        private bool mustard = true;

        private bool pickle = true;

        private bool cheese = true;

        private bool tomato = true;

        private bool lettuce = true;

        private bool mayo = true;

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
        public double Price { get; } = 7.32;

        public uint Calories { get; } = 843;

        public List<string> SpecialInstructions { get; } = new List<string>();

        public override string ToString()
        {
            return ("Double Draugr");
        }
    }
}