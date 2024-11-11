using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinXForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public double leftRange
        {
            get { return double.Parse(textBox1.Text); }
            set { textBox1.Text = ""; }
        }

        public double rightRange
        {
            get { return double.Parse(textBox2.Text); }
            set { textBox2.Text = ""; }
        }

        public List<double> answer = new List<double>();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double leftX = leftRange;
                double rightX = rightRange;
                double sin = 0;
                while (leftX <= rightX)
                {
                    if (leftX + 0.1 > rightX) 
                    {
                        sin = Math.Sin(rightX);
                        answer.Add(Math.Round(rightX, 1));
                        answer.Add(Math.Round(sin, 2));
                        leftX += 0.1;
                    }
                    else 
                    { 
                        sin = Math.Sin(leftX);
                        answer.Add(Math.Round(leftX, 1));
                        answer.Add(Math.Round(sin, 2));
                        leftX += 0.1;
                    }
                }
            }
            catch { MessageBox.Show("Поля могут содержать только вещественные числа"); }
            

        }
    }
}
