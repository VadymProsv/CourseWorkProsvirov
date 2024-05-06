namespace CourseWorkProsvirov
{
    partial class SigInUpForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            roleChoose = new ComboBox();
            label1 = new Label();
            LoginSignIn = new TextBox();
            PasswordSignIn = new TextBox();
            signInButton = new Button();
            signUpButton = new Button();
            SuspendLayout();
            // 
            // roleChoose
            // 
            roleChoose.FormattingEnabled = true;
            roleChoose.Items.AddRange(new object[] { "Клієнт", "Барбер", "Адміністратор" });
            roleChoose.Location = new Point(75, 85);
            roleChoose.Name = "roleChoose";
            roleChoose.Size = new Size(137, 33);
            roleChoose.TabIndex = 0;
            roleChoose.Text = "Хто Ви?";
            roleChoose.SelectedIndexChanged += roleChoose_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(84, 30);
            label1.Name = "label1";
            label1.Size = new Size(118, 41);
            label1.TabIndex = 1;
            label1.Text = "Привіт!";
            // 
            // LoginSignIn
            // 
            LoginSignIn.Enabled = false;
            LoginSignIn.Font = new Font("Segoe UI", 12F);
            LoginSignIn.Location = new Point(42, 124);
            LoginSignIn.Name = "LoginSignIn";
            LoginSignIn.Size = new Size(200, 39);
            LoginSignIn.TabIndex = 2;
            LoginSignIn.Text = "Номер телефону";
            LoginSignIn.Visible = false;
            // 
            // PasswordSignIn
            // 
            PasswordSignIn.Enabled = false;
            PasswordSignIn.Font = new Font("Segoe UI", 12F);
            PasswordSignIn.Location = new Point(42, 169);
            PasswordSignIn.Name = "PasswordSignIn";
            PasswordSignIn.Size = new Size(200, 39);
            PasswordSignIn.TabIndex = 3;
            PasswordSignIn.Text = "Пароль";
            PasswordSignIn.Visible = false;
            // 
            // signInButton
            // 
            signInButton.Enabled = false;
            signInButton.Location = new Point(75, 214);
            signInButton.Name = "signInButton";
            signInButton.Size = new Size(137, 34);
            signInButton.TabIndex = 4;
            signInButton.Text = "Вхід";
            signInButton.UseVisualStyleBackColor = true;
            signInButton.Visible = false;
            signInButton.Click += signInButton_Click;
            // 
            // signUpButton
            // 
            signUpButton.Enabled = false;
            signUpButton.Location = new Point(75, 254);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(137, 34);
            signUpButton.TabIndex = 5;
            signUpButton.Text = "Реєстрація";
            signUpButton.UseVisualStyleBackColor = true;
            signUpButton.Visible = false;
            signUpButton.Click += signUpButton_Click;
            // 
            // SigInUpForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 317);
            Controls.Add(signUpButton);
            Controls.Add(signInButton);
            Controls.Add(PasswordSignIn);
            Controls.Add(LoginSignIn);
            Controls.Add(label1);
            Controls.Add(roleChoose);
            Name = "SigInUpForm";
            Text = "Barbershop";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox roleChoose;
        private Label label1;
        private TextBox LoginSignIn;
        private TextBox PasswordSignIn;
        private Button signInButton;
        private Button signUpButton;
    }
}
