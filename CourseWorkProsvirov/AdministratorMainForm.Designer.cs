namespace CourseWorkProsvirov
{
    partial class AdministratorMainForm
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
            menuStrip1 = new MenuStrip();
            Users = new ToolStripMenuItem();
            Customers = new ToolStripMenuItem();
            Barbers = new ToolStripMenuItem();
            Administrators = new ToolStripMenuItem();
            AboutOrders = new ToolStripMenuItem();
            Services = new ToolStripMenuItem();
            Orders = new ToolStripMenuItem();
            Transaction = new ToolStripMenuItem();
            Reviews = new ToolStripMenuItem();
            Locations = new ToolStripMenuItem();
            Discounts = new ToolStripMenuItem();
            Regular = new ToolStripMenuItem();
            Irregular = new ToolStripMenuItem();
            Apply = new ToolStripMenuItem();
            dataGridView = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { Users, AboutOrders, Locations, Discounts, Apply });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(808, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // Users
            // 
            Users.DropDownItems.AddRange(new ToolStripItem[] { Customers, Barbers, Administrators });
            Users.Name = "Users";
            Users.Size = new Size(127, 29);
            Users.Text = "Користувачі";
            // 
            // Customers
            // 
            Customers.Name = "Customers";
            Customers.Size = new Size(241, 34);
            Customers.Text = "Клієнти";
            Customers.Click += Customers_Click;
            // 
            // Barbers
            // 
            Barbers.Name = "Barbers";
            Barbers.Size = new Size(241, 34);
            Barbers.Text = "Барбери";
            Barbers.Click += Barbers_Click;
            // 
            // Administrators
            // 
            Administrators.Name = "Administrators";
            Administrators.Size = new Size(241, 34);
            Administrators.Text = "Адміністратори";
            Administrators.Click += Administrators_Click;
            // 
            // AboutOrders
            // 
            AboutOrders.DropDownItems.AddRange(new ToolStripItem[] { Services, Orders, Transaction, Reviews });
            AboutOrders.Name = "AboutOrders";
            AboutOrders.Size = new Size(128, 29);
            AboutOrders.Text = "Замовлення";
            // 
            // Services
            // 
            Services.Name = "Services";
            Services.Size = new Size(198, 34);
            Services.Text = "Послуги";
            Services.Click += Services_Click;
            // 
            // Orders
            // 
            Orders.Name = "Orders";
            Orders.Size = new Size(198, 34);
            Orders.Text = "Записи";
            Orders.Click += Orders_Click;
            // 
            // Transaction
            // 
            Transaction.Name = "Transaction";
            Transaction.Size = new Size(198, 34);
            Transaction.Text = "Транзакції";
            Transaction.Click += Transaction_Click;
            // 
            // Reviews
            // 
            Reviews.Name = "Reviews";
            Reviews.Size = new Size(198, 34);
            Reviews.Text = "Відгуки";
            Reviews.Click += Reviews_Click;
            // 
            // Locations
            // 
            Locations.Name = "Locations";
            Locations.Size = new Size(88, 29);
            Locations.Text = "Локації";
            Locations.Click += Locations_Click;
            // 
            // Discounts
            // 
            Discounts.DropDownItems.AddRange(new ToolStripItem[] { Regular, Irregular });
            Discounts.Name = "Discounts";
            Discounts.Size = new Size(90, 29);
            Discounts.Text = "Знижки";
            // 
            // Regular
            // 
            Regular.Name = "Regular";
            Regular.Size = new Size(215, 34);
            Regular.Text = "Регулярні";
            Regular.Click += Regular_Click;
            // 
            // Irregular
            // 
            Irregular.Name = "Irregular";
            Irregular.Size = new Size(215, 34);
            Irregular.Text = "Нерегулярні";
            Irregular.Click += Irregular_Click;
            // 
            // Apply
            // 
            Apply.Name = "Apply";
            Apply.Size = new Size(179, 29);
            Apply.Text = "Підтвердити зміни";
            Apply.Click += Apply_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 36);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(788, 336);
            dataGridView.TabIndex = 1;
            // 
            // AdministratorMainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 383);
            Controls.Add(dataGridView);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AdministratorMainForm";
            Text = "AdministratorMainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem Users;
        private ToolStripMenuItem AboutOrders;
        private ToolStripMenuItem Customers;
        private ToolStripMenuItem Barbers;
        private ToolStripMenuItem Administrators;
        private ToolStripMenuItem Orders;
        private ToolStripMenuItem Transaction;
        private ToolStripMenuItem Reviews;
        private ToolStripMenuItem Locations;
        private ToolStripMenuItem Discounts;
        private ToolStripMenuItem Regular;
        private ToolStripMenuItem Irregular;
        private ToolStripMenuItem Services;
        private DataGridView dataGridView;
        private ToolStripMenuItem Apply;
    }
}