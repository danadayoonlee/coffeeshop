using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib.MenuItemAdditions
{
    public class Mayo : MenuItemAddition
    {
        public Mayo()
        {
            Description = "Mayo";
            BaseCost = 0M;
        }
        public Mayo(MenuItem menuItem) : base(menuItem)
        {
            if (menuItem != null)
            {
                Description = menuItem.Description + ", Mayo";
                BaseCost = menuItem.BaseCost + 0M;
            }
        }
    }
}
