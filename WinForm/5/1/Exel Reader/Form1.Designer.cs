﻿namespace WinFormsCOM
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
            textBox1 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ofd = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(278, 149);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "C:\\Users\\sharo\\OneDrive\\Рабочий стол\\5 - Разработка настольных приложений на C#\\1_WindowsForms\\ДЗ\\5\\1";
            // 
            // button1
            // 
            button1.Location = new Point(278, 178);
            button1.Name = "button1";
            button1.Size = new Size(201, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 148);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(248, 150);
            dataGridView1.TabIndex = 2;
            // 
            // ofd
            // 
            ofd.DefaultExt = "\"*.xls;*.xlsx\"";
            ofd.FileName = "openFileDialog1";
            ofd.Filter = "\" Excel 2010(*.xlsx)|*.xlsx|Excel 2003(*.xls)|*.xls\"; –";
            ofd.Title = "\"Выберете документ для загрузки данных\"";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private OpenFileDialog ofd;
    }
}
