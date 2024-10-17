namespace THREAD4IG
{
    public partial class Form1 : Form
    {
        //private System.Windows.Forms.Timer timer1;
        //private System.Windows.Forms.Label lblTempo;
        private Label lblTempo;
        private Thread countdownThread;
        private int countdownValue; 
        public Form1()
        {
            InitializeComponent();
        }
        private void Countdown()
        {
            while (countdownValue >= 0)
            {
                // Aggiorna l'etichetta con il valore attuale del countdown
                //lblTempo.Text = countdownValue.ToString();
                this.Invoke(new Action(() =>
                {
                    lblTempo.Text = countdownValue.ToString();
                }));

                // Attende 1 secondo
                Thread.Sleep(1000);

                // Decrementa il valore del countdown
                countdownValue--;
            }

            // Alla fine del countdown, mostra il messaggio "BOOM!"
            if (lblTempo.Text == "0");
            MessageBox.Show("BOOM!");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //versioen precedente 
            //lblTempo.Text = (Convert.ToInt16(lblTempo.Text) - 1).ToString();
            /*if (lblTempo.Text == "0")
            {
                timer1.Stop();
                MessageBox.Show("BOOM!");
                
            }*/
            //timer1.Enabled = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*
             * versione precedente 
              private System.Windows.Forms.Timer timer1;
              private System.Windows.Forms.Label lblTempo;
            *//*
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
            */


            // Ottieni il valore dal controllo NumericUpDown (numero di secondi)
            countdownValue = (int)numericUpDown1.Value;

            // Configura la label per visualizzare il countdown
            lblTempo = new Label();
            lblTempo.Location = new Point(0, 0);
            lblTempo.Font = new Font(FontFamily.GenericSansSerif, 36);
            lblTempo.Size = new Size(200, 200);
            this.Controls.Add(lblTempo);
            lblTempo.Text = countdownValue.ToString();

            // Avvia il thread che eseguir¨¤ il conto alla rovescia
            countdownThread = new Thread(Countdown);
            countdownThread.Start();

        }
    }
}
