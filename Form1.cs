namespace Stopwatch {
    public partial class Form1 : Form {
        bool isrunning;
        int seconds = 0;
        
        public Form1()
        {
            InitializeComponent();
            start.Click += new EventHandler(StartClick);
            stop.Click += new EventHandler(Stopclick);
            restart.Click += new EventHandler(Restartclick);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            counter.BackColor = Color.Black;
            counter.Size = new System.Drawing.Size(380, 200);
            counter.Font = new Font("Arial", 45);
            counter.ForeColor = Color.White;
            
            start.BackColor = Color.LightBlue;
            start.BorderStyle = BorderStyle.FixedSingle;
            stop.BackColor = Color.LightBlue;
            stop.BorderStyle = BorderStyle.FixedSingle;
            restart.BackColor = Color.LightBlue;
            restart.BorderStyle = BorderStyle.FixedSingle;
        }

        private void StartClick(object sender, EventArgs e)
        {
            Thread st = new Thread(startcounting);
            st.Start();
        }
        private void startcounting()
        {
            isrunning = true;

            while (isrunning)
            {
                seconds++;
                string time = string.Format("{0:D2}:{1:D2}", seconds / 60, seconds % 60);
                counter.Text = time;
                Thread.Sleep(1000);
            }
        }

        private void Stopclick(object sender, EventArgs e)
        {
            isrunning= false;

        }

        private void Restartclick(object sender, EventArgs e)
        {
            isrunning = false;
            string time = string.Format("{0:D2}:{1:D2}", 0, 0);
            counter.Text = time;
            
        }
    }
}