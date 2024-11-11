using System.Data;
using System.Text;

namespace SinXForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 rangeForm = new Form2();
            if (rangeForm.ShowDialog() != DialogResult.OK) return;
            label1.Text = "от: " + rangeForm.answer[0] + "    до: " + rangeForm.textBox2.Text;
            StringBuilder sb = new StringBuilder();
            int i = 0;
            while (i < rangeForm.answer.Count)
            {
                sb.Append(rangeForm.answer[i] + ": " + rangeForm.answer[i + 1] + "\n");
                i += 2;
            }
            OutBox.Text = sb.ToString();
            rangeForm.answer.Clear();
        }
    }
}
