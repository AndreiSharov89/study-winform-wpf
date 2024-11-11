
namespace Form1
{
    partial class nForm
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
            checkBoxClose = new CheckBox();
            SuspendLayout();
            // 
            // checkBoxClose
            // 
            checkBoxClose.AutoSize = true;
            checkBoxClose.Location = new Point(34, 38);
            checkBoxClose.Name = "checkBoxClose";
            checkBoxClose.Size = new Size(77, 19);
            checkBoxClose.TabIndex = 0;
            checkBoxClose.Text = "Закрыть?";
            checkBoxClose.UseVisualStyleBackColor = true;
            //checkBoxClose.CheckedChanged += this.checkBox1_CheckedChanged;
            // 
            // nForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBoxClose);
            Name = "nForm";
            Text = "Form2";
            FormClosing += nForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        /*private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }*/

        #endregion

        private CheckBox checkBoxClose;
    }
}