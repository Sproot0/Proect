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
    public partial class Form2 : Form

    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 start = new Form3();
            this.Hide();
            start.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 start = new Form1();
            this.Hide();
            start.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
