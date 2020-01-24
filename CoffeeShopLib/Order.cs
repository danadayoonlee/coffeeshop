using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoffeeShopLib
{
    [Serializable]
    public class Order
    {
        private uint orderId;
        private DateTime orderTime;
        private DateTime deliveryTime;
        private decimal menuCost;
        private OrderType type;
        private static uint increaseIdNumber;
        private List<OrderItem> menuItems = new List<OrderItem>();
        private uint numberOfOrderItems;
        private bool delivered;
        private Customer customer;
        //Constructor
        public Order()
        {
            numberOfOrderItems = 0;
            orderId = increaseIdNumber;
            increaseIdNumber++;
        }
        static Order()
        {
            increaseIdNumber = 5;
        }
        //Property
        public uint OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }
        public DateTime OrderTime
        {
            get { return orderTime; }
            set { orderTime = value; }
        }
        public DateTime DeliveryTime
        {
            get { return deliveryTime; }
            set { deliveryTime = value; }
        }
        public decimal MenuCost
        {
            get { return menuCost; }
            set { menuCost = value; }
        }
        public OrderType Type
        {
            get { return type; }
            set { type = value; }
        }
        [JsonIgnore]
        public Customer Customer
        {
            get { return customer; }
            set
            {
                if (Customer != null)
                {
                    Console.WriteLine(ErrorMessage());
                } 
                else
                {
                    customer = value;
                }
            }
        }
        public bool Delivered
        {
            get { return delivered; }
            set
            {
                if (value)
                {
                    delivered = value;
                    DeliveryTime = DateTime.Now;
                }
                else
                {
                    delivered = value;
                    DeliveryTime = DateTime.MinValue;
                }
            }
        }
        public List<OrderItem> MenuItems
        {
            get { return menuItems; }
            set { menuItems = value; }
        }
        //ToString
        public override string ToString()
        {
            string result = "";
            if (Delivered == true)
            {
                result += $"Order Id: {OrderId}\nCustomer name: {Customer.Name}\nOrder time: {string.Format("{0:HH:mm tt}", OrderTime)}\nCost: {MenuCost:C}\nDelivery address: {Customer.Address}\nDelivery time: {string.Format("{0:HH:mm tt}", DeliveryTime)}\nItems:\n";
            }
            else
            {
                result += $"Order Id: {OrderId}\nCustomer name: {Customer.Name}\nOrder time: {string.Format("{0:HH:mm tt}", OrderTime)}\nCost: {MenuCost:C}\nDelivery address: {Customer.Address}\nNot delivered\nItems:\n";
            }
            foreach (OrderItem item in menuItems)
            {
                if (item != null)
                {
                    result += $"{item}\n";
                }
            }
            return result;
        }
        //AddOrderItem
        public void AddOrderItem(MenuItem item)
        {
            OrderItem orderItem = new OrderItem(item);
                menuItems.Add(orderItem);
                numberOfOrderItems++;
                MenuCost += item.BaseCost;
        }
        //Deliver
        public void Deliver()
        {
            Delivered = true;
        }
        //ErrorMessage
        public string ErrorMessage()
        {
            return $"Something went wrong! Customer cannot be changed once assigned.\n";
        }
    }
}