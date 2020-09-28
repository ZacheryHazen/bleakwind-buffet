/** Author: Zach Hazen
 *  Class Name: MainWindow.xaml.cs
 *  Purpose: The other half of the MainWindow class. This class is used to display all other components and manage the project's data.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes the .xaml side of the MainWindow class. Also initializes the child panels, MenuSelectionComponent and OrderComponent.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            menuSelectionBorder.Child = new MenuSelectionComponent(this);
            orderComponentBorder.Child = new OrderComponent();
        }

        /// <summary>
        /// This method is called to display the MenuSelectionComponent, and clears out the menuSelectionBorder before doing so.
        /// </summary>
        public void ReturnToMenuSelection()
        {
            menuSelectionBorder.Child = null;
            menuSelectionBorder.Child = new MenuSelectionComponent(this);
        }

        /// <summary>
        /// This method clears out the menuSelectionBorder and fills it with the specificItemCustomization component. It also 
        /// supplies the component with the name of the item chosen by the MenuSelectionComponent.
        /// </summary>
        /// <param name="name">This is the name of the item chosen by the MenuSelectionComponent, which calls this method once an item is selected.</param>
        public void OpenCustomizeOptions(string name)
        {
            menuSelectionBorder.Child = null;
            menuSelectionBorder.Child = new SpecificItemCustomization(this, name);
        }
    }
}
