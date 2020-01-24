using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib.MenuItemAdditions
{
    public class Cheese : MenuItemAddition
    {
        public Cheese()
        {
            Description = "Cheese";
            BaseCost = 0.40M;
        }
        public Cheese(MenuItem menuItem) : base(menuItem)
        {
            if (menuItem != null)
            {
                Description = menuItem.Description + ", Cheese";
                BaseCost = menuItem.BaseCost + 0.40M;
            }
        }
    }
}
