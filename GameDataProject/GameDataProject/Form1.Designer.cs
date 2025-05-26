namespace GameDataProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timer1 = new System.Windows.Forms.Timer(components);
            panelBackground = new Panel();
            panelProgress = new Panel();
            labelGameDataMan = new Label();
            pictureBox1 = new PictureBox();
            panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // panelBackground
            // 
            panelBackground.Controls.Add(panelProgress);
            panelBackground.Location = new Point(-1, 171);
            panelBackground.Name = "panelBackground";
            panelBackground.Size = new Size(439, 25);
            panelBackground.TabIndex = 1;
            // 
            // panelProgress
            // 
            panelProgress.BackColor = Color.White;
            panelProgress.Location = new Point(0, 0);
            panelProgress.Name = "panelProgress";
            panelProgress.Size = new Size(13, 25);
            panelProgress.TabIndex = 2;
            // 
            // labelGameDataMan
            // 
            labelGameDataMan.AutoSize = true;
            labelGameDataMan.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelGameDataMan.ForeColor = Color.White;
            labelGameDataMan.Location = new Point(104, 29);
            labelGameDataMan.Name = "labelGameDataMan";
            labelGameDataMan.Size = new Size(238, 23);
            labelGameDataMan.TabIndex = 2;
            labelGameDataMan.Text = "Game Data Managment";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(186, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 50);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(435, 259);
            Controls.Add(pictureBox1);
            Controls.Add(labelGameDataMan);
            Controls.Add(panelBackground);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panelBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Panel panelBackground;
        private Panel panelProgress;
        private Label labelGameDataMan;
        private PictureBox pictureBox1;
    }
}
