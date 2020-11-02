/** Author: Zach Hazen
 *  Class Name: OrderItemsList.cs
 *  Purpose: Works with the Menu class in the Data namespace to supply a list of entrees, drinks, and sides to the Website namespace.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BleakwindBuffet.Data;


namespace Website
{
    public static class OrderItemsList
    {
        public static List<Entree> entreeItems;
        public static List<Drink> drinkItems;
        public static List<Side> sideItems;

        static OrderItemsList()
        {
            entreeItems = Menu.Entrees().ToList();
            drinkItems = Menu.Drinks().ToList();
            sideItems = Menu.Sides().ToList();
        }
    }
}
