﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class nForm : Form
    {
        public nForm()
        {
            InitializeComponent();
        }
        private void nForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkBoxClose.Checked) return;
            e.Cancel = true;
            Hide();
        }
    }
}
