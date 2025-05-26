using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace GameDataProject
{
    public partial class Form5 : Form
    {
        string connectionString = "Server=localhost\\SQLEXPRESS;Database=GameDataProjectDb;Trusted_Connection=True;TrustServerCertificate=True;";
        public Form5()
        {
            InitializeComponent();
        }

        private void labelGenres_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void labelGames_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void labelLogout_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            LoadAdminsFromDb();
            dataGridViewAdmins.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridViewAdmins.GridColor = Color.Black;
            dataGridViewAdmins.BorderStyle = BorderStyle.FixedSingle;
        }

        private void LoadAdminsFromDb()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT admin_id, username, password FROM Admin ORDER BY admin_id";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewAdmins.DataSource = dt;

                // Başlıkları ayarlayalım
                if (dataGridViewAdmins.Columns.Contains("admin_id"))
                    dataGridViewAdmins.Columns["admin_id"].HeaderText = "ID";
                if (dataGridViewAdmins.Columns.Contains("username"))
                    dataGridViewAdmins.Columns["username"].HeaderText = "Username";
                if (dataGridViewAdmins.Columns.Contains("password"))
                    dataGridViewAdmins.Columns["password"].HeaderText = "Password";
                dataGridViewAdmins.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string username = textBoxSearch.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username to search.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT admin_id FROM Admin WHERE username = @username";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            int userId = Convert.ToInt32(result);
                            MessageBox.Show($"The ID of the user '{username}' is: {userId}", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBoxSearch.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No user found with this username.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
