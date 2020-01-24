using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoffeeShopLib
{   
    public class CustomerRepository : RepositoryBase
    {
        private List<Customer> customers = new List<Customer>();
        private uint numberOfCustomers;
        //Constructor
        public CustomerRepository()
        {
            numberOfCustomers = 0;
        }
        //Property
        public override List<Customer> Customers
        {
            get { return customers; }
            set { customers = value; }
        }
        //Add
        public void Add(Customer customer)
        {
            customers.Add(customer);
            numberOfCustomers++;
        }
        //List not delivered orders
        public List<Customer> ListNotDeliveredOrders()
        {
            var deliveredCustomers = customers.Where(c => c.Orders.Any(o => o.Delivered == false));
            return (List<Customer>)deliveredCustomers.ToList();
        }
        //List orders created between two dates
        public List<Customer> ListOrdersBetweenTwoDates(DateTime startDate, DateTime endDate)
        {
            var customersBetweenTwoDates = (from customer in customers
                where customer.Orders.Any(o => o.OrderTime >= startDate && o.OrderTime <= endDate)
                select customer).ToList();
            return (List<Customer>)customersBetweenTwoDates.ToList();
        }
    }
}