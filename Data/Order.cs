/**
 * Author: Zach Hazen
 * Class Name: Order.cs
 * Purpose: Order class used to hold all IOrderItems in a user's order.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Order class used to hold all IOrderItems, provides all of the implementation an ICollection needs, and can be treated as a List through it's interactions with its
    /// backing List, IOrderItems. Adds all Event Handler invocation needed for functionality.
    /// </summary>
    public class Order : ICollection<IOrderItem>, INotifyCollectionChanged, INotifyPropertyChanged
    { 
        /// <summary>
        /// The event handler to be used when a specific property changes in the Order object.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The event handler to be used whenever the orderItems list changes.
        /// </summary>
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        /// <summary>
        /// The sales tax rate to be used when determining the Tax and Total properties.
        /// </summary>
        public double SalesTaxRate { get; set; } = 0.12;

        /// <summary>
        /// Private backing variable for the order number in each Order object.
        /// </summary>
        public int number = 0;

        /// <summary>
        /// Static variable that determines what the next order number should be.
        /// </summary>
        private static int nextOrderNumber = 1;

        /// <summary>
        /// The backing list that holds every orderItem. Is used to circumvent creating an entirely new List class specific to IOrderItems with the correct modifications.
        /// </summary>
        private List<IOrderItem> orderItems = new List<IOrderItem>();

        /// <summary>
        /// Determines whether the object is ReadOnly.
        /// </summary>
        bool ICollection<IOrderItem>.IsReadOnly => ((ICollection<IOrderItem>)this).IsReadOnly;

        /// <summary>
        /// Returns the Count of all items in the orderItems list.
        /// </summary>
        int ICollection<IOrderItem>.Count => orderItems.Count;

        /// <summary>
        /// Returns the Count of all items in the orderItems list.
        /// </summary>
        int Count => orderItems.Count;

        /// <summary>
        /// The order number of the Order object. This should be unique to every order, and makes use of a PropertyChanged event handler to notify the appropriate listeners when changed.
        /// </summary>
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Number"));
                number = value;
            }
        }

        /// <summary>
        /// The calories of all items in the orderItems list. Adds together all the calories of each item.
        /// </summary>
        public uint Calories
        {
            get
            {
                uint sum = 0;

                foreach (IOrderItem item in orderItems)
                {
                    sum += item.Calories;
                }

                return sum;
            }
        }

        /// <summary>
        /// The subtotal of all items in the orderItems list. Adds together all the prices of each item.
        /// </summary>
        public double Subtotal
        {
            get
            {
                double sum = 0;

                foreach (IOrderItem item in orderItems)
                {
                    sum += item.Price;
                }

                return sum;
            }
        }

        /// <summary>
        /// The total tax on all items in the orderItems list. Multiplies the Subtotal and SalesTaxRate properties.
        /// </summary>
        public double Tax
        {
            get
            {
                return Subtotal * SalesTaxRate;
            }
        }

        /// <summary>
        /// This is the total price of all items in the orderItems list. Adds the Subtotal and Tax properties.
        /// </summary>
        public double Total
        {
            get
            {
                return Subtotal + Tax;
            }
        }

        /// <summary>
        /// Interfaces with the underlying orderItems list to allow the Order object to be interacted in the same way as an array or list.
        /// </summary>
        /// <param name="index">The index of the item being modified, added, or retrieved.</param>
        /// <returns>If used for the getter, returns the item at 'index' position.</returns>
        public IOrderItem this[int index]
        {
            get
            {
                return orderItems[index];
            }
            set
            {
                orderItems[index] = value;
            }
        }

        /// <summary>
        /// The constructor, simply generates the correct order number.
        /// </summary>
        public Order()
        {
            Number = nextOrderNumber;
            nextOrderNumber++;
        }

        /// <summary>
        /// Adds an item to the orderItems list. Notifies the proper event listeners that the collection, calories, subtotal, tax, and total have changed.
        /// Also adds an event listener to the item being added.
        /// </summary>
        /// <param name="item">The item being added.</param>
        public void Add(IOrderItem item)
        {
            orderItems.Add(item);
            //Reset is the only NotifyCollectionChangedAction that works. Add duplicates the entire list.
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
            item.PropertyChanged += OrderPropertyChangedInvoker;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        }

        /// <summary>
        /// Removes an item from the orderItems list. If removed successfully, notifies the proper event listeners that the collection, calories, subtotal, tax, and total have changed.
        /// Also removes event listener from item removed.
        /// </summary>
        /// <param name="item">The item to be removed.</param>
        /// <returns>Returns whether or not the item was successfully removed.</returns>
        public bool Remove(IOrderItem item)
        {
            if(orderItems.Remove(item))
            {
                item.PropertyChanged -= OrderPropertyChangedInvoker;
                //Same as Add.
                CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                return true;
            }
            return false;
        }

        /// <summary>
        /// Calls the clear method for the orderItems as well as notifies the Subtotal, Tax, Total, Calories, and Collection event listeners of the change.
        /// Also increments the order number.
        /// </summary>
        public void Clear()
        {
            orderItems.Clear();
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            Number++;
            nextOrderNumber++;
        }
        
        /// <summary>
        /// Detects if the orderItems array holds a specified item.
        /// </summary>
        /// <param name="item">The item being searched for.</param>
        /// <returns>This bool reflects whether the item is present in the array.</returns>
        public bool Contains(IOrderItem item)
        {
            return orderItems.Contains(item);
        }

        /// <summary>
        /// This allows the orderItems array to be copied over to an array of IOrderItems at a starting index.
        /// </summary>
        /// <param name="newList">The array being copied over to.</param>
        /// <param name="index">The starting index to begin copying the items to in the IOrderItems array.</param>
        public void CopyTo(IOrderItem[] newList, int index)
        {
            orderItems.CopyTo(newList, index);
        }

        /// <summary>
        /// Performs a yield return on all the items in the orderItems list. Is used in foreach loops.
        /// </summary>
        /// <returns>These are all the values in the orderItems list.</returns>
        public IEnumerator<IOrderItem> GetEnumerator()
        {
            for (int x = 0; x < orderItems.Count; x++)
            {
                yield return orderItems[x];
            }
        }
        
        /// <summary>
        /// Returns the result of GetEnumerator() - all of the items in the orderItems list.
        /// </summary>
        /// <returns>This is the IEnumerable used when iterating through items in a foreach loop.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// This is an event listener created to simplify invoking the correct PropertyChanged event handlers. It's attached to every item in the
        /// orderItems list as they all need to notify their respective handlers of the overall calories, subtotal, tax, and total changing whenever needed. 
        /// </summary>
        /// <param name="sender">This would be the PropertyChanged event handlers this is assigned to, which should be any property that changes the price or calories when changed.</param>
        /// <param name="e">This would be the properties that would change the price or calories being changed.</param>
        public void OrderPropertyChangedInvoker(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            }
            else if (e.PropertyName == "Calories")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }
    }
}
