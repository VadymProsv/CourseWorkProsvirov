namespace CourseWorkProsvirov
{
    public partial class SigInUpForm : Form
    {
        public SigInUpForm()
        {
            InitializeComponent();
            Program.setUserAuthorization(new UserAuthorization("server=PROSVIROV-VADYM\\SQLEXPRESS; database=CourseWorkProsvirov; integrated security=True;"));
        }

        private void roleChoose_SelectedIndexChanged(object? sender, EventArgs e)
        {
            switch (roleChoose.SelectedIndex)
            {
                case 0:
                    {
                        LoginSignIn.Enabled = true;
                        LoginSignIn.Visible = true;
                        PasswordSignIn.Enabled = true;
                        PasswordSignIn.Visible = true;
                        signInButton.Enabled = true;
                        signInButton.Visible = true;
                        signUpButton.Enabled = true;
                        signUpButton.Visible = true;
                        Program.setRole(Roles.Customer);
                        break;
                    }
                case 1:
                    {
                        LoginSignIn.Enabled = true;
                        LoginSignIn.Visible = true;
                        PasswordSignIn.Enabled = true;
                        PasswordSignIn.Visible = true;
                        signInButton.Enabled = true;
                        signInButton.Visible = true;
                        signUpButton.Enabled = false;
                        signUpButton.Visible = false;
                        Program.setRole(Roles.Barber);
                        break;
                    }
                case 2:
                    {
                        LoginSignIn.Enabled = true;
                        LoginSignIn.Visible = true;
                        PasswordSignIn.Enabled = true;
                        PasswordSignIn.Visible = true;
                        signInButton.Enabled = true;
                        signInButton.Visible = true;
                        signUpButton.Enabled = false;
                        signUpButton.Visible = false;
                        Program.setRole(Roles.Administrator);
                        break;
                    }
            }
        }

        private void signUpButton_Click(object? sender, EventArgs e)
        {
            CustomerSignUpForm csform = new CustomerSignUpForm();
            csform.Show();
            this.Hide();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            Program.setAuthenticatedUser(Program.getUserAuthorization().Authorize(LoginSignIn.Text,PasswordSignIn.Text));
            if (Program.getAuthenticatedUser().Role == Roles.Customer)
            {
                CustomerMainForm cform = new CustomerMainForm();
                cform.Show();
                this.Hide();
            }else if (Program.getAuthenticatedUser().Role == Roles.Barber)
            {
                BarberMainForm bform = new BarberMainForm();
                bform.Show();
                this.Hide();
            }else if (Program.getAuthenticatedUser().Role == Roles.Administrator)
            {
                AdministratorMainForm aform = new AdministratorMainForm();
                aform.Show();
                this.Hide();
            }
        }
    }
}
