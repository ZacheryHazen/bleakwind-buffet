using System;
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
        bool bun = true;

        bool ketchup = true;

        bool mustard = true;

        bool pickle = true;

        bool cheese = true;

        bool tomato = true;

        bool lettuce = true;

        bool mayo = true;

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
            }
        }
        public double Price { get; } = 7.32;

        public uint Calories { get; } = 843;

        public List<string> SpecialInstructions { get; }

        public override string ToString()
        {
            return ("Double Draugr");
        }
    }
}
