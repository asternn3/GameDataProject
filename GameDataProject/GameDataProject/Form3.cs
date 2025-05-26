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
    public partial class Form3 : Form
    {
        string connectionString = "Server=localhost\\SQLEXPRESS;Database=GameDataProjectDb;Trusted_Connection=True;TrustServerCertificate=True;";
        public Form3()
        {
            InitializeComponent();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void labelGenres_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void labelLog_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                // Check if any of the key fields are null or empty
                if (row.Cells["name"].Value == DBNull.Value || row.Cells["name"].Value == null ||
                    row.Cells["genre"].Value == DBNull.Value || row.Cells["genre"].Value == null ||
                    row.Cells["price"].Value == DBNull.Value || row.Cells["price"].Value == null ||
                    row.Cells["dev_by"].Value == DBNull.Value || row.Cells["dev_by"].Value == null ||
                    row.Cells["release_date"].Value == DBNull.Value || row.Cells["release_date"].Value == null ||
                    row.Cells["TotalQuantity"].Value == DBNull.Value || row.Cells["TotalQuantity"].Value == null)
                {
                    MessageBox.Show("This row contains incomplete data. Please select a valid row to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                buttonSave.Visible = true;
                textBoxUsername.Text = row.Cells["name"].Value.ToString();
                comboBoxGenre.Text = row.Cells["genre"].Value.ToString();
                textBoxPrice.Text = row.Cells["price"].Value.ToString();
                textBoxDevBy.Text = row.Cells["dev_by"].Value.ToString();
                dtpRelDate.Value = Convert.ToDateTime(row.Cells["release_date"].Value);
                textBoxQuantity.Text = row.Cells["TotalQuantity"].Value.ToString();

                selectedGameId = Convert.ToInt32(row.Cells["game_id"].Value);
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private int selectedGameId = -1;

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadGamesFromDb();
            LoadGenresToComboBox();
            buttonSave.Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text) ||
        string.IsNullOrWhiteSpace(comboBoxGenre.Text) ||
        string.IsNullOrWhiteSpace(textBoxPrice.Text) ||
        string.IsNullOrWhiteSpace(textBoxQuantity.Text) ||
        string.IsNullOrWhiteSpace(textBoxDevBy.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!decimal.TryParse(textBoxPrice.Text, out decimal price))
            {
                MessageBox.Show("Enter a valid number for the price field.");
                return;
            }

            if (!int.TryParse(textBoxQuantity.Text, out int quantity))
            {
                MessageBox.Show("Enter a valid number for the Quantity field.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // 🟡 EKLEMEDEN ÖNCE KONTROL: Aynı kayıt var mı?
                    string checkQuery = @"
                        SELECT COUNT(*) FROM Games g
                        INNER JOIN Sale s ON g.game_id = s.game_id
                        WHERE g.name = @name AND g.genre = @genre AND g.price = @price
                            AND CAST(g.release_date AS DATE) = @release_date
                            AND g.dev_by = @dev_by
                            AND s.quantity = @quantity";

                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@name", textBoxUsername.Text);
                        checkCmd.Parameters.AddWithValue("@genre", comboBoxGenre.Text);
                        checkCmd.Parameters.AddWithValue("@price", price);
                        checkCmd.Parameters.AddWithValue("@release_date", dtpRelDate.Value.Date);
                        checkCmd.Parameters.AddWithValue("@dev_by", textBoxDevBy.Text);
                        checkCmd.Parameters.AddWithValue("@quantity", quantity);

                        int existingCount = (int)checkCmd.ExecuteScalar();
                        if (existingCount > 0)
                        {
                            MessageBox.Show("This game has already been added.");
                            return; // İşlemi durdur
                        }
                    }

                    // 🟢 TABLO BOŞSA RESEED ET
                    string countQuery = "SELECT COUNT(*) FROM Games";
                    SqlCommand countCmd = new SqlCommand(countQuery, conn);
                    int rowCount = (int)countCmd.ExecuteScalar();

                    if (rowCount == 0)
                    {
                        SqlCommand resetGames = new SqlCommand("DBCC CHECKIDENT ('Games', RESEED, 0)", conn);
                        resetGames.ExecuteNonQuery();

                        SqlCommand resetSales = new SqlCommand("DBCC CHECKIDENT ('Sale', RESEED, 0)", conn);
                        resetSales.ExecuteNonQuery();
                    }

                    // 🟢 OYUN EKLE
                    string gameQuery = "INSERT INTO Games (name, genre, price, release_date, dev_by) " +
                                        "OUTPUT INSERTED.game_id " +
                                        "VALUES (@name, @genre, @price, @release_date, @dev_by)";

                    int gameId;
                    using (SqlCommand cmd = new SqlCommand(gameQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", textBoxUsername.Text);
                        cmd.Parameters.AddWithValue("@genre", comboBoxGenre.Text);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@release_date", dtpRelDate.Value);
                        cmd.Parameters.AddWithValue("@dev_by", textBoxDevBy.Text);

                        gameId = (int)cmd.ExecuteScalar();
                    }

                    // 🟢 Sale’a Ekle
                    string saleQuery = "INSERT INTO Sale (game_id, quantity) VALUES (@game_id, @quantity)";
                    using (SqlCommand cmd = new SqlCommand(saleQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@game_id", gameId);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Game added successfully.");
                    ClearInputs();
                    LoadGamesFromDb();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadGamesFromDb()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                g.game_id,
                g.name,
                g.genre,
                g.price,
                g.release_date,
                g.dev_by,
                ISNULL(SUM(s.quantity), 0) AS TotalQuantity
            FROM 
                Games g
            LEFT JOIN 
                Sale s ON g.game_id = s.game_id
            GROUP BY 
                g.game_id, g.name, g.genre, g.price, g.release_date, g.dev_by";
                SqlDataAdapter sqlda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                dataGridView1.DataSource = dt;

                if (dataGridView1.Columns.Contains("game_id"))
                    dataGridView1.Columns["game_id"].HeaderText = "ID";
                if (dataGridView1.Columns.Contains("name"))
                    dataGridView1.Columns["name"].HeaderText = "Game";
                if (dataGridView1.Columns.Contains("genre"))
                    dataGridView1.Columns["genre"].HeaderText = "Genre";
                if (dataGridView1.Columns.Contains("price"))
                    dataGridView1.Columns["price"].HeaderText = "Price";
                if (dataGridView1.Columns.Contains("release_date"))
                    dataGridView1.Columns["release_date"].HeaderText = "Release Date";
                if (dataGridView1.Columns.Contains("dev_by"))
                    dataGridView1.Columns["dev_by"].HeaderText = "Developed By";
                if (dataGridView1.Columns.Contains("TotalQuantity"))
                    dataGridView1.Columns["TotalQuantity"].HeaderText = "Quantity Sold";
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçilen satırdan game_id al
                int gameId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["game_id"].Value);

                var result = MessageBox.Show("Are you sure you want to delete this game?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        // Sale tablosundan ilişkili kayıtları sil (manuel)
                        string deleteSales = "DELETE FROM Sale WHERE game_id = @game_id";
                        using (SqlCommand cmd = new SqlCommand(deleteSales, conn))
                        {
                            cmd.Parameters.AddWithValue("@game_id", gameId);
                            cmd.ExecuteNonQuery();
                        }

                        // Games tablosundan sil
                        string deleteGame = "DELETE FROM Games WHERE game_id = @game_id";
                        using (SqlCommand cmd = new SqlCommand(deleteGame, conn))
                        {
                            cmd.Parameters.AddWithValue("@game_id", gameId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // DataGridView güncelle
                    LoadGamesFromDb();
                    MessageBox.Show("Game deleted successfully.");
                }
            }
            else
            {
                MessageBox.Show("Please select a game to delete.");
            }
        }
        private void ClearInputs()
        {
            textBoxUsername.Clear();
            comboBoxGenre.Text = "";
            textBoxPrice.Clear();
            textBoxQuantity.Clear();
            textBoxDevBy.Clear();
            dtpRelDate.Value = DateTime.Now;
        }
        private void LoadGenresToComboBox()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT genre_name FROM Genres ORDER BY genre_name";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    comboBoxGenre.Items.Clear();
                    while (reader.Read())
                    {
                        comboBoxGenre.Items.Add(reader.GetString(0));
                    }
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (selectedGameId == -1)
            {
                MessageBox.Show("Please select a row to edit first.");
                return;
            }

            // Alanların kontrolü
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text) ||
                string.IsNullOrWhiteSpace(comboBoxGenre.Text) ||
                string.IsNullOrWhiteSpace(textBoxPrice.Text) ||
                string.IsNullOrWhiteSpace(textBoxQuantity.Text) ||
                string.IsNullOrWhiteSpace(textBoxDevBy.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!decimal.TryParse(textBoxPrice.Text, out decimal price))
            {
                MessageBox.Show("Enter a valid number for the price field.");
                return;
            }

            if (!int.TryParse(textBoxQuantity.Text, out int quantity))
            {
                MessageBox.Show("Enter a valid number for the Quantity field.");
                return;
            }

            // Güncelleme sorgusu
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string updateGameQuery = @"
                UPDATE Games 
                SET name = @name, genre = @genre, price = @price, 
                    release_date = @release_date, dev_by = @dev_by
                WHERE game_id = @game_id";

                    using (SqlCommand cmd = new SqlCommand(updateGameQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", textBoxUsername.Text);
                        cmd.Parameters.AddWithValue("@genre", comboBoxGenre.Text);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@release_date", dtpRelDate.Value);
                        cmd.Parameters.AddWithValue("@dev_by", textBoxDevBy.Text);
                        cmd.Parameters.AddWithValue("@game_id", selectedGameId);
                        cmd.ExecuteNonQuery();
                    }

                    // Satış miktarını da güncelle (Sale tablosu)
                    string updateSaleQuery = "UPDATE Sale SET quantity = @quantity WHERE game_id = @game_id";
                    using (SqlCommand cmd = new SqlCommand(updateSaleQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@game_id", selectedGameId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Game updated successfully.");
                    LoadGamesFromDb(); // Gridview’i yenile
                    ClearInputs();     // textbox’ları temizle
                    buttonSave.Visible = false;
                    selectedGameId = -1; // id’yi sıfırla
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string gameName = textBoxSearch.Text.Trim();

            if (string.IsNullOrEmpty(gameName))
            {
                MessageBox.Show("Please enter a game name to search.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT game_id FROM Games WHERE name = @name";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", gameName);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            int gameId = Convert.ToInt32(result);
                            MessageBox.Show($"The ID of the game '{gameName}' is: {gameId}", "Founded",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            textBoxSearch.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No game found with this name.");
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
