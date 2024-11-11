namespace WinAsynchMethod
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
            btnRun = new Button();
            btnWork = new Button();
            lblA = new Label();
            lblB = new Label();
            lblResult = new Label();
            txbA = new TextBox();
            txbB = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnRun
            // 
            btnRun.Location = new Point(20, 78);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(75, 23);
            btnRun.TabIndex = 0;
            btnRun.Text = "Сумма";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += BtnRun_Click;
            // 
            // btnWork
            // 
            btnWork.Location = new Point(156, 126);
            btnWork.Name = "btnWork";
            btnWork.Size = new Size(75, 23);
            btnWork.TabIndex = 1;
            btnWork.Text = "Работа";
            btnWork.UseVisualStyleBackColor = true;
            btnWork.Click += btnWork_Click;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(12, 29);
            lblA.Name = "lblA";
            lblA.Size = new Size(71, 15);
            lblA.TabIndex = 2;
            lblA.Text = "Значение А";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(209, 29);
            lblB.Name = "lblB";
            lblB.Size = new Size(68, 15);
            lblB.TabIndex = 3;
            lblB.Text = "значение B";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(193, 78);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(38, 15);
            lblResult.TabIndex = 4;
            lblResult.Text = "label3";
            // 
            // txbA
            // 
            txbA.Location = new Point(87, 26);
            txbA.Name = "txbA";
            txbA.Size = new Size(100, 23);
            txbA.TabIndex = 5;
            // 
            // txbB
            // 
            txbB.Location = new Point(283, 26);
            txbB.Name = "txbB";
            txbB.Size = new Size(100, 23);
            txbB.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(308, 78);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Разность";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 161);
            Controls.Add(button1);
            Controls.Add(txbB);
            Controls.Add(txbA);
            Controls.Add(lblResult);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Controls.Add(btnWork);
            Controls.Add(btnRun);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Асинхронный запуск";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRun;
        private Button btnWork;
        private Label lblA;
        private Label lblB;
        private Label lblResult;
        private TextBox txbA;
        private TextBox txbB;
        private Button button1;
    }
}
