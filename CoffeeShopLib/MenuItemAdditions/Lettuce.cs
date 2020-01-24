using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib.MenuItemAdditions
{
    public class Lettuce : MenuItemAddition
    {
        public Lettuce()
        {
            Description = "Lettuce";
            BaseCost = 0.30M;
        }
        public Lettuce(MenuItem menuItem) : base(menuItem)
        {
            if (menuItem != null)
            {
                Description = menuItem.Description + ", Lettuce";
                BaseCost = menuItem.BaseCost + 0.30M;
            }
        }
    }
}
