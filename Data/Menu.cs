/*
 * Author: Zach Hazen
 * Class Name: Menu.cs
 * Purpose: Static class used to display all available options to be ordered from the Bleakwind Buffet as well as filter items based on certain parameters.
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
    /// Class used to represent the menu for Bleakwind Buffet, shows all menu items and filters items through a variety of methods.
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

        /// <summary>
        /// This method sorts through a given IEnumerable of IOrderItems and searches through their ToStrings for a case-insensitive text query.
        /// </summary>
        /// <param name="orderItems">This is the IEnumerable being searched through.</param>
        /// <param name="text">This is the text query used to match against the ToStrings.</param>
        /// <returns>This is the filtered list of IOrderItems.</returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> orderItems, string text)
        { 
            if (text != null)
            {
                List<IOrderItem> filteredItems = new List<IOrderItem>();
                string[] searchTerms = text.Split(' ');

                foreach (string term in searchTerms)
                {
                    List<IOrderItem> newTerms = orderItems.Where(orderItem => (orderItem.ToString().ToLower().Contains(term.ToLower()) || orderItem.Description.ToLower().Contains(term.ToLower()))).ToList();
                    foreach(IOrderItem newItem in newTerms)
                    {
                        if (!filteredItems.Contains(newItem))
                        {
                            filteredItems.Add(newItem);
                        }
                    }
                }
                return filteredItems;
            }

            return orderItems;
        }

        /// <summary>
        /// This method sorts through a given IEnumerable of IOrderItems and searches through each IOrderItem's type to match against the categories supplied.
        /// </summary>
        /// <param name="orderItems">This is the IEnumerable of IOrderItems to be searched through.</param>
        /// <param name="categories">This is the categories that should be matched against the order items.</param>
        /// <returns>This is the filtered list of IOrderItems.</returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> orderItems, IEnumerable<string> categories)
        {
            if (categories == null || categories.Count() == 0)
            {
                return orderItems;
            }

            List<IOrderItem> filteredItems = new List<IOrderItem>();

            filteredItems = orderItems.Where(orderItem => ((orderItem is Entree && categories.Contains("Entrees")) || (orderItem is Side && categories.Contains("Sides")) || (orderItem is Drink && categories.Contains("Drinks")))).ToList();

            return filteredItems;
        }

        /// <summary>
        /// This method sorts through a given IEnumerable of IOrderItems and determines which order items fall within a range of calories.
        /// If a minimum or maximum are left as null, it's treated as negative infinity or infinity respectively.
        /// </summary>
        /// <param name="orderItems">This is the IEnumerable of IOrderItems to be searched through.</param>
        /// <param name="min">This is the minimum amount of calories allowed.</param>
        /// <param name="max">This is the maximum amount of calories allowed.</param>
        /// <returns>This is the filtered list of IOrderItems.</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> orderItems, int? min, int? max)
        {
            if (min != null || max != null)
            {
                List<IOrderItem> filteredItems = new List<IOrderItem>();

                if (min == null)
                {
                    filteredItems = orderItems.Where(orderItem => orderItem.Calories <= max).ToList();
                }
                else if (max == null)
                {
                    filteredItems = orderItems.Where(orderItem => orderItem.Calories >= min).ToList();
                }
                else
                {
                    filteredItems = orderItems.Where(orderItem => (orderItem.Calories >= min && orderItem.Calories <= max)).ToList();
                }

                return filteredItems;
            }

            return orderItems;
        }

        /// <summary>
        /// This method sorts through a given IEnumerable of IOrderItems and determines which order items fall within a price range.
        /// If a minimum or maximum are left as null, it's treated as negative infinity or infinity respectively.
        /// </summary>
        /// <param name="orderItems">This is the IEnumerable of IOrderItems to be searched through.</param>
        /// <param name="min">This is the minimum price allowed.</param>
        /// <param name="max">This is the maximum price allowed.</param>
        /// <returns>This is the filtered list of IOrderItems.</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> orderItems, double? min, double? max)
        {
            if (min != null || max != null)
            {
                List<IOrderItem> filteredItems = new List<IOrderItem>();

                if (min == null)
                {
                    filteredItems = orderItems.Where(orderItem => orderItem.Price <= max).ToList();
                }
                else if (max == null)
                {
                    filteredItems = orderItems.Where(orderItem => orderItem.Price >= min).ToList();
                }
                else
                {
                    filteredItems = orderItems.Where(orderItem => (orderItem.Price >= min && orderItem.Price <= max)).ToList();
                }

                return filteredItems;
            }

            return orderItems;
        }
    }
}
