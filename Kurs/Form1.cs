using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Glava g = new Glava();
            g.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Vipoln v = new Vipoln();
            v.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tech t = new Tech();
            t.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mened m = new Mened();
            m.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Klad k = new Klad();
            k.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
