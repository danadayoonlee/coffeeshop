using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoffeeShopLib
{
    [Serializable]
    public class MenuItem : IMenuItem
    {
        private string description;
        private decimal baseCost;
        //Constructor
        public MenuItem()
        {
            
        }
        public MenuItem(string description, decimal baseCost)
        {
            Description = description;
            BaseCost = baseCost;
        }
        //Property
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public decimal BaseCost
        {
            get { return baseCost; }
            set { baseCost = value; }
        }
        //ToString
        public override string ToString()
        {
            return ("Menu item:  Description: " + Description + "\n Base cost: " + BaseCost + "\n");
        }
    }
}