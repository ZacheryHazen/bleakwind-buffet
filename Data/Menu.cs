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

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Class used to represent the menu for Bleakwind Buffet, shows all menu items.
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Method used to return all possible entree items.
        /// </summary>
        /// <returns>List of all entree items.</returns>
        public static IEnumerable<Entree> Entrees()
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

        /// <summary>
        /// Method used to return all possible side items including various sizes.
        /// </summary>
        /// <returns>A list containing all side items factoring in sizes.</returns>
        public static IEnumerable<Side> Sides()
        {
            List<Side> orderItems = new List<Side>();
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

        /// <summary>
        /// Method used to return all drink items including various sizes and flavors.
        /// </summary>
        /// <returns>List of all possible drink items factoring in sizes and flavors.</returns>
        public static IEnumerable<Drink> Drinks()
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

        /// <summary>
        /// Method used to return all possible menu items (entrees, sides, and drinks) including sizes and flavors.
        /// </summary>
        /// <returns>A list containing all possible entrees, items, and drinks with different items for each size and flavor combination.</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> orderItems = new List<IOrderItem>();
            // Adding drinks first
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

            for (int x = 0; x < orderItems.Count; x += 3)
            {
                ((Drink)orderItems[x + 1]).Size = Size.Medium;
                ((Drink)orderItems[x + 2]).Size = Size.Large;
            }

            // Adding all side items
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

            for (int x = 30; x < orderItems.Count; x += 3)
            {
                ((Side)orderItems[x + 1]).Size = Size.Medium;
                ((Side)orderItems[x + 2]).Size = Size.Large;
            }

            // Adding all entree items
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
}
