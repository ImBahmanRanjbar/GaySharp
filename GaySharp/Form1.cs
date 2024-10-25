using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaySharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Really?","", MessageBoxButtons.YesNo,MessageBoxIcon.Hand);
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.Location = new Point(r.Next(12, 89), r.Next(158, 256));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GOODBYE");
            Application.Exit();
        }
    }
}
