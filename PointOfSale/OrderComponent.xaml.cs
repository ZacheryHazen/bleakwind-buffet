/** Author: Zach Hazen
 *  Class Name: OrderComponent.xaml.cs
 *  Purpose: The other half of the MainWindow class. This class is used to display all ordered items in a ListView.
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
    /// Interaction logic for OrderComponent.xaml
    /// </summary>
    public partial class OrderComponent : UserControl
    {
        /// <summary>
        /// Initializes the .xaml side of the class.
        /// </summary>
        public OrderComponent()
        {
            InitializeComponent();
        }
    }
}
