﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EditPersonForm : Form
    {
        Person p;
/*        public EditPersonForm()
        {
            InitializeComponent();
        }*/
        public EditPersonForm(Person p)
        {
            InitializeComponent();
            this.p = p;
            this.FirstName = p.FirstName;
            this.LastName = p.LastName;
            this.Age = p.Age;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.FirstName = this.FirstName;
            p.LastName = this.LastName;
            p.Age = this.Age;
            MessageBox.Show("Сотрудник: " + p.ToString());
        }
    }
}
