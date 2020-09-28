/*
 * Author: Zach Hazen
 * Class Name: Side.cs
 * Purpose: Abstract class to be implemented by all side items in the Bleakwind Buffet.
 */


using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Abstract class to be implemented by all sides in the Bleakwind Buffet. Provides fields that all sides should possess.
    /// </summary>
    public abstract class Side
    {
        // Size enum that holds the size of a side.
        public abstract Size Size { get; set; }
        // Double to hold the price of a side.
        public abstract double Price { get; }
        // Unsigned integer to hold the calories of a side.
        public abstract uint Calories { get; }
        // List of strings to hold any special instructions to be used when preparing a side.
        public abstract List<string> SpecialInstructions { get; }
    }
}
