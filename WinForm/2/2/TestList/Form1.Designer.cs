﻿namespace TestList
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
            groupBox1 = new GroupBox();
            peopleList = new ComboBox();
            memberList = new CheckedListBox();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttinSort = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(peopleList);
            groupBox1.Controls.Add(memberList);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 233);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Список участников";
            // 
            // peopleList
            // 
            peopleList.FormattingEnabled = true;
            peopleList.Items.AddRange(new object[] { "Екатерина Шульман", "Игорь Липсиц", "Сергей Гуриев", "Майкл Наки", "Владимир Милов" });
            peopleList.Location = new Point(6, 178);
            peopleList.Name = "peopleList";
            peopleList.Size = new Size(245, 23);
            peopleList.TabIndex = 1;
            // 
            // memberList
            // 
            memberList.FormattingEnabled = true;
            memberList.Location = new Point(6, 24);
            memberList.Name = "memberList";
            memberList.Size = new Size(245, 148);
            memberList.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(284, 36);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(284, 65);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttinSort
            // 
            buttinSort.Location = new Point(284, 94);
            buttinSort.Name = "buttinSort";
            buttinSort.Size = new Size(75, 23);
            buttinSort.TabIndex = 3;
            buttinSort.Text = "Сортировать";
            buttinSort.UseVisualStyleBackColor = true;
            buttinSort.Click += buttinSort_Click;
            // 
            // button1
            // 
            button1.Location = new Point(284, 180);
            button1.Name = "button1";
            button1.Size = new Size(75, 41);
            button1.TabIndex = 4;
            button1.Text = "Загрузить данные";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 257);
            Controls.Add(button1);
            Controls.Add(buttinSort);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Работа со списками";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox peopleList;
        private CheckedListBox memberList;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttinSort;
        private Button button1;
    }
}
