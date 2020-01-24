using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoffeeShopLib
{
    [Serializable]
    public class Customer
    {
        private uint customerId;
        private string name;
        public Address Address;
        private uint phone;
        private static uint increaseIdNumber;
        private List<Order> orders = new List<Order>();
        private uint numberOfOrders;
        //Constructor
        static Customer()
        {
            increaseIdNumber = 1;
        }
        public Customer()
        {
            customerId = increaseIdNumber++;
            numberOfOrders = 0;       
        }
        public Customer(string name, uint phone, Address address)
        {
            customerId = increaseIdNumber++;
            Name = name;
            Phone = phone;
            Address.SHOP_ADDRESS = address;
            Address = address;
            numberOfOrders = 0;       
        }
        //Property
        public uint CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public uint Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public List<Order> Orders
        {
            get { return orders; }
            set { orders = value; }
        }
        //ToString
        public override string ToString()
        {
            string result = $"Customer: Id:{CustomerId}, Name:{Name},\nAddress: {Address}, Phone: {Phone}\nOrders:\n";
            foreach (Order item in orders)
            {
                if (item != null)
                {
                    result += item + "\n\n";
                }
            }
            return result;
        }
        //CreateOrder
        public Order CreatePhoneOrder(Address address)
        {
            Order phoneOrder = new Order(); { Address = address; }

            phoneOrder.Type = OrderType.PhoneOrder;
            phoneOrder.Customer = this;               
            phoneOrder.OrderTime = DateTime.Now;
            Orders.Add(phoneOrder);
            numberOfOrders++;

            return phoneOrder;
        }
        //AddOrder
        public Order AddOrder(Order restaurantOrder)
        { 
            restaurantOrder.Type = OrderType.RestaurantOrder;
            restaurantOrder.Customer = this;
            restaurantOrder.OrderTime = DateTime.Now;
            restaurantOrder.Customer.Address = Address.SHOP_ADDRESS;
            restaurantOrder.Deliver();
            Orders.Add(restaurantOrder);
            numberOfOrders++;
            return restaurantOrder;
        }
    }
}