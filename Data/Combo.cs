/**
 * Author: Zach Hazen
 * Class Name: Combo.cs
 * Purpose: Combo class used to hold an entree, drink, and side and invoke the correct event handlers upon changes.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Class used to hold an entree, drink, and side object. Adds corresponding event listeners for each item and invokes the appropriate handler upon one of the item's properties being changed.
    /// Creates many custom fields aggregating the child fields' values. Ex-Price, Calories, SpecialInstructions, etc.
    /// </summary>
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler to be invoked whenever a property changes for an individual item or the Combo as a whole.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The private backing Entree variable.
        /// </summary>
        private Entree entree;

        /// <summary>
        /// The private backing Side variable.
        /// </summary>
        private Side side;

        /// <summary>
        /// The private backing Drink variable.
        /// </summary>
        private Drink drink;

        /// <summary>
        /// Constructor for Combo requiring its three components be initialized first - entree, side, and drink.
        /// </summary>
        /// <param name="e">The entree object to be included in the combo.</param>
        /// <param name="s">The side object to be included in the combo.</param>
        /// <param name="d">The drink object to be included in the combo.</param>
        public Combo(Entree e, Side s, Drink d)
        {
            entree = e;
            side = s;
            drink = d;
        }

        /// <summary>
        /// The Entree variable, interfaces with the private backing variable. Invokes the PropertyChanged event handler with the appropriate EventArgs to notify
        /// corresponding listeners for whenever a property changes in the object. Removes the specialized Combo PropertyChanged EventListener when adding a new
        /// Entree to prevent memory loss and adds the listener to the new Entree.
        /// </summary>
        public Entree Entree
        {
            get
            {
                return entree;
            }
            set
            {
                if (entree != null)
                {
                    entree.PropertyChanged -= ComboPropertyChangedInvoker;
                }

                entree = value;

                entree.PropertyChanged += ComboPropertyChangedInvoker;
                
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// The Side variable, interfaces with the private backing variable. Invokes the PropertyChanged event handler with the appropriate EventArgs to notify
        /// corresponding listeners for whenever a property changes in the object. Removes the specialized Combo PropertyChanged EventListener when adding a new
        /// Side to prevent memory loss and adds the listener to the new Side.
        /// </summary>
        public Side Side
        {
            get
            {
                return side;
            }
            set
            {
                if (side != null)
                {
                    side.PropertyChanged -= ComboPropertyChangedInvoker;
                }

                side = value;

                side.PropertyChanged += ComboPropertyChangedInvoker;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// The Drink variable, interfaces with the private backing variable. Invokes the PropertyChanged event handler with the appropriate EventArgs to notify
        /// corresponding listeners for whenever a property changes in the object. Removes the specialized Combo PropertyChanged EventListener when adding a new
        /// Drink to prevent memory loss and adds the listener to the new Drink.
        /// </summary>
        public Drink Drink
        {
            get
            {
                return drink;
            }
            set
            {
                if (drink != null)
                {
                    drink.PropertyChanged -= ComboPropertyChangedInvoker;
                }

                drink = value;

                drink.PropertyChanged += ComboPropertyChangedInvoker;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Simply adds together the prices of all child objects and subtracts by one to reflect the combo discount.
        /// </summary>
        public double Price
        {
            get
            {
                return entree.Price + side.Price + drink.Price - 1;
            }
        }

        /// <summary>
        /// Simply adds together the calories of all child objects.
        /// </summary>
        public uint Calories
        {
            get
            {
                return entree.Calories + side.Calories + drink.Calories;
            }
        }

        /// <summary>
        /// The SpecialInstructions for the Combo. Creates a new List of strings with all the special instructions for each item in the Combo and also adds the name of each
        /// item.
        /// </summary>
        public List<string> SpecialInstructions {
            get
            {
                List<string> comboInstructions = new List<string>();
                comboInstructions.Add(entree.ToString());
                foreach(string item in entree.SpecialInstructions)
                {
                    comboInstructions.Add(item);
                }

                comboInstructions.Add(side.ToString());
                foreach (string item in side.SpecialInstructions)
                {
                    comboInstructions.Add(item);
                }

                comboInstructions.Add(drink.ToString());
                foreach (string item in drink.SpecialInstructions)
                {
                    comboInstructions.Add(item);
                }

                return comboInstructions;
            }
        }

        /// <summary>
        /// A custom EventListener used to invoke the corresponding EventHandlers whenever a property of one of the child objects is changed, whether it be Price, Calories, or the SpecialInstructions.
        /// </summary>
        /// <param name="sender">This is the EventHandler this Listener is attached to, typically the PropertyChanged handler being invoked regarding a property being changed.</param>
        /// <param name="e">This is the property being changed in the Entree, Drink, or Side that the eventhandler triggering this function is attached to.</param>
        public void ComboPropertyChangedInvoker(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
            else if (e.PropertyName == "Calories")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
            else if (e.PropertyName == "SpecialInstructions")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
    }
}
