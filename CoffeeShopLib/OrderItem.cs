using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoffeeShopLib
{
    [Serializable]
    public class OrderItem
    {
        private MenuItem menuItem;
        //Constructor
        public OrderItem(MenuItem item)
        {
            MenuItem = item;
        }
        //Property
        public MenuItem MenuItem
        {
            get { return menuItem; }
            set { menuItem = value; }
        }
        //ToString
        public override string ToString()
        {
            return ($"{MenuItem.Description} - {MenuItem.BaseCost:C}\n");
        }
    }
}