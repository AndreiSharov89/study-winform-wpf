﻿namespace NamePinValid
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
            namePinValid1 = new NamePinValid();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // namePinValid1
            // 
            namePinValid1.Location = new Point(12, 12);
            namePinValid1.Name = "namePinValid1";
            namePinValid1.Size = new Size(156, 64);
            namePinValid1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(220, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(239, 163);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(79, 102);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(301, 200);
            button2.Name = "button2";
            button2.Size = new Size(96, 23);
            button2.TabIndex = 3;
            button2.Text = "Посмотреть";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 245);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(namePinValid1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private NamePinValid namePinValid1;
        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
    }
}
