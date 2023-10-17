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
    public partial class Glava : Form
    {
        public Glava()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RC rc = new RC();
            rc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Look l = new Look();
            l.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PZ p = new PZ();
            p.Show();
        }
    }
}
