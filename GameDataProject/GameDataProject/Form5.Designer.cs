namespace GameDataProject
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            panel3 = new Panel();
            label13 = new Label();
            pictureBox6 = new PictureBox();
            label6 = new Label();
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            labelLog = new Label();
            pictureBox3 = new PictureBox();
            labelGenres = new Label();
            pictureBox2 = new PictureBox();
            labelGames = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            labelLogout = new Label();
            labelAdminLogs = new Label();
            dataGridViewAdmins = new DataGridView();
            buttonSearch = new Button();
            labelSearch = new Label();
            textBoxSearch = new TextBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAdmins).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.Teal;
            panel3.Controls.Add(label13);
            panel3.Controls.Add(pictureBox6);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(208, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(861, 43);
            panel3.TabIndex = 38;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Cursor = Cursors.Hand;
            label13.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label13.ForeColor = Color.White;
            label13.Location = new Point(822, 7);
            label13.Name = "label13";
            label13.Size = new Size(26, 25);
            label13.TabIndex = 9;
            label13.Text = "X";
            label13.Click += label13_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(25, 6);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(30, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 1;
            pictureBox6.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.White;
            label6.Location = new Point(81, 10);
            label6.Name = "label6";
            label6.Size = new Size(258, 21);
            label6.TabIndex = 1;
            label6.Text = "Game Managment System v1.0";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(labelLog);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(labelGenres);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(labelGames);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(208, 577);
            panel1.TabIndex = 37;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(61, 22);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(65, 65);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(19, 313);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // labelLog
            // 
            labelLog.AutoSize = true;
            labelLog.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelLog.ForeColor = Color.White;
            labelLog.Location = new Point(82, 325);
            labelLog.Name = "labelLog";
            labelLog.Size = new Size(109, 22);
            labelLog.TabIndex = 7;
            labelLog.Text = "Admin Log";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(19, 225);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // labelGenres
            // 
            labelGenres.AutoSize = true;
            labelGenres.Cursor = Cursors.Hand;
            labelGenres.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelGenres.ForeColor = Color.White;
            labelGenres.Location = new Point(82, 237);
            labelGenres.Name = "labelGenres";
            labelGenres.Size = new Size(76, 22);
            labelGenres.TabIndex = 5;
            labelGenres.Text = "Genres";
            labelGenres.Click += labelGenres_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(18, 134);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // labelGames
            // 
            labelGames.AutoSize = true;
            labelGames.Cursor = Cursors.Hand;
            labelGames.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelGames.ForeColor = Color.White;
            labelGames.Location = new Point(83, 149);
            labelGames.Name = "labelGames";
            labelGames.Size = new Size(76, 22);
            labelGames.TabIndex = 3;
            labelGames.Text = "Games";
            labelGames.Click += labelGames_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkCyan;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(labelLogout);
            panel2.Cursor = Cursors.Hand;
            panel2.Location = new Point(0, 525);
            panel2.Name = "panel2";
            panel2.Size = new Size(208, 51);
            panel2.TabIndex = 1;
            panel2.Click += panel2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(46, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelLogout
            // 
            labelLogout.AutoSize = true;
            labelLogout.Cursor = Cursors.Hand;
            labelLogout.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelLogout.ForeColor = Color.White;
            labelLogout.Location = new Point(85, 14);
            labelLogout.Name = "labelLogout";
            labelLogout.Size = new Size(75, 22);
            labelLogout.TabIndex = 1;
            labelLogout.Text = "Logout";
            labelLogout.Click += labelLogout_Click;
            // 
            // labelAdminLogs
            // 
            labelAdminLogs.AutoSize = true;
            labelAdminLogs.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            labelAdminLogs.Location = new Point(486, 84);
            labelAdminLogs.Name = "labelAdminLogs";
            labelAdminLogs.Size = new Size(297, 23);
            labelAdminLogs.TabIndex = 41;
            labelAdminLogs.Text = "Logged-in Account Information";
            // 
            // dataGridViewAdmins
            // 
            dataGridViewAdmins.BackgroundColor = Color.White;
            dataGridViewAdmins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAdmins.GridColor = Color.White;
            dataGridViewAdmins.Location = new Point(341, 160);
            dataGridViewAdmins.Name = "dataGridViewAdmins";
            dataGridViewAdmins.Size = new Size(593, 295);
            dataGridViewAdmins.TabIndex = 42;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.Teal;
            buttonSearch.Cursor = Cursors.Hand;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonSearch.ForeColor = SystemColors.Control;
            buttonSearch.Location = new Point(956, 537);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(72, 25);
            buttonSearch.TabIndex = 45;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Century Gothic", 11.25F);
            labelSearch.Location = new Point(833, 474);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(60, 20);
            labelSearch.TabIndex = 44;
            labelSearch.Text = "Search";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxSearch.Location = new Point(833, 500);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(165, 25);
            textBoxSearch.TabIndex = 43;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 577);
            Controls.Add(buttonSearch);
            Controls.Add(labelSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(dataGridViewAdmins);
            Controls.Add(labelAdminLogs);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            Load += Form5_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAdmins).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel3;
        private PictureBox pictureBox6;
        private Label label6;
        private Panel panel1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Label labelLog;
        private PictureBox pictureBox3;
        private Label labelGenres;
        private PictureBox pictureBox2;
        private Label labelGames;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label labelLogout;
        private ListBox listTopSale;
        private ListBox listTopPrice;
        private Label labelAdminLogs;
        private Label labelMostRev;
        private Label label13;
        private DataGridView dataGridViewAdmins;
        private Button buttonSearch;
        private Label labelSearch;
        private TextBox textBoxSearch;
    }
}