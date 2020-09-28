/** Author: Zach Hazen
 *  Class Name: SpecificItemCustomization.xaml.cs
 *  Purpose: The other half of the MainWindow class. This class is used to display all customizable options for a supplied menu item.
 */

using System;
using System.Collections.Generic;
using System.Printing;
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
        public Dictionary<string, string[]> customizationCheckmarks = new Dictionary<string, string[]>();

        public Dictionary<string, Dictionary<string, string[]>> customizationDropdowns = new Dictionary<string, Dictionary<string, string[]>>();

        public MainWindow parentScreen;

        public string name;

        /// <summary>
        /// Initializes the SpecificItemCustomization form. It also initializes the dictionaries the class uses to determine
        /// what customization options an item has. Lastly, this method displays the customization options to the user.
        /// </summary>
        /// <param name="parent">This is the parent form, usually MainWindow. Needed to exit form.</param>
        /// <param name="itemName">This is the name of the item that needs customization.</param>
        public SpecificItemCustomization(MainWindow parent, string itemName)
        {
            InitializeComponent();
            InitializeDictionaries();
            name = itemName;
            parentScreen = parent;
            CreateCustomizationOptions();
        }

        /// <summary>
        /// This method arduously lists every customizable feature of the item passed to the class' initialization.
        /// customizationCheckmarks is every option that is displayed via a checkbox while customizationDropdowns is every option that is displayed via a ComboBox.
        /// </summary>
        public void InitializeDictionaries()
        {
            customizationCheckmarks.Add("Briarheart Burger", new string[] { "Bun", "Ketchup", "Mustard", "Pickle", "Cheese"});
            customizationCheckmarks.Add("Double Draugr", new string[] { "Bun", "Ketchup", "Mustard", "Pickle", "Cheese", "Tomato", "Lettuce", "Mayo" });
            customizationCheckmarks.Add("Garden Orc Omelette", new string[] { "Broccoli", "Mushrooms", "Tomato", "Cheddar" });
            customizationCheckmarks.Add("Philly Poacher", new string[] { "Sirloin", "Onion", "Roll" });
            customizationCheckmarks.Add("Smokehouse Skeleton", new string[] { "Sausage link", "Egg", "Hashbrowns", "Pancake" });
            customizationCheckmarks.Add("Thalmor Triple", new string[] { "Bun", "Ketchup", "Mustard", "Pickle", "Cheese", "Tomato", "Lettuce", "Mayo", "Bacon", "Egg" });

            customizationCheckmarks.Add("Aretino Apple Juice", new string[] { "Ice" });
            customizationCheckmarks.Add("Candlehearth Coffee", new string[] { "Ice", "Decaf", "Room for Cream" });
            customizationCheckmarks.Add("Markarth Milk", new string[] { "Ice" });
            customizationCheckmarks.Add("Sailor Soda", new string[] { "Ice" });
            customizationCheckmarks.Add("Warrior Water", new string[] { "Ice", "Lemon" });

            Dictionary<string, string[]> sizeDictionary = new Dictionary<string, string[]>();
            sizeDictionary.Add("Size", new string[] { "Small", "Medium", "Large" });

            customizationDropdowns.Add("Dragonborn Waffle Fries", sizeDictionary);
            customizationDropdowns.Add("Fried Miraak", sizeDictionary);
            customizationDropdowns.Add("Mad Otar Grits", sizeDictionary);
            customizationDropdowns.Add("Vokun Salad", sizeDictionary);

            customizationDropdowns.Add("Aretino Apple Juice", sizeDictionary);
            customizationDropdowns.Add("Candlehearth Coffee", sizeDictionary);
            customizationDropdowns.Add("Markarth Milk", sizeDictionary);
            customizationDropdowns.Add("Warrior Water", sizeDictionary);

            Dictionary<string, string[]> sizeAndFlavorDictionary = new Dictionary<string, string[]>();
            sizeAndFlavorDictionary.Add("Size", new string[] { "Small", "Medium", "Large" });
            sizeAndFlavorDictionary.Add("Flavor", new string[] { "Blackberry", "Cherry", "Grapefruit", "Lemon", "Peach", "Watermelon" });

            customizationDropdowns.Add("Sailor Soda", sizeAndFlavorDictionary);
        }

        /// <summary>
        /// This method displays all the CheckBoxes and ComboBoxes needed to customize an order item.
        /// It does so via the dictionaries initialized in InitializeDictionaries. If no definitions are found for 
        /// the order item's name, it displays "No customization options.".
        /// </summary>
        public void CreateCustomizationOptions()
        {
            CheckBox[] checkBoxes;
            ComboBox[] dropdowns;
            if (!customizationCheckmarks.ContainsKey(name) && !customizationDropdowns.ContainsKey(name))
            {
                TextBlock TB = new TextBlock();
                TB.Text = "No customization options.";
                customizationsStack.Children.Add(TB);
            }
            else
            {
                if (customizationCheckmarks.ContainsKey(name))
                {
                    
                    string[] checkmarkOptions = customizationCheckmarks[name];
                    checkBoxes = new CheckBox[checkmarkOptions.Length];
                    for (int x = 0; x < checkmarkOptions.Length; x++)
                    {
                        checkBoxes[x] = new CheckBox();
                        checkBoxes[x].Content = checkmarkOptions[x];

                        checkBoxes[x].Margin = new Thickness(5);
                        customizationsStack.Children.Add(checkBoxes[x]);
                    }
                }
                if (customizationDropdowns.ContainsKey(name))
                {
                    Dictionary<string, string[]> dropdownOptions = customizationDropdowns[name];
                    dropdowns = new ComboBox[dropdownOptions.Count];
                    if (dropdownOptions.ContainsKey("Size"))
                    {
                        dropdowns[0] = new ComboBox();
                        dropdowns[0].ItemsSource = dropdownOptions["Size"];
                        dropdowns[0].SelectedIndex = 0;
                        dropdowns[0].Padding = new Thickness(10);
                        customizationsStack.Children.Add(dropdowns[0]);
                    }
                    if (dropdownOptions.ContainsKey("Flavor"))
                    {
                        dropdowns[1] = new ComboBox();
                        dropdowns[1].ItemsSource = dropdownOptions["Flavor"];
                        dropdowns[1].SelectedIndex = 0;
                        dropdowns[1].Padding = new Thickness(10);
                        customizationsStack.Children.Add(dropdowns[1]);
                    }
                }
            }
        }
        /// <summary>
        /// This method simply exits the component. It does so by telling the parent to display the MenuSelectionComponent in its place.
        /// </summary>
        /// <param name="sender">This is the button labeled "Done".</param>
        /// <param name="e">This is the click.</param>
        public void ExitWindow(object sender, RoutedEventArgs e)
        {
            parentScreen.ReturnToMenuSelection();
        }

    }
}
