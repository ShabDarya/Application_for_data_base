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
    public partial class Tech : Form
    {
        public Tech()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TK tk = new TK();
            tk.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Specif S = new Specif();
            S.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NP np = new NP();
            np.Show();
        }
    }
}
