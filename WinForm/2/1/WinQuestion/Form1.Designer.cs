namespace WinQuestion
{
    partial class Form1
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
            label1 = new Label();
            btnno = new Button();
            btnyes = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 9);
            label1.Name = "label1";
            label1.Size = new Size(181, 15);
            label1.TabIndex = 0;
            label1.Text = "Вы довольны своей зарплатой?";
            // 
            // btnno
            // 
            btnno.Location = new Point(12, 87);
            btnno.Name = "btnno";
            btnno.Size = new Size(75, 23);
            btnno.TabIndex = 1;
            btnno.TabStop = false;
            btnno.Text = "Нет";
            btnno.UseVisualStyleBackColor = true;
            btnno.MouseMove += btnno_MouseMove;
            // 
            // btnyes
            // 
            btnyes.Location = new Point(247, 87);
            btnyes.Name = "btnyes";
            btnyes.Size = new Size(75, 23);
            btnyes.TabIndex = 2;
            btnyes.Text = "Да";
            btnyes.UseVisualStyleBackColor = true;
            btnyes.Click += btnyes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 161);
            Controls.Add(btnyes);
            Controls.Add(btnno);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Насущный вопрос";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnno;
        private Button btnyes;
    }
}
