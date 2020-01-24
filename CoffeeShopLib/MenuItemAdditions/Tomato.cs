using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib.MenuItemAdditions
{
    public class Tomato : MenuItemAddition
    {
        public Tomato()
        {
            Description = "Tomato";
            BaseCost = 0.35M;
        }
        public Tomato(MenuItem menuItem) : base(menuItem)
        {
            if (menuItem != null)
            {
                Description = menuItem.Description + ", Tomato";
                BaseCost = menuItem.BaseCost + 0.35M;
            }
        }
    }
}
