using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool state = false;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            state = true;
            // BackgroundImage = Resources.download;
            timer2.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            state = false;
            /// BackgroundImage = Resources.Tower_Bridge_from_Shad_Thames;
            timer3.Start();
        }



        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.UtcNow.ToString();
        }
    }
}