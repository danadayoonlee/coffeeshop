using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib.MenuItemAdditions
{
    public class Sweetener : MenuItemAddition
    {
        public Sweetener()
        {
            Description = "Sweetener";
            BaseCost = 0.06M;
        }
        public Sweetener(MenuItem menuItem) : base(menuItem)
        {
            if (menuItem != null)
            {
                Description = menuItem.Description + ", Sweetener";
                BaseCost = menuItem.BaseCost + 0.06M;
            }
        }
    }
}
