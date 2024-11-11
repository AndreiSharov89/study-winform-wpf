using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms.Design.Behavior;

namespace AsyncWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CancellationTokenSource cts;
        public string GoButt(IProgress<string> progress)
        {
            int maxValue = 0;
            System.Text.StringBuilder resultText = new
           System.Text.StringBuilder();
            if (int.TryParse(textBox1.Text, out maxValue))
            {
                for (int trial = 2; trial <= maxValue; trial++)
                    if (!cts.Token.IsCancellationRequested)
                    {
                            bool isPrime = true;
                            for (int divisor = 2; divisor <= Math.Sqrt(trial); divisor++)
                            {
                                if (trial % divisor == 0)
                                {
                                    isPrime = false;
                                    break;
                                }
                            }
                            if (isPrime)
                            {
                                resultText.AppendFormat("{0} ", trial);
                                Task.Delay(500).Wait();
                                progress.Report(resultText.ToString());
                            }
                    }
            }
            else
            {
                resultText.Append("Unable to parse maximum value.");
            }
            return resultText.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Расчёт продолжается");
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();
            var progress = new Progress<string>(s => richTextBox1.Text = s);
            string result = await Task.Run(() => GoButt(progress));

            this.richTextBox1.Text = result;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cts?.Cancel();
            textBox1.Text = "";
        }
    }
}
