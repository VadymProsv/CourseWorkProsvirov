using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CourseWorkProsvirov
{
    public class AuthenticatedUser
    {
        public int UserId { get; set; }
        public Roles Role { get; set; }
        public bool IsAuthenticated { get; set; }
    }

    public class UserAuthorization
    {
        private string connectionString;

        public UserAuthorization(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }
        public string ConnectionString { get { return connectionString; } set { connectionString = value; } }
        public AuthenticatedUser Authorize(string phone, string password)
        {
            // Спроба авторизації як клієнт
            var customerId = AuthorizeAsRole(phone, password, "Customer");
            if (customerId != -1)
                return new AuthenticatedUser { UserId = customerId, Role = Roles.Customer, IsAuthenticated = true };

            // Спроба авторизації як перукар
            var barberId = AuthorizeAsRole(phone, password, "Barber");
            if (barberId != -1)
                return new AuthenticatedUser { UserId = barberId, Role = Roles.Barber, IsAuthenticated = true };

            // Спроба авторизації як адміністратор
            var adminId = AuthorizeAsRole(phone, password, "Administrator");
            if (adminId != -1)
                return new AuthenticatedUser { UserId = adminId, Role = Roles.Administrator, IsAuthenticated = true };

            MessageBox.Show("Incorrect Phone or Password", "Authorization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return new AuthenticatedUser { UserId = -1, Role = Roles.None, IsAuthenticated = false };
        }

        private int AuthorizeAsRole(string phone, string password, string tableName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = $"SELECT {tableName}ID FROM {tableName}s WHERE Phone = @Phone AND Password = @Password";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@Password", password); // Нагадування: паролі мають бути захешовані!

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader.GetInt32(0); // Повертаємо ID користувача
                    }
                }
            }

            return -1; // Повертаємо -1 як ознаку того, що користувач не авторизований
        }
    }

}
