namespace CoffeeShop
{
    partial class AddOrder
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
            this.Ok_Btn = new System.Windows.Forms.Button();
            this.Cancel_Btn = new System.Windows.Forms.Button();
            this.AddItem_Btn = new System.Windows.Forms.Button();
            this.OrderedMenu_Label = new System.Windows.Forms.Label();
            this.MenuItems_Listbox = new System.Windows.Forms.ListBox();
            this.Additions_Listbox = new System.Windows.Forms.ListBox();
            this.AddOrder_Btn = new System.Windows.Forms.Button();
            this.Orders_Listbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Ok_Btn
            // 
            this.Ok_Btn.Location = new System.Drawing.Point(434, 384);
            this.Ok_Btn.Name = "Ok_Btn";
            this.Ok_Btn.Size = new System.Drawing.Size(82, 36);
            this.Ok_Btn.TabIndex = 0;
            this.Ok_Btn.Text = "Ok";
            this.Ok_Btn.UseVisualStyleBackColor = true;
            this.Ok_Btn.Click += new System.EventHandler(this.Ok_Btn_Click);
            // 
            // Cancel_Btn
            // 
            this.Cancel_Btn.Location = new System.Drawing.Point(530, 384);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(79, 36);
            this.Cancel_Btn.TabIndex = 1;
            this.Cancel_Btn.Text = "Cancel";
            this.Cancel_Btn.UseVisualStyleBackColor = true;
            this.Cancel_Btn.Click += new System.EventHandler(this.Cancel_Btn_Click);
            // 
            // AddItem_Btn
            // 
            this.AddItem_Btn.Location = new System.Drawing.Point(400, 283);
            this.AddItem_Btn.Name = "AddItem_Btn";
            this.AddItem_Btn.Size = new System.Drawing.Size(116, 36);
            this.AddItem_Btn.TabIndex = 4;
            this.AddItem_Btn.Text = "Add Item";
            this.AddItem_Btn.UseVisualStyleBackColor = true;
            this.AddItem_Btn.Click += new System.EventHandler(this.AddItem_Btn_Click);
            // 
            // OrderedMenu_Label
            // 
            this.OrderedMenu_Label.AutoSize = true;
            this.OrderedMenu_Label.Location = new System.Drawing.Point(201, 341);
            this.OrderedMenu_Label.Name = "OrderedMenu_Label";
            this.OrderedMenu_Label.Size = new System.Drawing.Size(0, 17);
            this.OrderedMenu_Label.TabIndex = 31;
            // 
            // MenuItems_Listbox
            // 
            this.MenuItems_Listbox.FormattingEnabled = true;
            this.MenuItems_Listbox.ItemHeight = 16;
            this.MenuItems_Listbox.Location = new System.Drawing.Point(52, 37);
            this.MenuItems_Listbox.Name = "MenuItems_Listbox";
            this.MenuItems_Listbox.Size = new System.Drawing.Size(284, 212);
            this.MenuItems_Listbox.TabIndex = 32;
            this.MenuItems_Listbox.SelectedIndexChanged += new System.EventHandler(this.MenuItems_Listbox_SelectedIndexChanged);
            // 
            // Additions_Listbox
            // 
            this.Additions_Listbox.FormattingEnabled = true;
            this.Additions_Listbox.ItemHeight = 16;
            this.Additions_Listbox.Location = new System.Drawing.Point(379, 37);
            this.Additions_Listbox.Name = "Additions_Listbox";
            this.Additions_Listbox.Size = new System.Drawing.Size(284, 212);
            this.Additions_Listbox.TabIndex = 33;
            // 
            // AddOrder_Btn
            // 
            this.AddOrder_Btn.Location = new System.Drawing.Point(530, 283);
            this.AddOrder_Btn.Name = "AddOrder_Btn";
            this.AddOrder_Btn.Size = new System.Drawing.Size(116, 36);
            this.AddOrder_Btn.TabIndex = 35;
            this.AddOrder_Btn.Text = "Add Order";
            this.AddOrder_Btn.UseVisualStyleBackColor = true;
            this.AddOrder_Btn.Click += new System.EventHandler(this.AddOrder_Btn_Click);
            // 
            // Orders_Listbox
            // 
            this.Orders_Listbox.FormattingEnabled = true;
            this.Orders_Listbox.ItemHeight = 16;
            this.Orders_Listbox.Location = new System.Drawing.Point(705, 37);
            this.Orders_Listbox.Name = "Orders_Listbox";
            this.Orders_Listbox.Size = new System.Drawing.Size(284, 212);
            this.Orders_Listbox.TabIndex = 36;
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 450);
            this.Controls.Add(this.Orders_Listbox);
            this.Controls.Add(this.AddOrder_Btn);
            this.Controls.Add(this.Additions_Listbox);
            this.Controls.Add(this.MenuItems_Listbox);
            this.Controls.Add(this.OrderedMenu_Label);
            this.Controls.Add(this.AddItem_Btn);
            this.Controls.Add(this.Cancel_Btn);
            this.Controls.Add(this.Ok_Btn);
            this.Name = "AddOrder";
            this.Text = "Add order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ok_Btn;
        private System.Windows.Forms.Button Cancel_Btn;
        private System.Windows.Forms.Button AddItem_Btn;
        private System.Windows.Forms.Label OrderedMenu_Label;
        private System.Windows.Forms.ListBox MenuItems_Listbox;
        private System.Windows.Forms.ListBox Additions_Listbox;
        private System.Windows.Forms.Button AddOrder_Btn;
        private System.Windows.Forms.ListBox Orders_Listbox;
    }
}