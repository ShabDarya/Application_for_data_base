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
    public partial class Mened : Form
    {
        public Mened()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenedZ zak = new MenedZ();
            zak.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenedR zak = new MenedR();
            zak.Show();
        }
    }
}
