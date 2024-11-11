namespace WinTimer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool t = userControlTimer1.TimeEnabled;
            userControlTimer1.TimeEnabled = !t;
        }
    }
}
