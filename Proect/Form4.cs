﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proect
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 start = new Form5();
            this.Hide();
            start.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 start = new Form3();
            this.Hide();
            start.Show();
        }
    }
}
