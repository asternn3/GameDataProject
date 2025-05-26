namespace GameDataProject
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            labelGenreList = new Label();
            dataGridViewGenres = new DataGridView();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonEdit = new Button();
            labelEnterGenre = new Label();
            textBoxGenre = new TextBox();
            panel3 = new Panel();
            labelX = new Label();
            pictureBox6 = new PictureBox();
            labelHeader = new Label();
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            labelLog = new Label();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            labelGames = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            labelLogout = new Label();
            buttonSave = new Button();
            textBoxSearch = new TextBox();
            labelSearch = new Label();
            buttonSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenres).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelGenreList
            // 
            labelGenreList.AutoSize = true;
            labelGenreList.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelGenreList.Location = new Point(568, 326);
            labelGenreList.Name = "labelGenreList";
            labelGenreList.Size = new Size(100, 22);
            labelGenreList.TabIndex = 36;
            labelGenreList.Text = "Genre List";
            // 
            // dataGridViewGenres
            // 
            dataGridViewGenres.BackgroundColor = Color.White;
            dataGridViewGenres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGenres.Location = new Point(266, 377);
            dataGridViewGenres.Name = "dataGridViewGenres";
            dataGridViewGenres.Size = new Size(755, 150);
            dataGridViewGenres.TabIndex = 35;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Teal;
            buttonAdd.Cursor = Cursors.Hand;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonAdd.ForeColor = SystemColors.Control;
            buttonAdd.Location = new Point(547, 227);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(145, 32);
            buttonAdd.TabIndex = 34;
            buttonAdd.Text = "Add Genre";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(192, 0, 0);
            buttonDelete.Cursor = Cursors.Hand;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonDelete.ForeColor = SystemColors.Control;
            buttonDelete.Location = new Point(717, 227);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(145, 32);
            buttonDelete.TabIndex = 33;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.FromArgb(0, 192, 192);
            buttonEdit.Cursor = Cursors.Hand;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonEdit.ForeColor = SystemColors.Control;
            buttonEdit.Location = new Point(371, 227);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(145, 32);
            buttonEdit.TabIndex = 32;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // labelEnterGenre
            // 
            labelEnterGenre.AutoSize = true;
            labelEnterGenre.Font = new Font("Century Gothic", 11.25F);
            labelEnterGenre.Location = new Point(545, 96);
            labelEnterGenre.Name = "labelEnterGenre";
            labelEnterGenre.Size = new Size(125, 20);
            labelEnterGenre.TabIndex = 30;
            labelEnterGenre.Text = "Enter the Genre";
            // 
            // textBoxGenre
            // 
            textBoxGenre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxGenre.Location = new Point(545, 128);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(165, 25);
            textBoxGenre.TabIndex = 29;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Teal;
            panel3.Controls.Add(labelX);
            panel3.Controls.Add(pictureBox6);
            panel3.Controls.Add(labelHeader);
            panel3.Location = new Point(208, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(861, 43);
            panel3.TabIndex = 21;
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Cursor = Cursors.Hand;
            labelX.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelX.ForeColor = Color.White;
            labelX.Location = new Point(822, 7);
            labelX.Name = "labelX";
            labelX.Size = new Size(26, 25);
            labelX.TabIndex = 9;
            labelX.Text = "X";
            labelX.Click += labelX_Click;
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
            // labelHeader
            // 
            labelHeader.AutoSize = true;
            labelHeader.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelHeader.ForeColor = Color.White;
            labelHeader.Location = new Point(81, 10);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(258, 21);
            labelHeader.TabIndex = 1;
            labelHeader.Text = "Game Managment System v1.0";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(labelLog);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(labelGames);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(208, 577);
            panel1.TabIndex = 20;
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
            labelLog.Cursor = Cursors.Hand;
            labelLog.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelLog.ForeColor = Color.White;
            labelLog.Location = new Point(82, 325);
            labelLog.Name = "labelLog";
            labelLog.Size = new Size(109, 22);
            labelLog.TabIndex = 7;
            labelLog.Text = "Admin Log";
            labelLog.Click += labelLog_Click;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(82, 237);
            label3.Name = "label3";
            label3.Size = new Size(76, 22);
            label3.TabIndex = 5;
            label3.Text = "Genres";
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
            labelGames.Location = new Point(82, 148);
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
            labelLogout.Click += labelLogout_Click_1;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(0, 192, 192);
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonSave.ForeColor = SystemColors.Control;
            buttonSave.Location = new Point(407, 265);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 37;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Cursor = Cursors.Hand;
            textBoxSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxSearch.Location = new Point(783, 168);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(165, 25);
            textBoxSearch.TabIndex = 38;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Cursor = Cursors.Hand;
            labelSearch.Font = new Font("Century Gothic", 11.25F);
            labelSearch.Location = new Point(783, 137);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(60, 20);
            labelSearch.TabIndex = 39;
            labelSearch.Text = "Search";
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.Teal;
            buttonSearch.Cursor = Cursors.Hand;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonSearch.ForeColor = SystemColors.Control;
            buttonSearch.Location = new Point(904, 199);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(72, 25);
            buttonSearch.TabIndex = 40;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 577);
            Controls.Add(buttonSearch);
            Controls.Add(labelSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(buttonSave);
            Controls.Add(labelGenreList);
            Controls.Add(dataGridViewGenres);
            Controls.Add(buttonAdd);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(labelEnterGenre);
            Controls.Add(textBoxGenre);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenres).EndInit();
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelGenreList;
        private DataGridView dataGridViewGenres;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonEdit;
        private Label labelEnterGenre;
        private TextBox textBoxGenre;
        private Panel panel3;
        private PictureBox pictureBox6;
        private Label labelHeader;
        private Panel panel1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Label labelLog;
        private PictureBox pictureBox3;
        private Label label3;
        private PictureBox pictureBox2;
        private Label labelGames;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label labelLogout;
        private Label labelX;
        private Button buttonSave;
        private TextBox textBoxSearch;
        private Label labelSearch;
        private Button buttonSearch;
    }
}