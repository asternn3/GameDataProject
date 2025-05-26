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
    public partial class Form4 : Form
    {
        string connectionString = "Server=localhost\\SQLEXPRESS;Database=GameDataProjectDb;Trusted_Connection=True;TrustServerCertificate=True;";
        private int selectedGenreId = -1;
        public Form4()
        {
            InitializeComponent();
        }

        private void labelGames_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void labelLog_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void labelLogout_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void labelX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string genreName = textBoxGenre.Text.Trim();
            if (string.IsNullOrWhiteSpace(genreName))
            {
                MessageBox.Show("Please enter a genre.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string countQuery = "SELECT COUNT(*) FROM Genres";
                    using (SqlCommand countCmd = new SqlCommand(countQuery, conn))
                    {
                        int rowCount = (int)countCmd.ExecuteScalar();
                        if (rowCount == 0)
                        {
                            string reseedQuery = "DBCC CHECKIDENT ('Genres', RESEED, 0)";
                            using (SqlCommand reseedCmd = new SqlCommand(reseedQuery, conn))
                            {
                                reseedCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    //Genre kontrolü
                    string checkQuery = "SELECT COUNT(*) FROM Genres WHERE genre_name = @genre_name";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@genre_name", genreName);
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("This genre already exists.");
                            return;
                        }
                    }

                    //Yeni genre
                    string insertQuery = "INSERT INTO Genres (genre_name) VALUES (@genre_name)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@genre_name", genreName);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Genre added successfully.");
                textBoxGenre.Clear();
                LoadGenresFromDb();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadGenresFromDb()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT genre_id, genre_name FROM Genres ORDER BY genre_id";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewGenres.DataSource = dt;

                if (dataGridViewGenres.Columns.Contains("genre_id"))
                    dataGridViewGenres.Columns["genre_id"].HeaderText = "ID";
                if (dataGridViewGenres.Columns.Contains("genre_name"))
                    dataGridViewGenres.Columns["genre_name"].HeaderText = "Genre";
                dataGridViewGenres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadGenresFromDb();
            buttonSave.Visible = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewGenres.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewGenres.SelectedRows[0];

                // Burada boş bir satır seçildi mi kontrol ediyoruz
                if (selectedRow.Cells["genre_id"].Value == DBNull.Value || selectedRow.Cells["genre_id"].Value == null)
                {
                    MessageBox.Show("Please select a valid row to delete.");
                    return;
                }

                int genreId = Convert.ToInt32(selectedRow.Cells["genre_id"].Value);

                var result = MessageBox.Show("Are you sure you want to delete this genre?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();

                            // Bu genre'ı sil
                            string deleteGenre = "DELETE FROM Genres WHERE genre_id = @genre_id";
                            using (SqlCommand cmd = new SqlCommand(deleteGenre, conn))
                            {
                                cmd.Parameters.AddWithValue("@genre_id", genreId);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        LoadGenresFromDb();
                        MessageBox.Show("Genre deleted successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a genre to delete.");
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewGenres.SelectedRows.Count > 0)
            {
                buttonSave.Visible = true;
                DataGridViewRow row = dataGridViewGenres.SelectedRows[0];
                object cellValue = row.Cells["genre_id"].Value;

                if (cellValue == DBNull.Value || cellValue == null)
                {
                    MessageBox.Show("You cannot edit a row that does not exist in the database.");
                    return;
                }

                selectedGenreId = Convert.ToInt32(cellValue);
                textBoxGenre.Text = row.Cells["genre_name"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please select a genre to edit.");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (selectedGenreId == -1)
            {
                MessageBox.Show("Please select a row to edit first (use the Edit button).");
                return;
            }

            string genreName = textBoxGenre.Text.Trim();
            if (string.IsNullOrWhiteSpace(genreName))
            {
                MessageBox.Show("Please enter a genre.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string updateQuery = "UPDATE Genres SET genre_name = @genre_name WHERE genre_id = @genre_id";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@genre_name", genreName);
                        cmd.Parameters.AddWithValue("@genre_id", selectedGenreId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Genre updated successfully.");
                textBoxGenre.Clear();
                selectedGenreId = -1;
                LoadGenresFromDb();
                buttonSave.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string genreName = textBoxSearch.Text.Trim();

            if (string.IsNullOrEmpty(genreName))
            {
                MessageBox.Show("Please enter a genre name to search.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT genre_id FROM Genres WHERE genre_name = @name";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", genreName);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            int genreId = Convert.ToInt32(result);
                            MessageBox.Show($"The ID of the genre '{genreName}' is: {genreId}", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBoxSearch.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No genre found with this name.");
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
