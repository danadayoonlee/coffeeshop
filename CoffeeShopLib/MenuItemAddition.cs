using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoffeeShopLib
{
    public abstract class MenuItemAddition : MenuItem
    {
        protected MenuItem menuItem;
        //Constructor
        public MenuItemAddition(MenuItem item)
        {
            MenuItem = item;
        }
        public MenuItemAddition()
        {

        }
        //Property
        [JsonIgnore]
        protected MenuItem MenuItem
        {
            get { return menuItem; }
            set { menuItem = value; }
        }
    }
}