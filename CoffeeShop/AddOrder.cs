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
using CoffeeShopLib.MenuItems;
using CoffeeShopLib.MenuItemAdditions;

namespace CoffeeShop
{
    public partial class AddOrder : Form
    {
        private Customer customer;
        private Order order;
        public List<CoffeeShopLib.MenuItem> menuItems = new List<CoffeeShopLib.MenuItem>();
        public CoffeeShopLib.MenuItem OrderedMenu;

        public AddOrder(Customer customer)
        {
            InitializeComponent();

            MenuItems_Listbox.Items.Add(new Coffee());
            MenuItems_Listbox.Items.Add(new CoffeeDarkRoast());
            MenuItems_Listbox.Items.Add(new SandwichWithBacon());
            MenuItems_Listbox.Items.Add(new SandwichWithEggSalad());
            MenuItems_Listbox.Items.Add(new SandwichWithRoastedBeef());
            MenuItems_Listbox.Items.Add(new Tea());
            Additions_Listbox.Items.Add(new Suggar());
            Additions_Listbox.Items.Add(new Milk());
            Additions_Listbox.Items.Add(new Sweetener());
            Additions_Listbox.Items.Add(new Lettuce());
            Additions_Listbox.Items.Add(new Cheese());
            Additions_Listbox.Items.Add(new Mayo());
            Additions_Listbox.Items.Add(new Tomato());

            Customer = customer;
        }

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }
        public Order Order
        {
            get { return order; }
            set { order = value; }
        }

        private void Ok_Btn_Click(object sender, EventArgs e)
        {
            if (Customer == MainForm.InternalCustomer)
            {
                Order = new Order();
                MainForm.InternalCustomer.AddOrder(Order);
            }
            else
            {
                Order = Customer.CreatePhoneOrder(Customer.Address);
            }

            for (int i = 0; i < menuItems.Count; i++)
            {
                Order.AddOrderItem(menuItems[i]);
            }

            MessageBox.Show($"{Order.Customer.Name}'s Order# {Order.OrderId} created!");
            MessageBox.Show($"====================RECEIPT====================\n" + Order.ToString() + "*" + Order.Type.ToString());

            this.Close();
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            OrderedMenu = null;
            OrderedMenu_Label.Text = "";
            MenuItems_Listbox.SelectedItem = null;
            Additions_Listbox.SelectedItem = null;
            Orders_Listbox.Items.Clear();
        }

        private void AddItem_Btn_Click(object sender, EventArgs e)
        {
            if (MenuItems_Listbox.SelectedItem != null)
            {
                OrderedMenu_Label.Text = OrderedMenu.ToString();
                AddItems(OrderedMenu);
            }
        }

        private void AddItems(CoffeeShopLib.MenuItem menuItem)
        { 
            if (Additions_Listbox.SelectedItem is Suggar)
            {
                OrderedMenu = new Suggar(menuItem);
                OrderedMenu_Label.Text = OrderedMenu.ToString();
            }
            else if (Additions_Listbox.SelectedItem is Milk)
            {
                OrderedMenu = new Milk(menuItem);
                OrderedMenu_Label.Text = OrderedMenu.ToString();
            }
            else if (Additions_Listbox.SelectedItem is Sweetener)
            {
                OrderedMenu = new Sweetener(menuItem);
                OrderedMenu_Label.Text = OrderedMenu.ToString();
            }
            else if (Additions_Listbox.SelectedItem is Lettuce)
            {
                OrderedMenu = new Lettuce(menuItem);
                OrderedMenu_Label.Text = OrderedMenu.ToString();
            }
            else if (Additions_Listbox.SelectedItem is Cheese)
            {
                OrderedMenu = new Cheese(menuItem);
                OrderedMenu_Label.Text = OrderedMenu.ToString();
            }
            else if (Additions_Listbox.SelectedItem is Mayo)
            {
                OrderedMenu = new Mayo(menuItem);
                OrderedMenu_Label.Text = OrderedMenu.ToString();
            }
            else if (Additions_Listbox.SelectedItem is Tomato)
            {
                OrderedMenu = new Tomato(menuItem);
                OrderedMenu_Label.Text = OrderedMenu.ToString();
            }
        }

        private void MenuItems_Listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderedMenu = (CoffeeShopLib.MenuItem)MenuItems_Listbox.SelectedItem;
        }

        private void setMenuItems(IList<CoffeeShopLib.MenuItem> menuItems)
        {
            menuItems.Add(OrderedMenu);
            Orders_Listbox.Items.Add(OrderedMenu);
        }

        private void AddOrder_Btn_Click(object sender, EventArgs e)
        {
            setMenuItems(menuItems);
            Additions_Listbox.SelectedItem = null;
        }
    }
}
