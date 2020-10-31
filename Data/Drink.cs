/*
 * Author: Zach Hazen
 * Class Name: Drink.cs
 * Purpose: Abstract class to be implemented by all drink items in the Bleakwind Buffet.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Abstract class to be implemented by all drinks in the Bleakwind Buffet. Provides fields that all drinks should possess.
    /// </summary>
    public abstract class Drink : IOrderItem
    {
        // PropertyChanged event handler to be invoked when changing any of the descendant's properties.
        public abstract event PropertyChangedEventHandler PropertyChanged;
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
