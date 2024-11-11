namespace NoModalWinForm
{
    partial class Form2
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
            textBox21 = new TextBox();
            textBox22 = new TextBox();
            textBox23 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox21
            // 
            textBox21.Location = new Point(94, 145);
            textBox21.Name = "textBox21";
            textBox21.Size = new Size(100, 23);
            textBox21.TabIndex = 0;
            // 
            // textBox22
            // 
            textBox22.Location = new Point(282, 145);
            textBox22.Name = "textBox22";
            textBox22.Size = new Size(100, 23);
            textBox22.TabIndex = 1;
            // 
            // textBox23
            // 
            textBox23.Location = new Point(497, 145);
            textBox23.Name = "textBox23";
            textBox23.Size = new Size(100, 23);
            textBox23.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(342, 229);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox23);
            Controls.Add(textBox22);
            Controls.Add(textBox21);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox21;
        private TextBox textBox22;
        private TextBox textBox23;
        private Button button1;
    }
}