namespace CourseWorkProsvirov
{
    partial class CustomerMainForm
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
            cOrders = new DataGridView();
            OrderID = new DataGridViewTextBoxColumn();
            DateTime = new DataGridViewTextBoxColumn();
            ServiceName = new DataGridViewTextBoxColumn();
            BarberName = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            cOrderUpdate = new Button();
            cOrderCancel = new Button();
            addButton = new Button();
            showReviews = new Button();
            RBarbers = new ComboBox();
            reviews = new DataGridView();
            ReviewID = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            Rating = new DataGridViewTextBoxColumn();
            Comment = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)cOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reviews).BeginInit();
            SuspendLayout();
            // 
            // cOrders
            // 
            cOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cOrders.Columns.AddRange(new DataGridViewColumn[] { OrderID, DateTime, ServiceName, BarberName, Total });
            cOrders.Location = new Point(2, 11);
            cOrders.Name = "cOrders";
            cOrders.ReadOnly = true;
            cOrders.RowHeadersWidth = 62;
            cOrders.Size = new Size(820, 225);
            cOrders.TabIndex = 0;
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
            // BarberName
            // 
            BarberName.DataPropertyName = "BarberFirstName";
            BarberName.HeaderText = "Барбер";
            BarberName.MinimumWidth = 8;
            BarberName.Name = "BarberName";
            BarberName.ReadOnly = true;
            BarberName.Width = 150;
            // 
            // Total
            // 
            Total.DataPropertyName = "Total";
            Total.HeaderText = "Сума";
            Total.MinimumWidth = 8;
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 150;
            // 
            // cOrderUpdate
            // 
            cOrderUpdate.Location = new Point(828, 11);
            cOrderUpdate.Name = "cOrderUpdate";
            cOrderUpdate.Size = new Size(146, 34);
            cOrderUpdate.TabIndex = 1;
            cOrderUpdate.Text = "Змінити";
            cOrderUpdate.UseVisualStyleBackColor = true;
            cOrderUpdate.Click += cOrderUpdate_Click;
            // 
            // cOrderCancel
            // 
            cOrderCancel.Location = new Point(828, 51);
            cOrderCancel.Name = "cOrderCancel";
            cOrderCancel.Size = new Size(146, 34);
            cOrderCancel.TabIndex = 2;
            cOrderCancel.Text = "Скасувати";
            cOrderCancel.UseVisualStyleBackColor = true;
            cOrderCancel.Click += cOrderCancel_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(828, 202);
            addButton.Name = "addButton";
            addButton.Size = new Size(146, 34);
            addButton.TabIndex = 3;
            addButton.Text = "Записатись";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // showReviews
            // 
            showReviews.Location = new Point(2, 244);
            showReviews.Name = "showReviews";
            showReviews.Size = new Size(820, 34);
            showReviews.TabIndex = 4;
            showReviews.Text = "Показати відгуки цього майстра";
            showReviews.UseVisualStyleBackColor = true;
            showReviews.Click += showReviews_Click;
            // 
            // RBarbers
            // 
            RBarbers.FormattingEnabled = true;
            RBarbers.Location = new Point(828, 244);
            RBarbers.Name = "RBarbers";
            RBarbers.Size = new Size(146, 33);
            RBarbers.TabIndex = 5;
            RBarbers.Text = "Барбери";
            // 
            // reviews
            // 
            reviews.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reviews.Columns.AddRange(new DataGridViewColumn[] { ReviewID, FirstName, Rating, Comment });
            reviews.Location = new Point(5, 282);
            reviews.Name = "reviews";
            reviews.ReadOnly = true;
            reviews.RowHeadersWidth = 62;
            reviews.Size = new Size(817, 270);
            reviews.TabIndex = 6;
            // 
            // ReviewID
            // 
            ReviewID.DataPropertyName = "ReviewID";
            ReviewID.HeaderText = "ID";
            ReviewID.MinimumWidth = 8;
            ReviewID.Name = "ReviewID";
            ReviewID.ReadOnly = true;
            ReviewID.Width = 150;
            // 
            // FirstName
            // 
            FirstName.DataPropertyName = "FirstName";
            FirstName.HeaderText = "Клієнт";
            FirstName.MinimumWidth = 8;
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            FirstName.Width = 150;
            // 
            // Rating
            // 
            Rating.DataPropertyName = "Rating";
            Rating.HeaderText = "Рейтинг";
            Rating.MinimumWidth = 8;
            Rating.Name = "Rating";
            Rating.ReadOnly = true;
            Rating.Width = 150;
            // 
            // Comment
            // 
            Comment.DataPropertyName = "Comment";
            Comment.HeaderText = "Коментар";
            Comment.MinimumWidth = 8;
            Comment.Name = "Comment";
            Comment.ReadOnly = true;
            Comment.Width = 300;
            // 
            // CustomerMainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 564);
            Controls.Add(reviews);
            Controls.Add(RBarbers);
            Controls.Add(showReviews);
            Controls.Add(addButton);
            Controls.Add(cOrderCancel);
            Controls.Add(cOrderUpdate);
            Controls.Add(cOrders);
            Name = "CustomerMainForm";
            Text = "Barbershop";
            ((System.ComponentModel.ISupportInitialize)cOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)reviews).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button cOrderUpdate;
        private Button cOrderCancel;
        private Button addButton;
        private DataGridViewTextBoxColumn OrderID;
        private DataGridViewTextBoxColumn DateTime;
        private DataGridViewTextBoxColumn ServiceName;
        private DataGridViewTextBoxColumn BarberName;
        private DataGridViewTextBoxColumn Total;
        private Button showReviews;
        private ComboBox RBarbers;
        private DataGridView reviews;
        private DataGridViewTextBoxColumn ReviewID;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn Rating;
        private DataGridViewTextBoxColumn Comment;
        public static DataGridView cOrders;
    }
}