/** Author: Zach Hazen
 *  Class Name: MenuSelectionComponent.xaml.cs
 *  Purpose: The other half of the MenuSelectionComponent class. This class is used to display all available options from the Bleakwind Buffet. This class also communicates to the MainWindow
 *  what items are selected.
 */

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
    /// Interaction logic for MenuSelectionComponent.xaml
    /// </summary>
    public partial class MenuSelectionComponent : UserControl
    {
        /// <summary>
        /// The name of the order item chosen.
        /// </summary>
        public string orderChoiceName;
        /// <summary>
        /// The MainWindow object this window is usually contained in.
        /// </summary>
        public MainWindow parentScreen;
        
        /// <summary>
        /// Initializes the .xaml side of the MenuSelectionComponent class. Also assigns the parentScreen variable a value.
        /// </summary>
        /// <param name="parent">This is typically the MainWindow class, and is needed to exit the component.</param>
        public MenuSelectionComponent(MainWindow parent)
        {
            InitializeComponent();
            parentScreen = parent;
        }

        /// <summary>
        /// This method is how the project determines what item is selected. The method retrieves what the name of the item is from a 
        /// TextBlock nested in the button being pressed. It then passes this to its parent for it to use in the SpecificItemCustomization class.
        /// </summary>
        /// <param name="sender">This is the button pertaining to the order item selected.</param>
        /// <param name="e">This is the click of the button. </param>
        public void OrderChoiceSelected(object sender, RoutedEventArgs e)
        {
            orderChoiceName = ((TextBlock)((Button)sender).Content).Text;
            parentScreen.OpenNewCustomizeOptions(orderChoiceName);
        }
    }
}
