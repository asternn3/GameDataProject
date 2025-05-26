using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.Data.SqlClient;


namespace GameDataProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            int textPass = textBoxPassword.Text.Length;
            int textUser = textBoxUsername.Text.Length;

            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            bool confirmUser = false;
            bool confirmPass = false;
            if (textUser < 3)
            {
                errorProvider1.SetError(textBoxUsername, "Min 3 char");
            }
            else
            {
                errorProvider1.Clear();
                confirmUser = true;
            }
            if (textPass < 5)
            {
                errorProvider2.SetError(textBoxPassword, "Min 5 char");
            }
            else
            {
                errorProvider2.Clear();
                confirmPass = true;
            }

            if (confirmUser && confirmPass)
            {
                bool alreadyExists = CheckAdminExists(username, password);
                if (!alreadyExists)
                {
                    AddAdmin(username, password);
                }
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
        }
        private bool CheckAdminExists(string username, string password)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=GameDataProjectDb;Trusted_Connection=True;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string checkQuery = "SELECT COUNT(*) FROM Admin WHERE username = @username AND password = @password";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@username", username);
                    checkCmd.Parameters.AddWithValue("@password", password);
                    int count = (int)checkCmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void textBoxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AddAdmin(string username, string password)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=GameDataProjectDb;Trusted_Connection=True;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Boşsa reseed
                string countQuery = "SELECT COUNT(*) FROM Admin";
                using (SqlCommand countCmd = new SqlCommand(countQuery, conn))
                {
                    int rowCount = (int)countCmd.ExecuteScalar();
                    if (rowCount == 0)
                    {
                        string reseedQuery = "DBCC CHECKIDENT ('Admin', RESEED, 0)";
                        using (SqlCommand reseedCmd = new SqlCommand(reseedQuery, conn))
                        {
                            reseedCmd.ExecuteNonQuery();
                        }
                    }
                }

                // Yeni admin ekle
                string insertQuery = "INSERT INTO Admin (username, password) VALUES (@username, @password)";
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@username", username);
                    insertCmd.Parameters.AddWithValue("@password", password);
                    insertCmd.ExecuteNonQuery();
                }
            }
        }
    }
}
