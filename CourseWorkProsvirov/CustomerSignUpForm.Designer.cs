namespace CourseWorkProsvirov
{
    partial class CustomerSignUpForm
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
            CFirstNameSignUp = new TextBox();
            CLastNameSignUp = new TextBox();
            CPhoneSignUp = new TextBox();
            CEmailSignUp = new TextBox();
            CPasswordSignUp = new TextBox();
            SignUpButton = new Button();
            CancelSignUpButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(116, 22);
            label1.Name = "label1";
            label1.Size = new Size(164, 41);
            label1.TabIndex = 0;
            label1.Text = "Реєстрація";
            // 
            // CFirstNameSignUp
            // 
            CFirstNameSignUp.Font = new Font("Segoe UI", 12F);
            CFirstNameSignUp.Location = new Point(60, 80);
            CFirstNameSignUp.Name = "CFirstNameSignUp";
            CFirstNameSignUp.Size = new Size(278, 39);
            CFirstNameSignUp.TabIndex = 1;
            CFirstNameSignUp.Text = "Ім'я";
            // 
            // CLastNameSignUp
            // 
            CLastNameSignUp.Font = new Font("Segoe UI", 12F);
            CLastNameSignUp.Location = new Point(60, 123);
            CLastNameSignUp.Name = "CLastNameSignUp";
            CLastNameSignUp.Size = new Size(278, 39);
            CLastNameSignUp.TabIndex = 2;
            CLastNameSignUp.Text = "Прізвище";
            // 
            // CPhoneSignUp
            // 
            CPhoneSignUp.Font = new Font("Segoe UI", 12F);
            CPhoneSignUp.Location = new Point(60, 169);
            CPhoneSignUp.Name = "CPhoneSignUp";
            CPhoneSignUp.Size = new Size(278, 39);
            CPhoneSignUp.TabIndex = 3;
            CPhoneSignUp.Text = "Телефон";
            // 
            // CEmailSignUp
            // 
            CEmailSignUp.Font = new Font("Segoe UI", 12F);
            CEmailSignUp.Location = new Point(60, 214);
            CEmailSignUp.Name = "CEmailSignUp";
            CEmailSignUp.Size = new Size(278, 39);
            CEmailSignUp.TabIndex = 4;
            CEmailSignUp.Text = "Пошта";
            // 
            // CPasswordSignUp
            // 
            CPasswordSignUp.Font = new Font("Segoe UI", 12F);
            CPasswordSignUp.Location = new Point(60, 259);
            CPasswordSignUp.Name = "CPasswordSignUp";
            CPasswordSignUp.Size = new Size(278, 39);
            CPasswordSignUp.TabIndex = 5;
            CPasswordSignUp.Text = "Пароль";
            CPasswordSignUp.TextChanged += CPasswordSignUp_TextChanged;
            // 
            // SignUpButton
            // 
            SignUpButton.Location = new Point(116, 302);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(164, 47);
            SignUpButton.TabIndex = 6;
            SignUpButton.Text = "Зареєструватись";
            SignUpButton.UseVisualStyleBackColor = true;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // CancelSignUpButton
            // 
            CancelSignUpButton.Location = new Point(116, 355);
            CancelSignUpButton.Name = "CancelSignUpButton";
            CancelSignUpButton.Size = new Size(164, 47);
            CancelSignUpButton.TabIndex = 7;
            CancelSignUpButton.Text = "Скасувати";
            CancelSignUpButton.UseVisualStyleBackColor = true;
            CancelSignUpButton.Click += CancelSignUpButton_Click;
            // 
            // CustomerSignUpForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 470);
            Controls.Add(CancelSignUpButton);
            Controls.Add(SignUpButton);
            Controls.Add(CPasswordSignUp);
            Controls.Add(CEmailSignUp);
            Controls.Add(CPhoneSignUp);
            Controls.Add(CLastNameSignUp);
            Controls.Add(CFirstNameSignUp);
            Controls.Add(label1);
            Name = "CustomerSignUpForm";
            Text = "Barbershop";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox CFirstNameSignUp;
        private TextBox CLastNameSignUp;
        private TextBox CPhoneSignUp;
        private TextBox CEmailSignUp;
        private TextBox CPasswordSignUp;
        private Button SignUpButton;
        private Button CancelSignUpButton;
    }
}