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

        IOrderItem orderItem;

        CheckBox[] checkBoxes;
        ComboBox[] comboBoxes;

        /// <summary>
        /// Initializes the SpecificItemCustomization form. It also initializes the dictionaries the class uses to determine
        /// what customization options an item has. Lastly, this method displays the customization options to the user. It also initializes the checkboxes and combo boxes.
        /// </summary>
        /// <param name="parent">This is the parent form, usually MainWindow. Needed to exit form.</param>
        /// <param name="itemName">This is the name of the item that needs customization.</param>
        public SpecificItemCustomization(MainWindow parent, string itemName)
        {
            InitializeComponent();
            InitializeDictionaries();
            name = itemName;
            parentScreen = parent;
            CreateOrderItem(name);
            CreateCustomizationOptions();
            InitializeCheckBoxes();
            InitializeComboBoxes();
            this.DataContext = orderItem;
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
                case ("Dragonbown Waffle Fries"):
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
                        checkBoxes[x].Click += ChangeCheckBoxProperty;
                        customizationsStack.Children.Add(checkBoxes[x]);
                    }
                }
                if (customizationDropdowns.ContainsKey(name))
                {
                    Dictionary<string, string[]> dropdownOptions = customizationDropdowns[name];
                    comboBoxes = new ComboBox[dropdownOptions.Count];
                    if (dropdownOptions.ContainsKey("Size"))
                    {
                        comboBoxes[0] = new ComboBox();
                        comboBoxes[0].ItemsSource = dropdownOptions["Size"];
                        comboBoxes[0].SelectedIndex = 0;
                        comboBoxes[0].Padding = new Thickness(10);
                        comboBoxes[0].SelectionChanged += ChangeComboBoxProperty;
                        customizationsStack.Children.Add(comboBoxes[0]);
                    }
                    if (dropdownOptions.ContainsKey("Flavor"))
                    {
                        comboBoxes[1] = new ComboBox();
                        comboBoxes[1].ItemsSource = dropdownOptions["Flavor"];
                        comboBoxes[1].SelectedIndex = 0;
                        comboBoxes[1].Padding = new Thickness(10);                        
                        customizationsStack.Children.Add(comboBoxes[1]);
                    }
                }
            }
        }

        /// <summary>
        /// Initializes all checkboxes to have the correct default values from the initialized object.
        /// </summary>
        public void InitializeCheckBoxes()
        {
            if (orderItem is Entree entree)
            {
                if (entree is BriarheartBurger BB)
                {
                    checkBoxes[0].IsChecked = BB.Bun;
                    checkBoxes[1].IsChecked = BB.Ketchup;
                    checkBoxes[2].IsChecked = BB.Mustard;
                    checkBoxes[3].IsChecked = BB.Pickle;
                    checkBoxes[4].IsChecked = BB.Cheese;
                }
                else if (entree is DoubleDraugr DD)
                {
                    checkBoxes[0].IsChecked = DD.Bun;
                    checkBoxes[1].IsChecked = DD.Ketchup;
                    checkBoxes[2].IsChecked = DD.Mustard;
                    checkBoxes[3].IsChecked = DD.Pickle;
                    checkBoxes[4].IsChecked = DD.Cheese;
                    checkBoxes[5].IsChecked = DD.Tomato;
                    checkBoxes[6].IsChecked = DD.Lettuce;
                    checkBoxes[7].IsChecked = DD.Mayo;
                }
                else if (entree is GardenOrcOmelette GOO)
                {
                    checkBoxes[0].IsChecked = GOO.Broccoli;
                    checkBoxes[1].IsChecked = GOO.Mushrooms;
                    checkBoxes[2].IsChecked = GOO.Tomato;
                    checkBoxes[3].IsChecked = GOO.Cheddar;
                }
                else if (entree is PhillyPoacher PP)
                {
                    checkBoxes[0].IsChecked = PP.Sirloin;
                    checkBoxes[1].IsChecked = PP.Onion;
                    checkBoxes[2].IsChecked = PP.Roll;
                }
                else if (entree is SmokehouseSkeleton SS)
                {
                    checkBoxes[0].IsChecked = SS.SausageLink;
                    checkBoxes[1].IsChecked = SS.Egg;
                    checkBoxes[2].IsChecked = SS.HashBrowns;
                    checkBoxes[3].IsChecked = SS.Pancake;
                }
                else if (entree is ThalmorTriple TT)
                {
                    checkBoxes[0].IsChecked = TT.Bun;
                    checkBoxes[1].IsChecked = TT.Ketchup;
                    checkBoxes[2].IsChecked = TT.Mustard;
                    checkBoxes[3].IsChecked = TT.Pickle;
                    checkBoxes[4].IsChecked = TT.Cheese;
                    checkBoxes[5].IsChecked = TT.Tomato;
                    checkBoxes[6].IsChecked = TT.Lettuce;
                    checkBoxes[7].IsChecked = TT.Mayo;
                    checkBoxes[8].IsChecked = TT.Bacon;
                    checkBoxes[9].IsChecked = TT.Egg;
                }
            }
            else if (orderItem is Drink drink)
            {
                if(drink is AretinoAppleJuice AAJ)
                {
                    checkBoxes[0].IsChecked = AAJ.Ice;
                }
                else if (drink is CandlehearthCoffee CC)
                {
                    checkBoxes[0].IsChecked = CC.Ice;
                    checkBoxes[1].IsChecked = CC.Decaf;
                    checkBoxes[2].IsChecked = CC.RoomForCream;
                }
                else if (drink is MarkarthMilk MM)
                {
                    checkBoxes[0].IsChecked = MM.Ice;
                }
                else if (drink is SailorSoda SS)
                {
                    checkBoxes[0].IsChecked = SS.Ice;
                }
                else if (drink is WarriorWater WW)
                {
                    checkBoxes[0].IsChecked = WW.Ice;
                    checkBoxes[1].IsChecked = WW.Lemon;
                }
            }
        }

        /// <summary>
        /// Initializes all combo boxes to have the correct default values from the initialized object.
        /// </summary>
        public void InitializeComboBoxes()
        {
            if (orderItem is Side side)
            {
                if (side is DragonbornWaffleFries DWF)
                {
                    comboBoxes[0].SelectedIndex = (int)DWF.Size;
                }
                else if (side is FriedMiraak FM)
                {
                    comboBoxes[0].SelectedIndex = (int)FM.Size;
                }
                else if (side is MadOtarGrits MOG)
                {
                    comboBoxes[0].SelectedIndex = (int)MOG.Size;
                }
                else if (side is VokunSalad VS)
                {
                    comboBoxes[0].SelectedIndex = (int)VS.Size;
                }
            }
            else if (orderItem is Drink drink)
            {
                if (drink is AretinoAppleJuice AAJ)
                {
                    comboBoxes[0].SelectedIndex = (int)AAJ.Size;
                }
                else if (drink is CandlehearthCoffee CC)
                {
                    comboBoxes[0].SelectedIndex = (int)CC.Size;
                }
                else if (drink is MarkarthMilk MM)
                {
                    comboBoxes[0].SelectedIndex = (int)MM.Size;
                }
                else if (drink is SailorSoda SS)
                {
                    comboBoxes[0].SelectedIndex = (int)SS.Size;
                    comboBoxes[1].SelectedIndex = (int)SS.Flavor;
                }
                else if (drink is WarriorWater WW)
                {
                    comboBoxes[0].SelectedIndex = (int)WW.Size;
                }
            }
        }

        /// <summary>
        /// This method handles the interaction between the orderItem's properties and the checkBoxes. It does so by 
        /// determining which class the object is and then checking which checkBox is interacted with.
        /// </summary>
        /// <param name="sender">This is the checkBox that was interacted with.</param>
        /// <param name="e">This is the click.</param>
        public void ChangeCheckBoxProperty(object sender, RoutedEventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (orderItem is Entree entree)
                {
                    if (entree is BriarheartBurger BB)
                    {
                        switch (checkBox.Content)
                        {
                            case ("Bun"):
                                BB.Bun = (bool)checkBox.IsChecked;
                                break;
                            case ("Ketchup"):
                                BB.Ketchup = (bool)checkBox.IsChecked;
                                break;
                            case ("Mustard"):
                                BB.Mustard = (bool)checkBox.IsChecked;
                                break;
                            case ("Pickle"):
                                BB.Pickle = (bool)checkBox.IsChecked;
                                break;
                            case ("Cheese"):
                                BB.Cheese = (bool)checkBox.IsChecked;
                                break;
                        }
                    }
                    else if (entree is DoubleDraugr DD)
                    {
                        switch (checkBox.Content)
                        {
                            case ("Bun"):
                                DD.Bun = (bool)checkBox.IsChecked;
                                break;
                            case ("Ketchup"):
                                DD.Ketchup = (bool)checkBox.IsChecked;
                                break;
                            case ("Mustard"):
                                DD.Mustard = (bool)checkBox.IsChecked;
                                break;
                            case ("Pickle"):
                                DD.Pickle = (bool)checkBox.IsChecked;
                                break;
                            case ("Cheese"):
                                DD.Cheese = (bool)checkBox.IsChecked;
                                break;
                            case ("Tomato"):
                                DD.Tomato = (bool)checkBox.IsChecked;
                                break;
                            case ("Lettuce"):
                                DD.Lettuce = (bool)checkBox.IsChecked;
                                break;
                            case ("Mayo"):
                                DD.Mayo = (bool)checkBox.IsChecked;
                                break;
                        }
                    }
                    else if (entree is GardenOrcOmelette GOO)
                    {
                        switch (checkBox.Content)
                        {
                            case ("Broccoli"):
                                GOO.Broccoli = (bool)checkBox.IsChecked;
                                break;
                            case ("Mushrooms"):
                                GOO.Mushrooms = (bool)checkBox.IsChecked;
                                break;
                            case ("Tomato"):
                                GOO.Tomato = (bool)checkBox.IsChecked;
                                break;
                            case ("Cheddar"):
                                GOO.Cheddar = (bool)checkBox.IsChecked;
                                break;
                        }
                    }
                    else if (entree is PhillyPoacher PP)
                    {
                        switch (checkBox.Content)
                        {
                            case ("Sirloin"):
                                PP.Sirloin = (bool)checkBox.IsChecked;
                                break;
                            case ("Onion"):
                                PP.Onion = (bool)checkBox.IsChecked;
                                break;
                            case ("Roll"):
                                PP.Roll = (bool)checkBox.IsChecked;
                                break;
                        }
                    }
                    else if (entree is SmokehouseSkeleton SS)
                    {
                        switch (checkBox.Content)
                        {
                            case ("Sausage Link"):
                                SS.SausageLink = (bool)checkBox.IsChecked;
                                break;
                            case ("Egg"):
                                SS.Egg = (bool)checkBox.IsChecked;
                                break;
                            case ("Hashbrowns"):
                                SS.HashBrowns = (bool)checkBox.IsChecked;
                                break;
                        }
                    }
                    else if (entree is ThalmorTriple TT)
                    {
                        switch (checkBox.Content)
                        {
                            case ("Bun"):
                                TT.Bun = (bool)checkBox.IsChecked;
                                break;
                            case ("Ketchup"):
                                TT.Ketchup = (bool)checkBox.IsChecked;
                                break;
                            case ("Mustard"):
                                TT.Mustard = (bool)checkBox.IsChecked;
                                break;
                            case ("Pickle"):
                                TT.Pickle = (bool)checkBox.IsChecked;
                                break;
                            case ("Cheese"):
                                TT.Cheese = (bool)checkBox.IsChecked;
                                break;
                            case ("Tomato"):
                                TT.Tomato = (bool)checkBox.IsChecked;
                                break;
                            case ("Lettuce"):
                                TT.Lettuce = (bool)checkBox.IsChecked;
                                break;
                            case ("Mayo"):
                                TT.Mayo = (bool)checkBox.IsChecked;
                                break;
                        }
                    }
                }
                else if (orderItem is Drink drink)
                {
                    if (drink is AretinoAppleJuice AAJ)
                    {
                        switch(checkBox.Content)
                        {
                            case ("Ice"):
                                AAJ.Ice = (bool)checkBox.IsChecked;
                                break;
                        }
                    }
                    else if (drink is CandlehearthCoffee CC)
                    {
                        switch (checkBox.Content)
                        {
                            case ("Ice"):
                                CC.Ice = (bool)checkBox.IsChecked;
                                break;
                            case ("Decaf"):
                                CC.Decaf = (bool)checkBox.IsChecked;
                                break;
                            case ("Room for Cream"):
                                CC.Ice = (bool)checkBox.IsChecked;
                                break;
                        }
                    }
                    else if (drink is MarkarthMilk MM)
                    {
                        switch (checkBox.Content)
                        {
                            case ("Ice"):
                                MM.Ice = (bool)checkBox.IsChecked;
                                break;
                        }
                    }
                    else if (drink is SailorSoda SS)
                    {
                        switch (checkBox.Content)
                        {
                            case ("Ice"):
                                SS.Ice = (bool)checkBox.IsChecked;
                                break;
                        }
                    }
                    else if (drink is WarriorWater WW)
                    {
                        switch (checkBox.Content)
                        {
                            case ("Ice"):
                                WW.Ice = (bool)checkBox.IsChecked;
                                break;
                            case ("Lemon"):
                                WW.Lemon = (bool)checkBox.IsChecked;
                                break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// This method handles the interaction between the orderItem's properties and the comboBoxes. It does so by 
        /// determining which class the object is and then checking which ComboBox is interacted with, and finally determining which option is selected in the ComboBox.
        /// </summary>
        /// <param name="sender">This is the ComboBox that was interacted with.</param>
        /// <param name="e">This is the selection.</param>
        public void ChangeComboBoxProperty(object sender, RoutedEventArgs e)
        {
            if (sender is ComboBox comboBox)
            {
                if (orderItem is Side side)
                {
                    if (side is DragonbornWaffleFries DWF)
                    {
                        if (comboBox.Equals(comboBoxes[0]))
                        {
                            DWF.Size = (BleakwindBuffet.Data.Enums.Size)comboBox.SelectedIndex;
                        }
                    }
                    else if (side is FriedMiraak FM)
                    {
                        if (comboBox.Equals(comboBoxes[0]))
                        {
                            FM.Size = (BleakwindBuffet.Data.Enums.Size)comboBox.SelectedIndex;
                        }
                    }
                    else if (side is MadOtarGrits MOG)
                    {
                        if (comboBox.Equals(comboBoxes[0]))
                        {
                             MOG.Size = (BleakwindBuffet.Data.Enums.Size)comboBox.SelectedIndex;
                        }
                    }
                    else if (side is VokunSalad VS)
                    {
                        if (comboBox.Equals(comboBoxes[0]))
                        {
                            VS.Size = (BleakwindBuffet.Data.Enums.Size)comboBox.SelectedIndex;
                        }
                    }
                }
                else if (orderItem is Drink drink)
                {
                    if (drink is AretinoAppleJuice AAJ)
                    {
                        if (comboBox.Equals(comboBoxes[0]))
                        {
                            AAJ.Size = (BleakwindBuffet.Data.Enums.Size)comboBox.SelectedIndex;
                        }
                    }
                    else if (drink is CandlehearthCoffee CC)
                    {
                        if (comboBox.Equals(comboBoxes[0]))
                        {
                            CC.Size = (BleakwindBuffet.Data.Enums.Size)comboBox.SelectedIndex;
                        }
                    }
                    else if (drink is MarkarthMilk MM)
                    {
                        if (comboBox.Equals(comboBoxes[0]))
                        {
                            MM.Size = (BleakwindBuffet.Data.Enums.Size)comboBox.SelectedIndex;
                        }
                    }
                    else if (drink is SailorSoda SS)
                    {
                        if (comboBox.Equals(comboBoxes[0]))
                        {
                            SS.Size = (BleakwindBuffet.Data.Enums.Size)comboBox.SelectedIndex;
                        }
                        else if (comboBox.Equals(comboBoxes[1]))
                        {
                            SS.Flavor = (BleakwindBuffet.Data.Enums.SodaFlavor)comboBox.SelectedIndex;
                        }
                    }
                    else if (drink is WarriorWater WW)
                    {
                        if (comboBox.Equals(comboBoxes[0]))
                        {
                            WW.Size = (BleakwindBuffet.Data.Enums.Size)comboBox.SelectedIndex;
                        }
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
