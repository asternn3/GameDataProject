namespace GameDataProject
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            labelManSys = new Label();
            pictureBox1 = new PictureBox();
            textBoxUsername = new TextBox();
            labelUsername = new Label();
            labelPass = new Label();
            buttonLogin = new Button();
            labelReset = new Label();
            textBoxPassword = new TextBox();
            label5 = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(labelManSys);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(208, 393);
            panel1.TabIndex = 0;
            // 
            // labelManSys
            // 
            labelManSys.AutoSize = true;
            labelManSys.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelManSys.ForeColor = Color.White;
            labelManSys.Location = new Point(28, 49);
            labelManSys.Name = "labelManSys";
            labelManSys.Size = new Size(138, 50);
            labelManSys.TabIndex = 5;
            labelManSys.Text = "Managment\r\n    System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(46, 131);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxUsername.Location = new Point(305, 130);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(232, 27);
            textBoxUsername.TabIndex = 1;
            textBoxUsername.KeyPress += textBoxUsername_KeyPress;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelUsername.Location = new Point(305, 95);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(88, 21);
            labelUsername.TabIndex = 3;
            labelUsername.Text = "Username";
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelPass.Location = new Point(305, 189);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(82, 21);
            labelPass.TabIndex = 4;
            labelPass.Text = "Password";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Teal;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonLogin.ForeColor = SystemColors.Control;
            buttonLogin.Location = new Point(348, 286);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(145, 32);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // labelReset
            // 
            labelReset.AutoSize = true;
            labelReset.Cursor = Cursors.Hand;
            labelReset.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            labelReset.ForeColor = Color.FromArgb(192, 0, 0);
            labelReset.Location = new Point(396, 327);
            labelReset.Name = "labelReset";
            labelReset.Size = new Size(41, 16);
            labelReset.TabIndex = 6;
            labelReset.Text = "Reset";
            labelReset.Click += label4_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxPassword.Location = new Point(305, 226);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(232, 27);
            textBoxPassword.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.FromArgb(192, 0, 0);
            label5.Location = new Point(663, 13);
            label5.Name = "label5";
            label5.Size = new Size(20, 19);
            label5.TabIndex = 7;
            label5.Text = "X";
            label5.Click += label5_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(700, 390);
            Controls.Add(label5);
            Controls.Add(labelReset);
            Controls.Add(buttonLogin);
            Controls.Add(labelPass);
            Controls.Add(labelUsername);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBoxUsername;
        private Label labelManSys;
        private PictureBox pictureBox1;
        private Label labelUsername;
        private Label labelPass;
        private Button buttonLogin;
        private Label labelReset;
        private TextBox textBoxPassword;
        private Label label5;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
    }
}