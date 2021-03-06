﻿/*
 * Author: Zach Hazen
 * Class Name: Entree.cs
 * Purpose: Abstract class to be implemented by all entree items in the Bleakwind Buffet.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Abstract class to be implemented by all entrees in the Bleakwind Buffet. Provides fields that all entrees should possess.
    /// </summary>
    public abstract class Entree : IOrderItem
    {
        // PropertyChanged event handler to be invoked when changing any of the descendant's properties.
        public abstract event PropertyChangedEventHandler PropertyChanged;
        // Double to hold the price of the entree.
        public abstract double Price { get; }
        // Unsigned integer to hold the calories of the entree.
        public abstract uint Calories { get; }
        // List of strings to hold any special instructions to be used when preparing the entree.
        public abstract List<string> SpecialInstructions { get; }
        // String holding a description of the entree.
        public abstract string Description { get; }
    }
}
