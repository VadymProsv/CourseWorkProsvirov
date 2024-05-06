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
    public partial class AddEditOrder : Form
    {
        public bool au; //0 - add
        public AddEditOrder()
        {
            InitializeComponent();
            LoadLocationsIntoComboBox();
            LoadServicesIntoComboBox();
        }

        public AddEditOrder(bool au)
        {
            this.au = au;
            InitializeComponent();
            LoadLocationsIntoComboBox();
            LoadServicesIntoComboBox();
        }

        private void LoadLocationsIntoComboBox()
        {
            string connectionString = Program.getUserAuthorization().ConnectionString;
            string query = "SELECT LocationID, Address FROM Locations";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Налаштування ComboBox
                    allLocations.DataSource = dt;
                    allLocations.DisplayMember = "Address"; // Текст, який буде відображатися
                    allLocations.ValueMember = "LocationID"; // Значення, яке буде пов'язане з кожним елементом
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading locations: " + ex.Message);
                }
            }
        }

        private void allLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (allLocations.SelectedItem != null)
            {
                // Припускаємо, що ValueMember встановлено на "LocationID"
                int locationId = (int)allLocations.SelectedValue;
                LoadBarbersForLocation(locationId);
            }
        }

        private void LoadBarbersForLocation(int locationId)
        {
            string connectionString = Program.getUserAuthorization().ConnectionString;
            string query = "SELECT BarberID, FirstName FROM Barbers WHERE LocationID = @LocationID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@LocationID", locationId);

                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Налаштування ComboBox
                    LocatedBarbers.DataSource = dt;
                    LocatedBarbers.DisplayMember = "FirstName"; // Текст, який буде відображатися
                    LocatedBarbers.ValueMember = "BarberID"; // Значення, яке буде пов'язане з кожним елементом
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading barbers: " + ex.Message);
                }
            }
        }

        private void LoadServicesIntoComboBox()
        {
            string connectionString = Program.getUserAuthorization().ConnectionString;
            string query = "SELECT ServiceID, Name FROM Services";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Налаштування ComboBox
                    allServices.DataSource = dt;
                    allServices.DisplayMember = "Name"; // Текст, який буде відображатися
                    allServices.ValueMember = "ServiceID"; // Значення, яке буде пов'язане з кожним елементом
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading services: " + ex.Message);
                }
            }
        }

        // Перевірка доступності барбера
        public static bool CheckBarberAvailability(int barberId, DateTime appointmentDate, string connectionString)
        {
            DateTime appointmentEndTime = appointmentDate.AddHours(1);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var sql = @"
                SELECT COUNT(*)
                FROM Orders
                WHERE BarberID = @BarberID AND NOT (
                    DateTime >= @AppointmentEndTime OR
                    DATEADD(hour, 1, DateTime) <= @AppointmentTime
                );";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@BarberID", barberId);
                    command.Parameters.AddWithValue("@AppointmentTime", appointmentDate);
                    command.Parameters.AddWithValue("@AppointmentEndTime", appointmentEndTime);
                    int overlappingAppointments = (int)command.ExecuteScalar();
                    return overlappingAppointments == 0;
                }
            }
        }

        // Створення або оновлення замовлення
        public static void CreateOrUpdateOrder(Order order, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Перш перевіряємо, чи барбер доступний для нового часу замовлення
                if (CheckBarberAvailability(order.BarberID, order.DateTime, connectionString))
                {
                    // Вибір назви збереженої процедури на основі OrderID
                    var procedureName = order.OrderID == 0 ? "AddOrder" : "UpdateOrder";
                    using (SqlCommand command = new SqlCommand(procedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // Параметр для Update
                        if (order.OrderID != 0)
                        {
                            command.Parameters.AddWithValue("@OrderID", order.OrderID);
                        }
                        // Загальні параметри для Add і Update
                        command.Parameters.AddWithValue("@CustomerID", order.CustomerID);
                        command.Parameters.AddWithValue("@BarberID", order.BarberID);
                        command.Parameters.AddWithValue("@ServiceID", order.ServiceID);
                        command.Parameters.AddWithValue("@OrderDateTime", order.DateTime);

                        

                        // Виконання збереженої процедури
                        command.ExecuteNonQuery();
                    }
                }
                else
                {
                    throw new Exception("Barber is not available at the selected time.");
                }
            }
        }


        private void apply_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value; ;
            MessageBox.Show(selectedDate.ToString());

            if (au == false)
            {
                Order order = new Order(0, Program.getAuthenticatedUser().UserId,
                    Convert.ToInt32(LocatedBarbers.SelectedValue),
                    Convert.ToInt32(allServices.SelectedValue), selectedDate);
                CreateOrUpdateOrder(order, Program.getUserAuthorization().ConnectionString);
            }
            else
            {
                Order order = new Order(Convert.ToInt32(CustomerMainForm.cOrders.Rows[0].Cells[0].Value), Program.getAuthenticatedUser().UserId,
                    Convert.ToInt32(LocatedBarbers.SelectedValue),
                    Convert.ToInt32(allServices.SelectedValue), selectedDate);
                CreateOrUpdateOrder(order, Program.getUserAuthorization().ConnectionString);
            }
            CustomerMainForm aeoform = new CustomerMainForm();
            aeoform.Show();
            this.Hide();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            CustomerMainForm aeoform = new CustomerMainForm();
            aeoform.Show();
            this.Hide();
        }
    }
}
