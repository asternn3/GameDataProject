namespace GameDataProject
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            labelLog = new Label();
            pictureBox3 = new PictureBox();
            labelGenres = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            labelLogout = new Label();
            labelGameT = new Label();
            textBoxUsername = new TextBox();
            panel3 = new Panel();
            label13 = new Label();
            pictureBox6 = new PictureBox();
            label6 = new Label();
            labelGenreT = new Label();
            labelPriceT = new Label();
            textBoxQuantity = new TextBox();
            labelQuantityT = new Label();
            textBoxPrice = new TextBox();
            labelDevByT = new Label();
            comboBoxGenre = new ComboBox();
            buttonEdit = new Button();
            buttonDelete = new Button();
            buttonAdd = new Button();
            dataGridView1 = new DataGridView();
            labelGameList = new Label();
            labelRelDateT = new Label();
            textBoxDevBy = new TextBox();
            dtpRelDate = new DateTimePicker();
            buttonSave = new Button();
            textBoxSearch = new TextBox();
            labelSearch = new Label();
            buttonSearch = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(208, 590);
            panel1.TabIndex = 0;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(61, 21);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(65, 65);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(19, 312);
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
            labelLog.Location = new Point(82, 324);
            labelLog.Name = "labelLog";
            labelLog.Size = new Size(109, 22);
            labelLog.TabIndex = 7;
            labelLog.Text = "Admin Log";
            labelLog.Click += labelLog_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(19, 224);
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
            labelGenres.Location = new Point(82, 236);
            labelGenres.Name = "labelGenres";
            labelGenres.Size = new Size(76, 22);
            labelGenres.TabIndex = 5;
            labelGenres.Text = "Genres";
            labelGenres.Click += labelGenres_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(18, 133);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(82, 147);
            label2.Name = "label2";
            label2.Size = new Size(76, 22);
            label2.TabIndex = 3;
            label2.Text = "Games";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkCyan;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(labelLogout);
            panel2.Cursor = Cursors.Hand;
            panel2.Location = new Point(0, 526);
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
            // labelGameT
            // 
            labelGameT.AutoSize = true;
            labelGameT.Font = new Font("Century Gothic", 11.25F);
            labelGameT.Location = new Point(233, 81);
            labelGameT.Name = "labelGameT";
            labelGameT.Size = new Size(55, 20);
            labelGameT.TabIndex = 5;
            labelGameT.Text = "Game";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Century Gothic", 9.75F);
            textBoxUsername.Location = new Point(233, 113);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(165, 23);
            textBoxUsername.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Teal;
            panel3.Controls.Add(label13);
            panel3.Controls.Add(pictureBox6);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(208, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(861, 43);
            panel3.TabIndex = 2;
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
            label13.TabIndex = 8;
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
            // labelGenreT
            // 
            labelGenreT.AutoSize = true;
            labelGenreT.Font = new Font("Century Gothic", 11.25F);
            labelGenreT.Location = new Point(442, 81);
            labelGenreT.Name = "labelGenreT";
            labelGenreT.Size = new Size(56, 20);
            labelGenreT.TabIndex = 7;
            labelGenreT.Text = "Genre";
            // 
            // labelPriceT
            // 
            labelPriceT.AutoSize = true;
            labelPriceT.Font = new Font("Century Gothic", 11.25F);
            labelPriceT.Location = new Point(654, 81);
            labelPriceT.Name = "labelPriceT";
            labelPriceT.Size = new Size(46, 20);
            labelPriceT.TabIndex = 9;
            labelPriceT.Text = "Price";
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Font = new Font("Century Gothic", 9.75F);
            textBoxQuantity.Location = new Point(859, 113);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(165, 23);
            textBoxQuantity.TabIndex = 8;
            // 
            // labelQuantityT
            // 
            labelQuantityT.AutoSize = true;
            labelQuantityT.Font = new Font("Century Gothic", 11.25F);
            labelQuantityT.Location = new Point(859, 81);
            labelQuantityT.Name = "labelQuantityT";
            labelQuantityT.Size = new Size(71, 20);
            labelQuantityT.TabIndex = 11;
            labelQuantityT.Text = "Quantity";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Font = new Font("Century Gothic", 9.75F);
            textBoxPrice.Location = new Point(654, 113);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(165, 23);
            textBoxPrice.TabIndex = 10;
            // 
            // labelDevByT
            // 
            labelDevByT.AutoSize = true;
            labelDevByT.Font = new Font("Century Gothic", 11.25F);
            labelDevByT.Location = new Point(571, 163);
            labelDevByT.Name = "labelDevByT";
            labelDevByT.Size = new Size(114, 20);
            labelDevByT.TabIndex = 13;
            labelDevByT.Text = "Developed By";
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Location = new Point(442, 113);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(165, 25);
            comboBoxGenre.TabIndex = 14;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.FromArgb(0, 192, 192);
            buttonEdit.Cursor = Cursors.Hand;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonEdit.ForeColor = SystemColors.Control;
            buttonEdit.Location = new Point(371, 259);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(145, 32);
            buttonEdit.TabIndex = 15;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(192, 0, 0);
            buttonDelete.Cursor = Cursors.Hand;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonDelete.ForeColor = SystemColors.Control;
            buttonDelete.Location = new Point(717, 259);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(145, 32);
            buttonDelete.TabIndex = 16;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Teal;
            buttonAdd.Cursor = Cursors.Hand;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonAdd.ForeColor = SystemColors.Control;
            buttonAdd.Location = new Point(547, 259);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(145, 32);
            buttonAdd.TabIndex = 17;
            buttonAdd.Text = "Add Game";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(268, 341);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(743, 221);
            dataGridView1.TabIndex = 18;
            // 
            // labelGameList
            // 
            labelGameList.AutoSize = true;
            labelGameList.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelGameList.Location = new Point(592, 306);
            labelGameList.Name = "labelGameList";
            labelGameList.Size = new Size(100, 22);
            labelGameList.TabIndex = 19;
            labelGameList.Text = "Game List";
            // 
            // labelRelDateT
            // 
            labelRelDateT.AutoSize = true;
            labelRelDateT.Font = new Font("Century Gothic", 11.25F);
            labelRelDateT.Location = new Point(290, 163);
            labelRelDateT.Name = "labelRelDateT";
            labelRelDateT.Size = new Size(107, 20);
            labelRelDateT.TabIndex = 21;
            labelRelDateT.Text = "Release Date";
            // 
            // textBoxDevBy
            // 
            textBoxDevBy.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxDevBy.Location = new Point(563, 192);
            textBoxDevBy.Name = "textBoxDevBy";
            textBoxDevBy.Size = new Size(165, 23);
            textBoxDevBy.TabIndex = 20;
            // 
            // dtpRelDate
            // 
            dtpRelDate.Location = new Point(280, 190);
            dtpRelDate.Name = "dtpRelDate";
            dtpRelDate.Size = new Size(236, 23);
            dtpRelDate.TabIndex = 22;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(0, 192, 192);
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonSave.ForeColor = SystemColors.Control;
            buttonSave.Location = new Point(407, 297);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 23;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Century Gothic", 9.75F);
            textBoxSearch.Location = new Point(802, 190);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(165, 23);
            textBoxSearch.TabIndex = 24;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Century Gothic", 11.25F);
            labelSearch.Location = new Point(802, 163);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(60, 20);
            labelSearch.TabIndex = 25;
            labelSearch.Text = "Search";
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.Teal;
            buttonSearch.Cursor = Cursors.Hand;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonSearch.ForeColor = SystemColors.Control;
            buttonSearch.Location = new Point(952, 219);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(72, 25);
            buttonSearch.TabIndex = 26;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 577);
            Controls.Add(buttonSearch);
            Controls.Add(labelSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(buttonSave);
            Controls.Add(dtpRelDate);
            Controls.Add(labelRelDateT);
            Controls.Add(textBoxDevBy);
            Controls.Add(labelGameList);
            Controls.Add(dataGridView1);
            Controls.Add(buttonAdd);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(comboBoxGenre);
            Controls.Add(labelDevByT);
            Controls.Add(labelQuantityT);
            Controls.Add(textBoxPrice);
            Controls.Add(labelPriceT);
            Controls.Add(textBoxQuantity);
            Controls.Add(labelGenreT);
            Controls.Add(panel3);
            Controls.Add(labelGameT);
            Controls.Add(textBoxUsername);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label labelLogout;
        private PictureBox pictureBox2;
        private Label label2;
        private PictureBox pictureBox3;
        private Label labelGenres;
        private PictureBox pictureBox4;
        private Label labelLog;
        private PictureBox pictureBox5;
        private Label labelGameT;
        private TextBox textBoxUsername;
        private Panel panel3;
        private PictureBox pictureBox6;
        private Label label6;
        private Label labelGenreT;
        private Label labelPriceT;
        private TextBox textBoxQuantity;
        private Label labelQuantityT;
        private TextBox textBoxPrice;
        private Label labelDevByT;
        private ComboBox comboBoxGenre;
        private Button buttonEdit;
        private Button buttonDelete;
        private Button buttonAdd;
        private DataGridView dataGridView1;
        private Label labelGameList;
        private Label labelRelDateT;
        private TextBox textBoxDevBy;
        private Label label13;
        private DateTimePicker dtpRelDate;
        private Button buttonSave;
        private TextBox textBoxSearch;
        private Label labelSearch;
        private Button buttonSearch;
    }
}