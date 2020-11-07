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
    public class IndexModel : PageModel
    {
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
        /// Holds all IOrderItems needed for the 
        /// </summary>
        [BindProperty (SupportsGet = false)]
        public IEnumerable<IOrderItem> OrderItems { get; set; }

        [BindProperty(SupportsGet = true)]
        public string TextSearch { get; set; }

        [BindProperty(SupportsGet = true)]
        public string[] ItemTypes { get; set; } = new string[0];

        [BindProperty(SupportsGet = true)]
        public int? CaloriesMin { get; set; }

        [BindProperty(SupportsGet = true)]
        public int? CaloriesMax { get; set; }
        
        [BindProperty(SupportsGet = true)]
        public double? PriceMin { get; set; }

        [BindProperty(SupportsGet = true)]
        public double? PriceMax { get; set; }

        public void OnGet()
        {
            OrderItems = Menu.Search(Menu.All, TextSearch);

            OrderItems = Menu.FilterByCategory(OrderItems, ItemTypes);

            OrderItems = Menu.FilterByCalories(OrderItems, CaloriesMin, CaloriesMax);

            OrderItems = Menu.FilterByPrice(OrderItems, PriceMin, PriceMax);
        }
    }
}
