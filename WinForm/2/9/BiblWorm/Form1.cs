using MyClass;
using System.Text;

namespace BiblWorm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        List<Item> its = new List<Item>();
        public string Author // �����
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string Title // ��������
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public string PublishHouse // ������������
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public int Page // ���������� �������
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }
        public int Year // ��� �������
        {
            get { return (int)numericUpDown2.Value; }
            set { numericUpDown2.Value = value; }
        }
        public int InvNumber // ����������� �����
        {
            get { return (int)numericUpDown3.Value; }
            set { numericUpDown3.Value = value; }
        }
        public bool Existence // �������
        {
            get { return checkBox1.Checked; }
            set { checkBox1.Checked = value; }
        }
        public bool SortInvNumber // ���������� �� ������������ ������
        {
            get { return checkBox3.Checked; }
            set { checkBox3.Checked = value; }
        }
        public bool ReturnTime // ����������� � ����
        {
            get { return checkBox3.Checked; }
            set { checkBox3.Checked = value; }
        }
        public int PeriodUse // ����������� �����
        {
            get { return (int)numericUpDown4.Value; }
            set { numericUpDown4.Value = value; }
        }

        //������
        public string MagTitle // ��������
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }
        public int MagTome // ���
        {
            get { return (int)numericUpDown5.Value; }
            set { numericUpDown5.Value = value; }
        }
        public int MagNumber // �����
        {
            get { return (int)numericUpDown6.Value; }
            set { numericUpDown6.Value = value; }
        }
        public int MagYear // ���
        {
            get { return (int)numericUpDown7.Value; }
            set { numericUpDown7.Value = value; }
        }
        public int MagInvNumber // ����������� �����
        {
            get { return (int)numericUpDown8.Value; }
            set { numericUpDown8.Value = value; }
        }
        public bool MagExistence // �������
        {
            get { return checkBox5.Checked; }
            set { checkBox5.Checked = value; }
        }
        public bool MagSubs // ��������
        {
            get { return checkBox4.Checked; }
            set { checkBox4.Checked = value; }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Book b = new Book(Author, Title, PublishHouse,
            Page, Year, InvNumber, Existence);
            if (ReturnTime)
                b.ReturnSrok();
            b.PriceBook(PeriodUse);
            its.Add(b);
            Author = Title = PublishHouse = "";
            Page = InvNumber = PeriodUse = 0;
            Year = 1970;
            Existence = ReturnTime = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (SortInvNumber)
                its.Sort();
            StringBuilder sb = new StringBuilder();
            foreach (Item item in its)
            {
                sb.Append("\n" + item.ToString());
            }
            richTextBox1.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Magazine m = new Magazine(MagTome.ToString(), MagNumber, MagTitle, MagYear,
            MagInvNumber, MagExistence);

            //m.PriceBook(PeriodUse);
            its.Add(m);
            m.IfSubs = MagSubs;
            MagTitle =  "";
            MagNumber = MagInvNumber = 1;
            MagTome = 1;
            MagYear = 1870;
            MagExistence = false;
        }
    }
}
