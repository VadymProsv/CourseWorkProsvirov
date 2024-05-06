namespace CourseWorkProsvirov
{
    partial class BarberMainForm
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
            bOrders = new DataGridView();
            OrderID = new DataGridViewTextBoxColumn();
            DateTime = new DataGridViewTextBoxColumn();
            ServiceName = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            reload = new Button();
            ((System.ComponentModel.ISupportInitialize)bOrders).BeginInit();
            SuspendLayout();
            // 
            // bOrders
            // 
            bOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bOrders.Columns.AddRange(new DataGridViewColumn[] { OrderID, DateTime, ServiceName, CustomerName });
            bOrders.Location = new Point(0, 0);
            bOrders.Name = "bOrders";
            bOrders.ReadOnly = true;
            bOrders.RowHeadersWidth = 62;
            bOrders.Size = new Size(664, 225);
            bOrders.TabIndex = 1;
            // 
            // OrderID
            // 
            OrderID.DataPropertyName = "OrderID";
            OrderID.HeaderText = "ID";
            OrderID.MinimumWidth = 8;
            OrderID.Name = "OrderID";
            OrderID.ReadOnly = true;
            OrderID.Width = 150;
            // 
            // DateTime
            // 
            DateTime.DataPropertyName = "DateTime";
            DateTime.HeaderText = "Дата і час";
            DateTime.MinimumWidth = 8;
            DateTime.Name = "DateTime";
            DateTime.ReadOnly = true;
            DateTime.Width = 150;
            // 
            // ServiceName
            // 
            ServiceName.DataPropertyName = "ServiceName";
            ServiceName.HeaderText = "Послуга";
            ServiceName.MinimumWidth = 8;
            ServiceName.Name = "ServiceName";
            ServiceName.ReadOnly = true;
            ServiceName.Width = 150;
            // 
            // CustomerName
            // 
            CustomerName.DataPropertyName = "CustomerFirstName";
            CustomerName.HeaderText = "Клієнт";
            CustomerName.MinimumWidth = 8;
            CustomerName.Name = "CustomerName";
            CustomerName.ReadOnly = true;
            CustomerName.Width = 150;
            // 
            // reload
            // 
            reload.Location = new Point(284, 231);
            reload.Name = "reload";
            reload.Size = new Size(112, 34);
            reload.TabIndex = 2;
            reload.Text = "Оновити";
            reload.UseVisualStyleBackColor = true;
            reload.Click += reload_Click;
            // 
            // BarberMainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 266);
            Controls.Add(reload);
            Controls.Add(bOrders);
            Name = "BarberMainForm";
            Text = "BarberMainForm";
            ((System.ComponentModel.ISupportInitialize)bOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView bOrders;
        private DataGridViewTextBoxColumn OrderID;
        private DataGridViewTextBoxColumn DateTime;
        private DataGridViewTextBoxColumn ServiceName;
        private DataGridViewTextBoxColumn CustomerName;
        private Button reload;
    }
}