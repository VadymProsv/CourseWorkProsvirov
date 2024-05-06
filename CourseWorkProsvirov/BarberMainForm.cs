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

namespace CourseWorkProsvirov
{
    public partial class BarberMainForm : Form
    {
        public BarberMainForm()
        {
            InitializeComponent();
            LoadOrdersForBarber(Program.getAuthenticatedUser().UserId);
        }
        public void LoadOrdersForBarber(int barberId)
        {
            string connectionString = Program.getUserAuthorization().ConnectionString;
            string query = @"
            SELECT 
                o.OrderID,
                o.DateTime,
                s.Name AS ServiceName, 
                c.FirstName AS CustomerFirstName
            FROM 
                Orders o
                JOIN Services s ON o.ServiceID = s.ServiceID
                JOIN Customers c ON o.CustomerID = c.CustomerID
            WHERE 
                o.BarberID = @BarberID
            ORDER BY
            o.DateTime DESC";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BarberID", barberId);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    System.Data.DataTable table = new System.Data.DataTable();
                    adapter.Fill(table);
                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show("No data found for the given Barber ID.");
                    }
                    else
                    {
                        bOrders.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during database operation: " + ex.Message);
            }
        }
        private void reload_Click(object sender, EventArgs e)
        {
            LoadOrdersForBarber(Program.getAuthenticatedUser().UserId);
        }
    }
}
