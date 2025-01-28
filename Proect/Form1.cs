using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Proect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 start = new Form2();
            this.Hide();
            start.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
            
                button1.Location = new Point(2 * Width / 3, Height / 2); // например
            

        }
        private void ResetElementPositions()
        {
            
            button1.Location = new Point(button1.Location.X + this.ClientSize.Width / 2 - button1.Width / 2, button1.Location.Y + this.ClientSize.Height / 2 - button1.Height / 2);
        }
    }
}
