namespace GameDataProject
{
    public partial class Form1 : Form
    {
        int progress = 0;
        public Form1()
        {
            InitializeComponent();
            panelProgress.Width = 0; 
            timer1.Interval = 50;    
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //bos
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progress < panelBackground.Width)
            {
                progress += 8;
                panelProgress.Width = progress;
            }
            else
            {
                timer1.Stop();
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
                //form kapat veya ac
            }
        }
    }
}
