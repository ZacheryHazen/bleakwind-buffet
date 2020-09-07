﻿using System;
using System.Collections.Generic;
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
    public class GardenOrcOmelette
    {
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
                }
                broccoli = value;
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
                }
                mushrooms = value;
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
                }
                tomato = value;
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
                }
                cheddar = value;
            }
        }
        /// <summary>
        /// The price of the Garden Orc Omelette
        /// </summary>
        public double Price { get; } = 4.57;

        /// <summary>
        /// The calories of the Garden Orc Omelette
        /// </summary>
        public uint Calories { get; } = 404;

        /// <summary>
        /// A list of special instructions to be used when preparing the Garden Orc Omelette
        /// </summary>
        public List<string> SpecialInstructions { get; } = new List<string>();

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
