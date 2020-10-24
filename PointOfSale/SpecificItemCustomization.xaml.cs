/** Author: Zach Hazen
 *  Class Name: SpecificItemCustomization.xaml.cs
 *  Purpose: The other half of the MainWindow class. This class is used to display all customizable options for a supplied menu item.
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.DirectoryServices.ActiveDirectory;
using System.Printing;
using System.Reflection;
using System.Text;
using System.Transactions;
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
    /// Interaction logic for specificItemCustomization.xaml
    /// </summary>
    public partial class SpecificItemCustomization : UserControl
    {
        /// <summary>
        /// The MainWindow object that contains this element.
        /// </summary>
        public MainWindow parentScreen;

        /// <summary>
        /// This is the item that will be customized in the element.
        /// </summary>
        IOrderItem orderItem;

        /// <summary>
        /// Holds all CheckBoxes and ComboBoxes.
        /// </summary>
        CheckBox[] checkBoxes;
        ComboBox[] comboBoxes;

        /// <summary>
        /// An array of bindings for the ComboBoxes and CheckBoxes.
        /// </summary>
        Binding[] comboBoxBindings;
        Binding[] checkBoxBindings;

        /// <summary>
        /// All of the options for the enumerators - couldn't find a way to retrieve all available options succinctly.
        /// </summary>
        Dictionary<string, string[]> enumOptions = new Dictionary<string, string[]>()
        {
            {"Size", new string[] {"Small", "Medium", "Large"}},
            {"Flavor", new string[] {"Blackberry", "Cherry", "Grapefruit", "Lemon", "Peach", "Watermelon"}}
        };

        /// <summary>
        /// Initializes the SpecificItemCustomization form in the event that it's a new item. It facilitates the orderItem being created and also retrieves the properties of the orderItem.
        /// It then facilitates the creation and binding of all relevant properties in the element.
        /// </summary>
        /// <param name="parent">This is the parent form, usually MainWindow. Needed to exit form.</param>
        /// <param name="itemName">This is the name of the item that needs customization.</param>
        public SpecificItemCustomization(MainWindow parent, string itemName)
        {
            InitializeComponent();
            parentScreen = parent;
            CreateOrderItem(itemName);
            this.DataContext = orderItem;

            InitializeFormComponents();
            
        }

        /// <summary>
        /// Initializes the SpecificItemCustomization form in the event that it's modifying an existing item. It assigns the orderItem to the DataContext, changes the Exit button's content,
        /// and retrieves the properties of the item. It then facilitates the creation and binding of all relevant properties in the element.
        /// </summary>
        /// <param name="parent">This is the parent form, usually MainWindow. Needed to exit form.</param>
        /// <param name="oldOrderItem">This is the name of the item that needs customization.</param>
        public SpecificItemCustomization(MainWindow parent, IOrderItem oldOrderItem)
        {
            InitializeComponent();
            parentScreen = parent;
            orderItem = oldOrderItem;
            this.DataContext = orderItem;
            buttonExit.Content = "Exit Customization";

            InitializeFormComponents();
        }

        /// <summary>
        /// Initializes all of the form's elements that correspond with the orderItem's properties. Calls the GetProperties() method from Reflection to find all properties that need a form element
        /// to be created, and then uses all booleans and enums (first creating the arrays responsible) and then passing the PropertyInfo for each property and the correct index to
        /// InitializesCheckBoxes and InitializeComboBoxes to create all of the form's relevant elements.
        /// </summary>
        public void InitializeFormComponents()
        {
            PropertyInfo[] tests = orderItem.GetType().GetProperties();

            int comboBoxCounter = 0;
            int checkBoxCounter = 0;

            foreach (PropertyInfo item in tests)
            {
                if (item.PropertyType.ToString().Contains("BleakwindBuffet.Data.Enums"))
                {
                    comboBoxCounter++;
                }
                else if (item.PropertyType.ToString().Equals("System.Boolean"))
                {
                    checkBoxCounter++;
                }
            }

            checkBoxes = new CheckBox[checkBoxCounter];
            comboBoxes = new ComboBox[comboBoxCounter];
            checkBoxBindings = new Binding[checkBoxCounter];
            comboBoxBindings = new Binding[comboBoxCounter];

            checkBoxCounter = 0;
            comboBoxCounter = 0;

            foreach (PropertyInfo item in tests)
            {
                if (item.PropertyType.ToString().Contains("BleakwindBuffet.Data.Enums"))
                {
                    InitializeComboBoxes(comboBoxCounter, item);
                    comboBoxCounter++;
                }
                else if (item.PropertyType.ToString().Equals("System.Boolean"))
                {
                    InitializeCheckBoxes(checkBoxCounter, item);
                    checkBoxCounter++;
                }
            }
        }

        /// <summary>
        /// Initializes the orderItem variable to be an object corresponding to the button clicked.
        /// </summary>
        /// <param name="itemName">This is the name of the object needing to be created, passed initially from the button pressed in MenuSelectionComponent.</param>
        public void CreateOrderItem(string itemName)
        {
            switch (itemName)
            {
                case ("Briarheart Burger"):
                    orderItem = new BriarheartBurger();
                    break;
                case ("Double Draugr"):
                    orderItem = new DoubleDraugr();
                    break;
                case ("Garden Orc Omelette"):
                    orderItem = new GardenOrcOmelette();
                    break;
                case ("Philly Poacher"):
                    orderItem = new PhillyPoacher();
                    break;
                case ("Smokehouse Skeleton"):
                    orderItem = new SmokehouseSkeleton();
                    break;
                case ("Thalmor Triple"):
                    orderItem = new ThalmorTriple();
                    break;
                case ("Thugs T-Bone"):
                    orderItem = new ThugsTBone();
                    break;
                case ("Aretino Apple Juice"):
                    orderItem = new AretinoAppleJuice();
                    break;
                case ("Candlehearth Coffee"):
                    orderItem = new CandlehearthCoffee();
                    break;
                case ("Markarth Milk"):
                    orderItem = new MarkarthMilk();
                    break;
                case ("Sailor Soda"):
                    orderItem = new SailorSoda();
                    break;
                case ("Warrior Water"):
                    orderItem = new WarriorWater();
                    break;
                case ("Dragonborn Waffle Fries"):
                    orderItem = new DragonbornWaffleFries();
                    break;
                case ("Fried Miraak"):
                    orderItem = new FriedMiraak();
                    break;
                case ("Mad Otar Grits"):
                    orderItem = new MadOtarGrits();
                    break;
                case ("Vokun Salad"):
                    orderItem = new VokunSalad();
                    break;
            }
        }

        /// <summary>
        /// Initializes all CheckBoxes to have the correct labels and adds them to the SpecificItemCustomization form. This also initializes the 
        /// bindings from the CheckBox to the object.
        /// </summary>
        /// <param name="x">The counter to determine which property corresponds with which CheckBox.</param>
        /// <param name="propertyInfo">This is the propertyInfo from the specific property needed to correspond with the CheckBox.</param>
        public void InitializeCheckBoxes(int x, PropertyInfo propertyInfo)
        {
            checkBoxes[x] = new CheckBox();
            checkBoxes[x].Content = propertyInfo.Name;
            checkBoxes[x].Margin = new Thickness(5);
            customizationsStack.Children.Add(checkBoxes[x]);

            checkBoxBindings[x] = new Binding((string)checkBoxes[x].Content);
            checkBoxBindings[x].Mode = BindingMode.TwoWay;
            checkBoxes[x].SetBinding(CheckBox.IsCheckedProperty, checkBoxBindings[x]);
        }

        /// <summary>
        /// Initializes all ComboBoxes to have the correct item sources and adds them to the SpecificItemCustomization form. This also initializes the 
        /// bindings from the ComboBox to the object.
        /// </summary>
        /// <param name="x">The counter to determine which property corresponds with which ComboBox.</param>
        /// <param name="propertyInfo">This is the propertyInfo from the specific property needed to correspond with the ComboBox.</param>
        public void InitializeComboBoxes(int x, PropertyInfo propertyInfo)
        {
            comboBoxes[x] = new ComboBox();
            comboBoxes[x].ItemsSource = enumOptions[propertyInfo.Name];
            customizationsStack.Children.Add(comboBoxes[x]);

            comboBoxBindings[x] = new Binding(propertyInfo.Name);
            comboBoxBindings[x].Mode = BindingMode.TwoWay;
            comboBoxes[x].SetBinding(ComboBox.SelectedValueProperty, comboBoxBindings[x]);

            // Only way I've found to implement this.
            if (orderItem is Side side)
            {
                comboBoxes[0].SelectedIndex = (int)side.Size;
            }
            else if (orderItem is Drink drink)
            {
                comboBoxes[0].SelectedIndex = (int)drink.Size;
                if (drink is SailorSoda SS && x == 1)
                {
                    comboBoxes[1].SelectedIndex = (int)SS.Flavor;
                }
            }
        }

        /// <summary>
        /// This method simply exits the component. It does so by telling the parent to display the MenuSelectionComponent in its place.
        /// It also enables the orderComponent's itemsListBox so further customization can be achieved.
        /// </summary>
        /// <param name="sender">This is the button labeled "Done".</param>
        /// <param name="e">This is the click.</param>
        public void ExitWindow(object sender, RoutedEventArgs e)
        {
            parentScreen.order.Add(orderItem);
            if (parentScreen.orderComponentBorder.Child is OrderComponent orderComponent)
            {
                orderComponent.itemsListBox.IsEnabled = true;
            }
            parentScreen.ReturnToMenuSelection();
        }

    }
}
