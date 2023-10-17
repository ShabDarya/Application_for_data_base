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
    public partial class Jurn : Form
    {
        static int pz;
        public Jurn(int p)
        {
            InitializeComponent();
            pz= p;
        }

        private void Jurn_Load(object sender, EventArgs e)
        {
            Zapoln_TablVP();
            Zapoln_TablPOT();
            Zapoln_TablVIH();
        }
        public void Zapoln_TablVP()
        {
            dataGridView4.Rows.Clear();
            List<List<string>> data = new List<List<string>>();
            data = bd.ShowVP(pz);
            for (int i = 0; i < data.Count; i++)
            {
                dataGridView4.Rows.Add();
                for (int j = 0; j < data[i].Count; j++)
                {
                    dataGridView4.Rows[i].Cells[j].Value = data[i][j];
                }
            }
        }

        public void Zapoln_TablPOT()
        {
            dataGridView5.Rows.Clear();
            List<List<string>> data = new List<List<string>>();
            data = bd.ShowPOT(pz);
            for (int i = 0; i < data.Count; i++)
            {
                dataGridView5.Rows.Add();
                for (int j = 0; j < data[i].Count; j++)
                {
                    dataGridView5.Rows[i].Cells[j].Value = data[i][j];
                }
            }
        }

        public void Zapoln_TablVIH()
        {
            dataGridView1.Rows.Clear();
            List<List<string>> data = new List<List<string>>();
            data = bd.ShowVIH(pz);
            for (int i = 0; i < data.Count; i++)
            {
                dataGridView1.Rows.Add();
                for (int j = 0; j < data[i].Count; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = data[i][j];
                }
            }
        }
    }
}
