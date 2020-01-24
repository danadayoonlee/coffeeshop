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
    public partial class EditCustomer : Form
    {
        private Customer customer;

        public EditCustomer(Customer customer)
        {
            InitializeComponent();
            Name_Textbox.Text = customer.Name;
            Street_Textbox.Text = customer.Address.Street;
            City_Textbox.Text = customer.Address.City;
            Province_Textbox.Text = customer.Address.Province;
            Postal_Textbox.Text = customer.Address.PostalCode;
            Phone_Textbox.Text = Convert.ToString(customer.Phone);
            Customer = customer;
        }

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            Customer.Name = Name_Textbox.Text;
            Customer.Address.Street = Street_Textbox.Text;
            Customer.Address.City = City_Textbox.Text;
            Customer.Address.Province = Province_Textbox.Text;
            Customer.Address.PostalCode = Postal_Textbox.Text;
            Customer.Phone = Convert.ToUInt32(Phone_Textbox.Text);

            this.Close();
        }
    }
}
