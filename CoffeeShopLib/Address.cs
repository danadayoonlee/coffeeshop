using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib
{
    public struct Address
    {
        public static Address SHOP_ADDRESS;
        public string Street;
        public string City;
        public string Province;
        public string PostalCode;
        //Constructor
        static Address()
        {
            SHOP_ADDRESS = new Address() { Street = "1 King St", City = "Toronto", Province = "ON", PostalCode = "M1M 1M1" };
        }
        //ToString
        public override string ToString()
        {
            return $"Address: {Street}, {City}, {Province} {PostalCode}";
        }
    }
}
