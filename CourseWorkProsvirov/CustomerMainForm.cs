using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace CourseWorkProsvirov
{
    public partial class CustomerMainForm : Form
    {
        public CustomerMainForm()
        {
            InitializeComponent();
            LoadOrdersForCustomer(Program.getAuthenticatedUser().UserId);
            LoadBarbersIntoComboBox();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoadOrdersForCustomer(int customerId)
        {
            string connectionString = Program.getUserAuthorization().ConnectionString;
            string query = @"
            SELECT 
                o.OrderID,
                o.DateTime,
                s.Name AS ServiceName, 
                b.FirstName AS BarberFirstName, 
                t.Total
            FROM 
                Orders o
                JOIN Barbers b ON o.BarberID = b.BarberID
                JOIN Services s ON o.ServiceID = s.ServiceID
                JOIN Transactions t ON o.OrderID = t.OrderID
            WHERE 
                o.CustomerID = @CustomerID
            ORDER BY
            o.DateTime DESC";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", customerId);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    System.Data.DataTable table = new System.Data.DataTable();
                    adapter.Fill(table);
                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show("No data found for the given Customer ID.");
                    }
                    else
                    {
                        cOrders.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during database operation: " + ex.Message);
            }
        }


        // Скасування замовлення
        public static void CancelOrder(int orderId, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var sql = "DeleteOrder"; // Припустимо, що DeleteOrder - це назва збереженої процедури для скасування
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@OrderID", orderId);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void cOrderUpdate_Click(object sender, EventArgs e)
        {
            AddEditOrder aeoform = new AddEditOrder(true);
            aeoform.Show();
            this.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddEditOrder aeoform = new AddEditOrder(false);
            aeoform.Show();
            this.Hide();
        }

        private void cOrderCancel_Click(object sender, EventArgs e)
        {
            CancelOrder(Convert.ToInt32(cOrders.Rows[0].Cells[0].Value), Program.getUserAuthorization().ConnectionString);
            CustomerMainForm aeoform = new CustomerMainForm();
            aeoform.Show();
            this.Hide();
        }
        private void LoadBarbersIntoComboBox()
        {
            string connectionString = Program.getUserAuthorization().ConnectionString;
            string query = "SELECT BarberID, FirstName FROM Barbers";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Налаштування ComboBox
                    RBarbers.DataSource = dt;
                    RBarbers.DisplayMember = "FirstName"; // Текст, який буде відображатися
                    RBarbers.ValueMember = "BarberID"; // Значення, яке буде пов'язане з кожним елементом
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading barbers: " + ex.Message);
                }
            }
        }
        public void LoadReviewsForBarber(int barberId, string connectionString)
        {
            string query = @"
        SELECT 
            r.ReviewID, 
            c.FirstName, 
            r.Rating, 
            r.Comment
        FROM 
            Reviews r
            JOIN Orders o ON r.OrderID = o.OrderID
            JOIN Customers c ON o.CustomerID = c.CustomerID
        WHERE 
            o.BarberID = @BarberID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BarberID", barberId);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        reviews.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during database operation: " + ex.Message);
            }
        }

        private void showReviews_Click(object sender, EventArgs e)
        {
            LoadReviewsForBarber(Convert.ToInt32(RBarbers.SelectedValue),
                Program.getUserAuthorization().ConnectionString);
        }
    }

}
