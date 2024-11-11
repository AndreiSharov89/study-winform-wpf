namespace _1_5_2
{
    partial class First
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
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
            button1.Location = new Point(336, 200);
            button1.Name = "button1";
            button1.Size = new Size(128, 70);
            button1.TabIndex = 0;
            button1.Text = "GREENPEACE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // First
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LimeGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Name = "First";
            Text = "Form1";
            Load += this.First_Load;
            ResumeLayout(false);
        }

        private void button1_Click_1(object sender, EventArgs e)
        { 
            Close();
        }

        #endregion

        private Button button1;
    }
}
