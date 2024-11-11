using static System.Windows.Forms.AxHost;

namespace WinAsynchMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        //private delegate int AsyncSumm(int a, int b);

/*        private int Summ(int a, int b)
        {
            System.Threading.Thread.Sleep(9000);
            return a + b;
        }*/
        private async Task<int> Summ(int a, int b)
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(3000);
                return a + b;
            }
            );
        }
        void PrintFunc(string str)
        {
            lblResult.Text = str;
        }



        private async void BtnRun_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = Int32.Parse(txbA.Text);
                b = Int32.Parse(txbB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("При выполнении преобразования типов возникла ошибка");

                txbA.Text = txbB.Text = "";
                return;
            }
            int res = await Summ(a, b);
            lblResult.Text = res.ToString();
        }


        private void btnWork_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Работа кипит!!!");
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = Int32.Parse(txbA.Text);
                b = Int32.Parse(txbB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("При выполнении преобразования типов возникла ошибка");

                txbA.Text = txbB.Text = "";
                return;
            }
            int res = await Subb(a, b);
            lblResult.Text = res.ToString();

        }

        private async Task<int> Subb(int a, int b)
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(5000);
                return a - b;
            }
            );
        }

    }
}
