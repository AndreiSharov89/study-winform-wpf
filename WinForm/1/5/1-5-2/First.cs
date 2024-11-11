using System.Drawing.Drawing2D;

namespace _1_5_2
{
    public partial class First : Form
    {
        public First()
        {
            InitializeComponent();
        }

        private void First_Load(object sender, EventArgs e)
        {
            using (GraphicsPath myPath = new GraphicsPath())
            {
                myPath.AddLines(new[]
                    {
                new Point(0, this.Height / 2),
                new Point(this.Width / 2, 0),
                new Point(this.Width, this.Height / 2),
                new Point(this.Width / 2, this.Height)
            });
                Region = new Region(myPath);
            }
        }
    }
}
