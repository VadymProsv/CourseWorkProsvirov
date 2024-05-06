using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkProsvirov
{
    public partial class CustomerSignUpForm : Form
    {
        public CustomerSignUpForm()
        {
            InitializeComponent();
        }

        private void CPasswordSignUp_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelSignUpButton_Click(object sender, EventArgs e)
        {
            SigInUpForm cisform = new SigInUpForm();
            cisform.Show();
            this.Hide();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            Customer.AddCustomer(Program.getUserAuthorization().ConnectionString,
                new Customer(0,CFirstNameSignUp.Text,CLastNameSignUp.Text,CPhoneSignUp.Text,CEmailSignUp.Text,CPasswordSignUp.Text));
            MessageBox.Show("Succesfully signed up", "Customer sign up", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
