using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

/*
 * Author: Zach Hazen
 * Purpose: Class used to represent the Garden Orc Omelette entree via various fields and methods.
 */

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class used to represent the Garden Orc Omelette entree via various fields and methods
    /// </summary>
    public class GardenOrcOmelette : Entree, IOrderItem
    {
        /// <summary>
        /// The event handler to be used when a specific property changes in the object.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;
        // Declaring private backing variables
        private bool broccoli = true;

        private bool mushrooms = true;

        private bool tomato = true;

        private bool cheddar = true;

        /// <summary>
        /// If the Garden Orc Omelette is to be served with broccoli
        /// </summary>
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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                else
                {
                    SpecialInstructions.Remove("Hold broccoli");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                broccoli = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Broccoli"));
            }
        }

        /// <summary>
        /// If the Garden Orc Omelette is to be served with mushrooms
        /// </summary>
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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                else
                {
                    SpecialInstructions.Remove("Hold mushrooms");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                mushrooms = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mushrooms"));
            }
        }

        /// <summary>
        /// If the Garden Orc Omelette is to be served with tomatoes
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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                else
                {
                    SpecialInstructions.Remove("Hold tomato");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                tomato = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
            }
        }

        /// <summary>
        /// If the Garden Orc Omelette is to be served with cheddar cheese
        /// </summary>
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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                else
                {
                    SpecialInstructions.Remove("Hold cheddar");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                cheddar = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheddar"));
            }
        }
        /// <summary>
        /// The price of the Garden Orc Omelette
        /// </summary>
        public override double Price { get; } = 4.57;

        /// <summary>
        /// The calories of the Garden Orc Omelette
        /// </summary>
        public override uint Calories { get; } = 404;

        /// <summary>
        /// A list of special instructions to be used when preparing the Garden Orc Omelette
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
        /// Returns a description of the Garden Orc Omelette
        /// </summary>
        /// <returns>A string containing the name of the Garden Orc Omelette</returns>
        public override string ToString()
        {
            return ("Garden Orc Omelette");
        }
    }
}
