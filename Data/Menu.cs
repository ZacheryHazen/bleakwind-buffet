/*
 * Author: Zach Hazen
 * Class Name: Menu.cs
 * Purpose: Static class used to display all available options to be ordered from the Bleakwind Buffet.
 */


using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using System.Linq;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Class used to represent the menu for Bleakwind Buffet, shows all menu items.
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// List of all possible entree items.
        /// </summary>
        public static IEnumerable<IOrderItem> Entrees
        {
            get
            {
                List<Entree> orderItems = new List<Entree>();
                orderItems.Add(new BriarheartBurger());
                orderItems.Add(new DoubleDraugr());
                orderItems.Add(new GardenOrcOmelette());
                orderItems.Add(new PhillyPoacher());
                orderItems.Add(new SmokehouseSkeleton());
                orderItems.Add(new ThalmorTriple());
                orderItems.Add(new ThugsTBone());
                return orderItems;
            }
        }

        /// <summary>
        /// List of all possible side items including various sizes.
        /// </summary>
        public static IEnumerable<IOrderItem> Sides
        {
            get
            {
                List<IOrderItem> orderItems = new List<IOrderItem>();
                orderItems.Add(new DragonbornWaffleFries());
                orderItems.Add(new DragonbornWaffleFries());
                orderItems.Add(new DragonbornWaffleFries());
                orderItems.Add(new FriedMiraak());
                orderItems.Add(new FriedMiraak());
                orderItems.Add(new FriedMiraak());
                orderItems.Add(new MadOtarGrits());
                orderItems.Add(new MadOtarGrits());
                orderItems.Add(new MadOtarGrits());
                orderItems.Add(new VokunSalad());
                orderItems.Add(new VokunSalad());
                orderItems.Add(new VokunSalad());

                for (int x = 0; x < orderItems.Count; x += 3)
                {
                    ((Side)orderItems[x + 1]).Size = Size.Medium;
                    ((Side)orderItems[x + 2]).Size = Size.Large;
                }
                return orderItems;
            }
        }

        /// <summary>
        /// List of all drink items including various sizes and flavors.
        /// </summary>
        public static IEnumerable<IOrderItem> Drinks
        {
            get
            {
                List<Drink> orderItems = new List<Drink>();
                orderItems.Add(new AretinoAppleJuice());
                orderItems.Add(new AretinoAppleJuice());
                orderItems.Add(new AretinoAppleJuice());
                orderItems.Add(new CandlehearthCoffee());
                orderItems.Add(new CandlehearthCoffee());
                orderItems.Add(new CandlehearthCoffee());
                orderItems.Add(new MarkarthMilk());
                orderItems.Add(new MarkarthMilk());
                orderItems.Add(new MarkarthMilk());
                for (int x = 0; x < 18; x++)
                {
                    orderItems.Add(new SailorSoda());
                }
                orderItems.Add(new WarriorWater());
                orderItems.Add(new WarriorWater());
                orderItems.Add(new WarriorWater());

                for (int x = 0; x < orderItems.Count; x += 3)
                {
                    ((Drink)orderItems[x + 1]).Size = Size.Medium;
                    ((Drink)orderItems[x + 2]).Size = Size.Large;
                }
                ((SailorSoda)orderItems[9]).Flavor = SodaFlavor.Blackberry;
                ((SailorSoda)orderItems[10]).Flavor = SodaFlavor.Blackberry;
                ((SailorSoda)orderItems[11]).Flavor = SodaFlavor.Blackberry;
                ((SailorSoda)orderItems[12]).Flavor = SodaFlavor.Cherry;
                ((SailorSoda)orderItems[13]).Flavor = SodaFlavor.Cherry;
                ((SailorSoda)orderItems[14]).Flavor = SodaFlavor.Cherry;
                ((SailorSoda)orderItems[15]).Flavor = SodaFlavor.Grapefruit;
                ((SailorSoda)orderItems[16]).Flavor = SodaFlavor.Grapefruit;
                ((SailorSoda)orderItems[17]).Flavor = SodaFlavor.Grapefruit;
                ((SailorSoda)orderItems[18]).Flavor = SodaFlavor.Lemon;
                ((SailorSoda)orderItems[19]).Flavor = SodaFlavor.Lemon;
                ((SailorSoda)orderItems[20]).Flavor = SodaFlavor.Lemon;
                ((SailorSoda)orderItems[21]).Flavor = SodaFlavor.Peach;
                ((SailorSoda)orderItems[22]).Flavor = SodaFlavor.Peach;
                ((SailorSoda)orderItems[23]).Flavor = SodaFlavor.Peach;
                ((SailorSoda)orderItems[24]).Flavor = SodaFlavor.Watermelon;
                ((SailorSoda)orderItems[25]).Flavor = SodaFlavor.Watermelon;
                ((SailorSoda)orderItems[26]).Flavor = SodaFlavor.Watermelon;

                return orderItems;
            }
        }

        /// <summary>
        /// List of possible menu items (entrees, sides, and drinks) including sizes and flavors.
        /// </summary>
        public static IEnumerable<IOrderItem> All
        {
            get
            {
                List<IOrderItem> orderItems = new List<IOrderItem>();
                // Adding entrees first
                orderItems.AddRange(Entrees);

                // Adding all side items
                orderItems.AddRange(Sides);

                // Adding all drink items
                orderItems.AddRange(Drinks);

                return orderItems;
            }
        }

        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> orderItems, string text)
        { 
            if (text == null)
            {
                return orderItems;
            }

            List<IOrderItem> filteredItems = new List<IOrderItem>();
            foreach (IOrderItem orderItem in orderItems)
            {
                if (orderItem.ToString().ToLower().Contains(text.ToLower()))
                {
                    filteredItems.Add(orderItem);
                }  
            }

            return filteredItems;
        }

        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> orderItems, IEnumerable<string> categories)
        {
            if (categories == null || categories.Count() == 0)
            {
                return orderItems;
            }

            List<IOrderItem> filteredItems = new List<IOrderItem>();
            foreach (IOrderItem orderItem in orderItems)
            {
                if (categories.Contains("Entrees") && orderItem is Entree)
                {
                    filteredItems.Add(orderItem);
                }
                else if (categories.Contains("Sides") && orderItem is Side)
                {
                    filteredItems.Add(orderItem);
                }
                else if (categories.Contains("Drinks") && orderItem is Drink)
                {
                    filteredItems.Add(orderItem);
                }
            }

            return filteredItems;
        }

        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> orderItems, int? min, int? max)
        {
            if (min == null && max == null)
            {
                return orderItems;
            }

            List<IOrderItem> filteredItems = new List<IOrderItem>();

            if (min == null)
            {
                foreach(IOrderItem orderItem in orderItems)
                {
                    if (orderItem.Calories <= max)
                    {
                        filteredItems.Add(orderItem);
                    }
                }
            }
            else if (max == null)
            {
                foreach (IOrderItem orderItem in orderItems)
                {
                    if (orderItem.Calories >= min)
                    {
                        filteredItems.Add(orderItem);
                    }
                }
            }
            else
            {
                foreach(IOrderItem orderItem in orderItems)
                {
                    if (orderItem.Calories >= min && orderItem.Calories <= max)
                    {
                        filteredItems.Add(orderItem);
                    }
                }
            }

            return filteredItems;
        }

        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> orderItems, double? min, double? max)
        {
            if (min == null && max == null)
            {
                return orderItems;
            }

            List<IOrderItem> filteredItems = new List<IOrderItem>();

            if (min == null)
            {
                foreach (IOrderItem orderItem in orderItems)
                {
                    if (orderItem.Price <= max)
                    {
                        filteredItems.Add(orderItem);
                    }
                }
            }
            else if (max == null)
            {
                foreach (IOrderItem orderItem in orderItems)
                {
                    if (orderItem.Price >= min)
                    {
                        filteredItems.Add(orderItem);
                    }
                }
            }
            else
            {
                foreach (IOrderItem orderItem in orderItems)
                {
                    if (orderItem.Price >= min && orderItem.Price <= max)
                    {
                        filteredItems.Add(orderItem);
                    }
                }
            }

            return filteredItems;
        }
    }
}
