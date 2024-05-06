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
    public partial class AdministratorMainForm : Form
    {
        public AdministratorMainForm()
        {
            InitializeComponent();
        }

        public void LoadDataIntoDataGridView(string tableName, string connectionString)
        {
            dataGridView.Columns.Clear();
            string query = $"SELECT * FROM {tableName}";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridView.DataSource = table;
                        dataGridView.AutoGenerateColumns = true;
                        dataGridView.AutoResizeColumns();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data from {tableName}: " + ex.Message);
            }
        }
        private SqlDataAdapter adapter;
        private DataTable dataTable;

        public void DBLoad(string tableName, string connectionString)
        {
            var selectCommand = new SqlCommand($"SELECT * FROM {tableName}", new SqlConnection(connectionString));
            adapter = new SqlDataAdapter(selectCommand);

            // Використання SqlCommandBuilder для автоматичного створення Insert, Update, Delete команд
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

            // Завантаження та зв'язування даних
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            dataGridView.AutoGenerateColumns = true;

            // Автоматичне створення команд за допомогою SqlCommandBuilder
            adapter.InsertCommand = commandBuilder.GetInsertCommand();
            adapter.UpdateCommand = commandBuilder.GetUpdateCommand();
            adapter.DeleteCommand = commandBuilder.GetDeleteCommand();
        }

        public void UpdateDatabase()
        {
            adapter.Update(dataTable);
        }

        private void Customers_Click(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView("Customers", Program.getUserAuthorization().ConnectionString);
            DBLoad("Customers", Program.getUserAuthorization().ConnectionString);
        }

        private void Barbers_Click(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView("Barbers", Program.getUserAuthorization().ConnectionString);
            DBLoad("Barbers", Program.getUserAuthorization().ConnectionString);
        }

        private void Administrators_Click(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView("Administrators", Program.getUserAuthorization().ConnectionString);
            DBLoad("Administrators", Program.getUserAuthorization().ConnectionString);
        }

        private void Services_Click(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView("Services", Program.getUserAuthorization().ConnectionString);
            DBLoad("Services", Program.getUserAuthorization().ConnectionString);
        }

        private void Orders_Click(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView("Orders", Program.getUserAuthorization().ConnectionString);
            DBLoad("Orders", Program.getUserAuthorization().ConnectionString);
        }

        private void Transaction_Click(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView("Transactions", Program.getUserAuthorization().ConnectionString);
            DBLoad("Transactions", Program.getUserAuthorization().ConnectionString);
        }

        private void Reviews_Click(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView("Reviews", Program.getUserAuthorization().ConnectionString);
            DBLoad("Reviews", Program.getUserAuthorization().ConnectionString);
        }

        private void Locations_Click(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView("Locations", Program.getUserAuthorization().ConnectionString);
            DBLoad("Locations", Program.getUserAuthorization().ConnectionString);
        }

        private void Regular_Click(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView("RegularDiscounts", Program.getUserAuthorization().ConnectionString);
            DBLoad("RegularDiscounts", Program.getUserAuthorization().ConnectionString);
        }

        private void Irregular_Click(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView("IrregularDiscounts", Program.getUserAuthorization().ConnectionString);
            DBLoad("IrregularDiscounts", Program.getUserAuthorization().ConnectionString);
        }

        private void Analytic_Click(object sender, EventArgs e)
        {

        }

        private void Apply_Click(object sender, EventArgs e)
        {
            adapter.Update(dataTable);
        }
    }
}
