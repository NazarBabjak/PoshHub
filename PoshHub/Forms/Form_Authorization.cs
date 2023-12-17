using MySql.Data.MySqlClient;
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

namespace PoshHub
{
    public partial class Form_Authorization : Form
    {
        private Form_Home home;
        private Form_Registration registration;
        public Form_Authorization(Form_Home h)
        {
            home= h;
            InitializeComponent();
            home.SetBackground();
            this.TopMost = true;
        }
        public Form_Authorization()
        {
            InitializeComponent();
            home.SetBackground();
        }

        private void Form_Authorization_Load(object sender, EventArgs e)
        {
            
        }

        private void button_CloseAuthorization_Click(object sender, EventArgs e)
        {
            home.DeleteBackground();
            this.Close();
        }

        private void button_showPassword_Click(object sender, EventArgs e)
{
            string resourceName;

            if (this.text_password.UseSystemPasswordChar)
            {
                 this.text_password.UseSystemPasswordChar = false;
                resourceName = "PasswordNotView";
            }
            else
            {
                this.text_password.UseSystemPasswordChar = true;
                resourceName = "PasswordView";
            }

            System.Drawing.Bitmap image = (System.Drawing.Bitmap)Properties.Resources.ResourceManager.GetObject(resourceName);
            button_showPassword.Image = image;
}


        private void button_Welcome_Click(object sender, EventArgs e)
        {
            string constr = "Server=localhost;Database=poshhub;User ID=root;Password=123456n;";
            if (IsUserInDatabase(constr, text_number.Text, text_password.Text))
            {
                // Код, який виконується, якщо користувача знайдено в базі даних
                this.Close();
                home.DeleteBackground();
                home.Activate();
            }
            else
            {
                // Код, який виконується, якщо користувача не знайдено в базі даних
                MessageBox.Show("Користувача не знайдено!");
            }

        }

        private void button_RegistrationWelcome_Click(object sender, EventArgs e)
        {
            registration = new Form_Registration(this);

            registration.StartPosition = FormStartPosition.Manual;
            registration.Left = this.Left;
            registration.Top = this.Top;

            registration.Show();
        }

        static bool IsUserInDatabase(string connectionString, string username, string password)
        {
            try
            {

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Перевірка наявності користувача в базі даних за ім'ям та паролем
                    string query = "SELECT COUNT(*) FROM users WHERE username = @Username AND password = @Password";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        // Якщо count > 0, користувач існує в базі даних
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при виконанні операції з базою даних: " + ex.Message);
                return false; // або обробте помилку відповідно до вашого сценарію
            }
        }

    }
}
