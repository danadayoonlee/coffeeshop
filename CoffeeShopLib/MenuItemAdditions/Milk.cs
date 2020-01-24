using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopLib.MenuItems;

namespace CoffeeShopLib.MenuItemAdditions
{
    public class Milk : MenuItemAddition
    {
        public Milk()
        {
            Description = "milk";
            BaseCost = 0.10M;
        }
        public Milk(MenuItem menuItem) :base(menuItem)
        {
            if (menuItem != null)
            {
                Description = menuItem.Description + ", milk";
                BaseCost = menuItem.BaseCost + 0.10M;
            }
        }
    }
}
