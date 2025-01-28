using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 start = new Form6();
            this.Hide();
            start.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 start = new Form4();
            this.Hide();
            start.Show();
        }
    }
}
