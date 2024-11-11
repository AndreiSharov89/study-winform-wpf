using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NamePinValid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string empName // Имя
        {
            get { return namePinValid1.textBox1.Text; }
            set { namePinValid1.textBox1.Text = value; }
        }

        public int empPin // Имя
        {
            get { return int.Parse(namePinValid1.textBox2.Text); }
            set { namePinValid1.textBox2.Text = ""; }
        }

        List<Employee> its = new List<Employee>();

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee(empName, empPin);
            its.Add(emp);
            empName = "";
            empPin = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Employee emp in its)
            {
                sb.Append("\n\n" + emp.ToString());
            }

            richTextBox1.Text = sb.ToString();


        }
    }


    public class Employee
    {
        private string Name { get; set; }
        private int Pin { get; set; }

        private long Balance { get; set; }

        public Employee()
        {
            this.Balance = 0;
        }

        public Employee(string someName, int somePin, long someBalance)
        {
            this.Name = someName;
            this.Pin = somePin;
            this.Balance = someBalance;
        }

        public Employee(string someName, int somePin) 
        {
            this.Name = someName;
            this.Pin = somePin;
            this.Balance = 0;
        }

        public void setName (string someName)
        {
            this.Name = someName;
        }

        public void setPin (int somePin)
        {
            this.Pin = somePin;
        }

        public void balDep (long someBalance)
        {
            this.Balance += someBalance;
        }

        public override string ToString()
        {
            return "Сотрудник: " + this.Name + "\nPIN: " + this.Pin;
        }
    }
}
