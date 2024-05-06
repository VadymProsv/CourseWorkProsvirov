namespace CourseWorkProsvirov
{
    partial class AddEditOrder
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
            label1 = new Label();
            allLocations = new ComboBox();
            LocatedBarbers = new ComboBox();
            allServices = new ComboBox();
            apply = new Button();
            cancel = new Button();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(225, 40);
            label1.Name = "label1";
            label1.Size = new Size(97, 41);
            label1.TabIndex = 2;
            label1.Text = "Запис";
            // 
            // allLocations
            // 
            allLocations.FormattingEnabled = true;
            allLocations.Location = new Point(123, 102);
            allLocations.Name = "allLocations";
            allLocations.Size = new Size(300, 33);
            allLocations.TabIndex = 3;
            allLocations.Text = "Локації";
            allLocations.SelectedIndexChanged += allLocations_SelectedIndexChanged;
            // 
            // LocatedBarbers
            // 
            LocatedBarbers.FormattingEnabled = true;
            LocatedBarbers.Location = new Point(123, 141);
            LocatedBarbers.Name = "LocatedBarbers";
            LocatedBarbers.Size = new Size(300, 33);
            LocatedBarbers.TabIndex = 4;
            LocatedBarbers.Text = "Барбери";
            // 
            // allServices
            // 
            allServices.FormattingEnabled = true;
            allServices.Location = new Point(123, 180);
            allServices.Name = "allServices";
            allServices.Size = new Size(300, 33);
            allServices.TabIndex = 5;
            allServices.Text = "Послуги";
            // 
            // apply
            // 
            apply.Location = new Point(214, 318);
            apply.Name = "apply";
            apply.Size = new Size(124, 63);
            apply.TabIndex = 7;
            apply.Text = "Підтвердити";
            apply.UseVisualStyleBackColor = true;
            apply.Click += apply_Click;
            // 
            // cancel
            // 
            cancel.Location = new Point(214, 387);
            cancel.Name = "cancel";
            cancel.Size = new Size(124, 63);
            cancel.TabIndex = 8;
            cancel.Text = "Скасувати";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(123, 219);
            dateTimePicker1.MinDate = new DateTime(2024, 5, 4, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 9;
            dateTimePicker1.Value = new DateTime(2024, 5, 9, 9, 0, 0, 0);
            // 
            // AddEditOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 486);
            Controls.Add(dateTimePicker1);
            Controls.Add(cancel);
            Controls.Add(apply);
            Controls.Add(allServices);
            Controls.Add(LocatedBarbers);
            Controls.Add(allLocations);
            Controls.Add(label1);
            Name = "AddEditOrder";
            Text = "AddOrder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox allLocations;
        private ComboBox LocatedBarbers;
        private ComboBox allServices;
        private Button apply;
        private Button cancel;
        private DateTimePicker dateTimePicker1;
    }
}