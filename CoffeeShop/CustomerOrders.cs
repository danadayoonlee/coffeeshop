using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShopLib;

namespace CoffeeShop
{
    public partial class CustomerOrders : Form
    {
        public CustomerOrders(List<Customer> customers)
        {
            InitializeComponent();
            CustomerRepository repository = new CustomerRepository();
            //Bring all customers
            foreach (Customer customer in customers)
            {
                repository.Add(customer);
            }
            //Bring customers who have not delivered orders
            customers = repository.ListNotDeliveredOrders();
            foreach (Customer customer in customers)
            {
                Customer_Listbox.Items.Add(customer);
            }
        }

        public CustomerOrders(List<Customer> customers, DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            CustomerRepository repository = new CustomerRepository();
            //Bring all customers
            foreach (Customer customer in customers)
            {
                repository.Add(customer);
            }
            //Bring customers who have not delivered orders
            customers = repository.ListOrdersBetweenTwoDates(startDate, endDate);
            foreach (Customer customer in customers)
            {
                Customer_Listbox.Items.Add(customer);
            }
        }

        private void Customer_Listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //1. selected customer
            //2. selectedCustomer.Orders 
            //3. manipulate orders to orderListBox

            Order_Listbox.Items.Clear();

            Customer selctedCustomer = (Customer)Customer_Listbox.SelectedItem;
           
            foreach (Order order in selctedCustomer.Orders)
            {
                Order_Listbox.Items.Add(order);
            }
            
        }
    }
}
