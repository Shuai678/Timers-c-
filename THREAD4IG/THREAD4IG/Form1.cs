namespace THREAD4IG
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTempo;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            lblTempo.Text = (Convert.ToInt16(lblTempo.Text) - 1).ToString();
            if (lblTempo.Text == "0")
            {
                timer1.Stop();
                MessageBox.Show("BOOM!");
                
            }
            //timer1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*
              private System.Windows.Forms.Timer timer1;
              private System.Windows.Forms.Label lblTempo;
            */
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();

            lblTempo = new System.Windows.Forms.Label();
            lblTempo.Location=new Point(0,0);
            lblTempo.Font= new Font(FontFamily.Families[0],36);
            this.Controls.Add(lblTempo);
            lblTempo.Size = new Size(100, 100);

            lblTempo.Text=numericUpDown1.Value.ToString();
            timer1.Start();
        }
    }
}
