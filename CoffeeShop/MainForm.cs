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
    public partial class MainForm : Form
    {
        public static Customer InternalCustomer;
        public Customer Customer;
        public Order Order;

        public MainForm()
        {
            InitializeComponent();
            InternalCustomer = new Customer("Coffee and sandwiches", 0, Address.SHOP_ADDRESS);
            Customer_Listbox.Items.Add(InternalCustomer);
        }

        private void AddCustomer_Btn_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
            Customer_Listbox.Items.Add(addCustomer.Customer);
        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            if (Customer_Listbox.SelectedItem != null)
            {
                EditCustomer editCustomer = new EditCustomer((Customer)Customer_Listbox.SelectedItem);
                editCustomer.ShowDialog();
                Customer_Listbox.Items.Insert(Customer_Listbox.SelectedIndex+1, editCustomer.Customer);
                Customer_Listbox.Items.Remove(Customer_Listbox.SelectedItem);
            }
        }

        private void AddOrder_Btn_Click(object sender, EventArgs e)
        {
            if (Customer_Listbox.SelectedItem != null)
            {
                AddOrder addInternalOrder = new AddOrder(InternalCustomer);
                AddOrder addOrder = new AddOrder(Customer);
                if (Customer == InternalCustomer)
                {
                    addInternalOrder.ShowDialog();
                }
                else
                {
                    addOrder.ShowDialog(); 
                }
                if (addOrder.OrderedMenu != null)
                {
                    Order_Listbox.Items.Add(addOrder.Order);
                }
                if (addInternalOrder.OrderedMenu != null)
                {
                    Order_Listbox.Items.Add(addInternalOrder.Order);
                }
            }
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            CustomerRepository repository = new CustomerRepository();

            foreach (Customer item in Customer_Listbox.Items)
            {
                repository.Add(item);
                MessageBox.Show("Saved!");
            }
            repository.Save("Customers.json");
        }

        private void Customer_Listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer = (Customer)Customer_Listbox.SelectedItem;
        }

        private void NotDelivered_Btn_Click(object sender, EventArgs e)
        {
            List<Customer> customer = this.Customer_Listbox.Items.Cast<Customer>().ToList();
            CustomerOrders customerOrders = new CustomerOrders(customer);
            customerOrders.ShowDialog();
        }

        private void BewteenTwoDates_Btn_Click(object sender, EventArgs e)
        {
            DateTime startDate = StartDate.Value;
            DateTime endDate = EndDate.Value;

            List<Customer> customer = this.Customer_Listbox.Items.Cast<Customer>().ToList();
            CustomerOrders customerOrders = new CustomerOrders(customer, startDate, endDate);
            customerOrders.ShowDialog();
        }
    }
}
