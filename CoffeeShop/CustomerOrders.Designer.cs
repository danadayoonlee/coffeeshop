namespace CoffeeShop
{
    partial class CustomerOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Order_Listbox = new System.Windows.Forms.ListBox();
            this.Customer_Listbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Order_Listbox
            // 
            this.Order_Listbox.FormattingEnabled = true;
            this.Order_Listbox.ItemHeight = 16;
            this.Order_Listbox.Location = new System.Drawing.Point(568, 27);
            this.Order_Listbox.Name = "Order_Listbox";
            this.Order_Listbox.Size = new System.Drawing.Size(522, 196);
            this.Order_Listbox.TabIndex = 6;
            // 
            // Customer_Listbox
            // 
            this.Customer_Listbox.FormattingEnabled = true;
            this.Customer_Listbox.ItemHeight = 16;
            this.Customer_Listbox.Location = new System.Drawing.Point(27, 27);
            this.Customer_Listbox.Name = "Customer_Listbox";
            this.Customer_Listbox.Size = new System.Drawing.Size(522, 196);
            this.Customer_Listbox.TabIndex = 5;
            this.Customer_Listbox.SelectedIndexChanged += new System.EventHandler(this.Customer_Listbox_SelectedIndexChanged);
            // 
            // CustomerOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 450);
            this.Controls.Add(this.Order_Listbox);
            this.Controls.Add(this.Customer_Listbox);
            this.Name = "CustomerOrders";
            this.Text = "Customer orders";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox Order_Listbox;
        public System.Windows.Forms.ListBox Customer_Listbox;
    }
}