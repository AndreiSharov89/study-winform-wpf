
using System.Windows.Forms;

namespace _1_5_2
{
    partial class GreenPeace
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>



        private void InitializeComponent()
        {
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.LimeGreen;
            button1.Location = new Point(342, 203);
            button1.MaximumSize = new Size(200, 100);
            button1.Name = "button1";
            button1.Size = new Size(75, 39);
            button1.TabIndex = 0;
            button1.Text = "1st form";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // GreenPeace
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Name = "GreenPeace";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GreenPeace";
            Load += GreenPeace_Load;
            ResumeLayout(false);
        }

        private void GreenPeace_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            myF1.StartPosition = FormStartPosition.Manual;
            myF1.Location = new Point(this.Location.X + this.Width, this.Location.Y);
            //myF1.Show();
            try
            {
                myF1.Show();
                myF1.Activate();
            }
            catch (ObjectDisposedException eх)
            {
                myF1 = new First();
                myF1.Text = "Повторное создание формы";
                myF1.Show();
                myF1.Activate();
            }
        }

        #endregion

        private Button button1;
    }
}