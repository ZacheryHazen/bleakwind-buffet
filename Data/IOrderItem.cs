/*
 * Author: Zach Hazen
 * Class Name: IOrderItem.cs
 * Purpose: Interface to be implemented by all items in the Bleakwind Buffet menu.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Interface used in all entrees, drinks, and sides to provide baseline fields.
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
    {
        // Double to hold the price of the entree, side, or drink.
        double Price { get; }
        // Unsigned integer to hold the calories of the entree, side, or drink.
        uint Calories { get; }
        // List of strings to hold all potential special instructions to prepare entrees, sides, or drinks.
        List<string> SpecialInstructions { get; }
    }
}
