using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopLib.MenuItems;

namespace CoffeeShopLib.MenuItemAdditions
{
    public class Suggar : MenuItemAddition
    {
        public Suggar()
        {
            Description = "Sugar";
            BaseCost = 0.05M;
        }
        public Suggar(MenuItem menuItem) : base(menuItem)
        {
            if (menuItem != null)
            {
                Description = menuItem.Description + ", Sugar";
                BaseCost = menuItem.BaseCost + 0.05M;
            }
        }
    }
}
