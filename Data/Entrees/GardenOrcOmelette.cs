using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /*
    * Author: Zach Hazen
    * Class name: GardenOrcOmelette.cs
    * Purpose: Class used to represent the Garden Orc Omelette entree via various fields and methods.
    */
    public class GardenOrcOmelette
    {
        private bool broccoli = true;

        private bool mushrooms = true;

        private bool tomato = true;

        private bool cheddar = true;
        public bool Broccoli
        {
            get
            {
                return broccoli;
            }

            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold broccoli");
                }
                broccoli = value;
            }
        }

        public bool Mushrooms
        {
            get
            {
                return mushrooms;
            }

            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold mushrooms");
                }
                mushrooms = value;
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

        public bool Cheddar
        {
            get
            {
                return cheddar;
            }

            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold cheddar");
                }
                cheddar = value;
            }
        }
        public double Price { get; } = 4.57;

        public uint Calories { get; } = 404;

        public List<string> SpecialInstructions { get; } = new List<string>();

        public override string ToString()
        {
            return ("Garden Orc Omelette");
        }
    }
}
