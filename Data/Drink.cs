using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Abstract class to be implemented by all drinks in the Bleakwind Buffet. Provides fields that all drinks should possess.
    /// </summary>
    public abstract class Drink
    {
        // Size enum that holds the size of a drink.
        public abstract Size Size { get; set; }
        // Double holding the price of a drink.
        public abstract double Price { get; }
        // Unsigned integer holding the calories of a drink.
        public abstract uint Calories { get; }
        // List of strings holding special instructions to be used when preparing a drink.
        public abstract List<string> SpecialInstructions { get; }
    }
}
