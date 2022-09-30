namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            Random random = new Random();
            label1.Left = random.Next(0, 500);
            label1.Top = random.Next(0, 200);
            label1.BackColor = Color.Yellow;
            label1.Text = "Click me:)";
        }

      
       
    }
}