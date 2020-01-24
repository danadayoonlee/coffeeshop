namespace CoffeeShop
{
    partial class MainForm
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
            this.AddCustomer_Btn = new System.Windows.Forms.Button();
            this.Customer_Listbox = new System.Windows.Forms.ListBox();
            this.Edit_Btn = new System.Windows.Forms.Button();
            this.AddOrder_Btn = new System.Windows.Forms.Button();
            this.Order_Listbox = new System.Windows.Forms.ListBox();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.NotDelivered_Btn = new System.Windows.Forms.Button();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.NotDeliveredOrders_Label = new System.Windows.Forms.Label();
            this.OrdersBetweenTwoDates_Label = new System.Windows.Forms.Label();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.Add_Label = new System.Windows.Forms.Label();
            this.BewteenTwoDates_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddCustomer_Btn
            // 
            this.AddCustomer_Btn.Location = new System.Drawing.Point(166, 286);
            this.AddCustomer_Btn.Name = "AddCustomer_Btn";
            this.AddCustomer_Btn.Size = new System.Drawing.Size(116, 36);
            this.AddCustomer_Btn.TabIndex = 0;
            this.AddCustomer_Btn.Text = "Add Customer";
            this.AddCustomer_Btn.UseVisualStyleBackColor = true;
            this.AddCustomer_Btn.Click += new System.EventHandler(this.AddCustomer_Btn_Click);
            // 
            // Customer_Listbox
            // 
            this.Customer_Listbox.FormattingEnabled = true;
            this.Customer_Listbox.ItemHeight = 16;
            this.Customer_Listbox.Location = new System.Drawing.Point(25, 67);
            this.Customer_Listbox.Name = "Customer_Listbox";
            this.Customer_Listbox.Size = new System.Drawing.Size(522, 196);
            this.Customer_Listbox.TabIndex = 1;
            this.Customer_Listbox.SelectedIndexChanged += new System.EventHandler(this.Customer_Listbox_SelectedIndexChanged);
            // 
            // Edit_Btn
            // 
            this.Edit_Btn.Location = new System.Drawing.Point(298, 286);
            this.Edit_Btn.Name = "Edit_Btn";
            this.Edit_Btn.Size = new System.Drawing.Size(78, 36);
            this.Edit_Btn.TabIndex = 2;
            this.Edit_Btn.Text = "Edit";
            this.Edit_Btn.UseVisualStyleBackColor = true;
            this.Edit_Btn.Click += new System.EventHandler(this.Edit_Btn_Click);
            // 
            // AddOrder_Btn
            // 
            this.AddOrder_Btn.Location = new System.Drawing.Point(777, 286);
            this.AddOrder_Btn.Name = "AddOrder_Btn";
            this.AddOrder_Btn.Size = new System.Drawing.Size(116, 36);
            this.AddOrder_Btn.TabIndex = 3;
            this.AddOrder_Btn.Text = "Add Order";
            this.AddOrder_Btn.UseVisualStyleBackColor = true;
            this.AddOrder_Btn.Click += new System.EventHandler(this.AddOrder_Btn_Click);
            // 
            // Order_Listbox
            // 
            this.Order_Listbox.FormattingEnabled = true;
            this.Order_Listbox.ItemHeight = 16;
            this.Order_Listbox.Location = new System.Drawing.Point(566, 67);
            this.Order_Listbox.Name = "Order_Listbox";
            this.Order_Listbox.Size = new System.Drawing.Size(522, 196);
            this.Order_Listbox.TabIndex = 4;
            // 
            // Save_Btn
            // 
            this.Save_Btn.Location = new System.Drawing.Point(514, 354);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(82, 36);
            this.Save_Btn.TabIndex = 5;
            this.Save_Btn.Text = "Save";
            this.Save_Btn.UseVisualStyleBackColor = true;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
            // 
            // NotDelivered_Btn
            // 
            this.NotDelivered_Btn.Location = new System.Drawing.Point(67, 493);
            this.NotDelivered_Btn.Name = "NotDelivered_Btn";
            this.NotDelivered_Btn.Size = new System.Drawing.Size(91, 36);
            this.NotDelivered_Btn.TabIndex = 6;
            this.NotDelivered_Btn.Text = "View";
            this.NotDelivered_Btn.UseVisualStyleBackColor = true;
            this.NotDelivered_Btn.Click += new System.EventHandler(this.NotDelivered_Btn_Click);
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(569, 498);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(200, 22);
            this.StartDate.TabIndex = 7;
            // 
            // NotDeliveredOrders_Label
            // 
            this.NotDeliveredOrders_Label.AutoSize = true;
            this.NotDeliveredOrders_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NotDeliveredOrders_Label.Location = new System.Drawing.Point(62, 443);
            this.NotDeliveredOrders_Label.Name = "NotDeliveredOrders_Label";
            this.NotDeliveredOrders_Label.Size = new System.Drawing.Size(275, 25);
            this.NotDeliveredOrders_Label.TabIndex = 8;
            this.NotDeliveredOrders_Label.Text = "To check not delivered orders:";
            // 
            // OrdersBetweenTwoDates_Label
            // 
            this.OrdersBetweenTwoDates_Label.AutoSize = true;
            this.OrdersBetweenTwoDates_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OrdersBetweenTwoDates_Label.Location = new System.Drawing.Point(564, 443);
            this.OrdersBetweenTwoDates_Label.Name = "OrdersBetweenTwoDates_Label";
            this.OrdersBetweenTwoDates_Label.Size = new System.Drawing.Size(326, 25);
            this.OrdersBetweenTwoDates_Label.TabIndex = 9;
            this.OrdersBetweenTwoDates_Label.Text = "To check orders between two dates:";
            // 
            // EndDate
            // 
            this.EndDate.Location = new System.Drawing.Point(807, 498);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(200, 22);
            this.EndDate.TabIndex = 10;
            // 
            // Add_Label
            // 
            this.Add_Label.AutoSize = true;
            this.Add_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Add_Label.Location = new System.Drawing.Point(20, 24);
            this.Add_Label.Name = "Add_Label";
            this.Add_Label.Size = new System.Drawing.Size(235, 25);
            this.Add_Label.TabIndex = 11;
            this.Add_Label.Text = "Add customer / Add order";
            // 
            // BewteenTwoDates_Btn
            // 
            this.BewteenTwoDates_Btn.Location = new System.Drawing.Point(742, 545);
            this.BewteenTwoDates_Btn.Name = "BewteenTwoDates_Btn";
            this.BewteenTwoDates_Btn.Size = new System.Drawing.Size(91, 36);
            this.BewteenTwoDates_Btn.TabIndex = 12;
            this.BewteenTwoDates_Btn.Text = "View";
            this.BewteenTwoDates_Btn.UseVisualStyleBackColor = true;
            this.BewteenTwoDates_Btn.Click += new System.EventHandler(this.BewteenTwoDates_Btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 633);
            this.Controls.Add(this.BewteenTwoDates_Btn);
            this.Controls.Add(this.Add_Label);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.OrdersBetweenTwoDates_Label);
            this.Controls.Add(this.NotDeliveredOrders_Label);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.NotDelivered_Btn);
            this.Controls.Add(this.Save_Btn);
            this.Controls.Add(this.Order_Listbox);
            this.Controls.Add(this.AddOrder_Btn);
            this.Controls.Add(this.Edit_Btn);
            this.Controls.Add(this.Customer_Listbox);
            this.Controls.Add(this.AddCustomer_Btn);
            this.Name = "MainForm";
            this.Text = "Main form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddCustomer_Btn;
        public System.Windows.Forms.ListBox Customer_Listbox;
        private System.Windows.Forms.Button Edit_Btn;
        private System.Windows.Forms.Button AddOrder_Btn;
        public System.Windows.Forms.ListBox Order_Listbox;
        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.Button NotDelivered_Btn;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.Label NotDeliveredOrders_Label;
        private System.Windows.Forms.Label OrdersBetweenTwoDates_Label;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.Label Add_Label;
        private System.Windows.Forms.Button BewteenTwoDates_Btn;
    }
}

