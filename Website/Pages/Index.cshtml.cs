/** Author: Zach Hazen
 *  Class Name: Index.cshtml.cs
 *  Purpose: The other half of the Index.cshtml, data binds all properties to be used when filtering the order items on Index.cshtml.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using BleakwindBuffet.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    /// <summary>
    /// Works with Index.cshtml to provide accurate order items as well as facilitate filtering.
    /// </summary>
    public class IndexModel : PageModel
    {
        /// <summary>
        /// List of all types of order items to be used for checkbox selections.
        /// </summary>
        public string[] ItemTypeOptions
        {
            get => new string[]
            {
                "Entrees",
                "Sides",
                "Drinks"
            };
        }
        /// <summary>
        /// Holds all filtered IOrderItems needed for the Index.cshtml page.
        /// </summary>
        [BindProperty (SupportsGet = false)]
        public IEnumerable<IOrderItem> OrderItems { get; set; }

        /// <summary>
        /// Holds any potential text query provided by the .cshtml page.
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string TextSearch { get; set; }

        /// <summary>
        /// Holds checkbox selections on which order item type should be shown.
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string[] ItemTypes { get; set; } = new string[0];

        /// <summary>
        /// Holds the minimum amount of calories to be shown in the filtered items selection. 
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public int? CaloriesMin { get; set; }

        /// <summary>
        /// Holds the maximum amount of calories to be shown in the filtered items selection. 
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public int? CaloriesMax { get; set; }

        /// <summary>
        /// Holds the minimum price to be shown in the filtered items selection. 
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? PriceMin { get; set; }

        /// <summary>
        /// Holds the maximum price to be shown in the filtered items selection. 
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? PriceMax { get; set; }

        /// <summary>
        /// This method should run whenever the page is acccessed via URL, and it should parse through 
        /// the URL to retrieve the appropriate parameters to filter OrderItems and display the correct possible order items.
        /// </summary>
        public void OnGet()
        {
            OrderItems = Menu.Search(Menu.All, TextSearch);

            OrderItems = Menu.FilterByCategory(OrderItems, ItemTypes);

            OrderItems = Menu.FilterByCalories(OrderItems, CaloriesMin, CaloriesMax);

            OrderItems = Menu.FilterByPrice(OrderItems, PriceMin, PriceMax);
        }
    }
}
