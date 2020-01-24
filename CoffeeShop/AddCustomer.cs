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
    public partial class AddCustomer : Form
    {
        private Customer customer;
        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public AddCustomer()
        {
            InitializeComponent();
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            Customer = new Customer();

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
