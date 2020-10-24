/** Author: Zach Hazen
 *  Class Name: OrderComponent.xaml.cs
 *  Purpose: The other half of the MainWindow class. This class is used to display all ordered items in a ListView.
 */

using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderComponent.xaml
    /// </summary>
    public partial class OrderComponent : UserControl
    {
        MainWindow parentScreen;
        /// <summary>
        /// Initializes the .xaml side of the class.
        /// </summary>
        public OrderComponent(MainWindow parent)
        {
            InitializeComponent();
            parentScreen = parent;
        }

        /// <summary>
        /// Removes the selected item from the Order in the MainWindow element - thus removing it from the OrderComponent.
        /// </summary>
        /// <param name="sender">This is the remove button present in all ListBoxItems.</param>
        /// <param name="e">This is the click.</param>
        public void RemoveItem(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                if (button.DataContext is IOrderItem orderItem)
                {
                    parentScreen.order.Remove(orderItem);
                }
            }
        }

        /// <summary>
        /// Opens a SpecificItemCustomization specific to the ListBoxItem selected. While the item is being modified, it removes the item from
        /// the OrderComponent.
        /// </summary>
        /// <param name="sender">This is the ListBox as this is only triggered from a SelectionChange event.</param>
        /// <param name="e">This is the SelectionChange event, triggered whenever the user clicks a different item in the itemsListBox.</param>
        public void ModifyItem(object sender, RoutedEventArgs e)
        {
            if (sender is ListBox listBox)
            {
                if (listBox.SelectedItem is IOrderItem orderItem)
                {
                    if(listBox.ItemsSource is Order order)
                    {
                        parentScreen.ModifyCustomizedOptions(orderItem);
                        order.Remove(orderItem);
                    }                    
                }
            }
        }

        /// <summary>
        /// Clears the Order object in the MainWindow element. This also clears the itemsListBox due to its binding.
        /// </summary>
        /// <param name="sender">This is the 'Cancel' button.</param>
        /// <param name="e">This is the click.</param>
        public void ClearOrder(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                if (button.Name == "buttonCancel")
                {
                    parentScreen.order.Clear();
                }
            }
        }
    }
}
