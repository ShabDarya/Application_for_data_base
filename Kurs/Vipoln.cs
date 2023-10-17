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
    public partial class Vipoln : Form
    {
        public Vipoln()
        {
            InitializeComponent();
        }

        private void Vipoln_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet43.журнал_потребления". При необходимости она может быть перемещена или удалена.
            this.журнал_потребленияTableAdapter.Fill(this.kyrsovayaDataSet43.журнал_потребления);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet42.производственный_заказ". При необходимости она может быть перемещена или удалена.
            this.производственный_заказTableAdapter.Fill(this.kyrsovayaDataSet42.производственный_заказ);
            Zapoln_TablTK();
            Zapoln_TablTKOP();
            Zapoln_TablVP();
        }

        public void Zapoln_TablTK()
        {
            dataGridView2.Rows.Clear();
            int cur = dataGridView1.CurrentCell.RowIndex;
            int id = (int)dataGridView1.Rows[cur].Cells[0].Value;
            List<List<string>> data = new List<List<string>>();
            data = bd.ShowTKPZ(id);
            for (int i = 0; i < data.Count; i++)
            {
                dataGridView2.Rows.Add();
                for (int j = 0; j < data[i].Count; j++)
                {
                    dataGridView2.Rows[i].Cells[j].Value = data[i][j];
                }
            }
        }

        public void Zapoln_TablTKOP()
        {
            dataGridView3.Rows.Clear();
            int cur = dataGridView2.CurrentCell.RowIndex;
            int id = Int32.Parse(dataGridView2.Rows[cur].Cells[1].Value.ToString());
            List<List<string>> data = new List<List<string>>();
            if(!bd.fromTK) data = bd.ShowTKPZOP(id);
            else data = bd.ShowTKOP(id);
            for (int i = 0; i < data.Count; i++)
            {
                dataGridView3.Rows.Add();
                for (int j = 0; j < data[i].Count; j++)
                {
                    dataGridView3.Rows[i].Cells[j].Value = data[i][j];
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Zapoln_TablTK();
            Zapoln_TablVP();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Zapoln_TablTKOP();
        }

        public void Zapoln_TablVP()
        {
            dataGridView4.Rows.Clear();
            int cur = dataGridView1.CurrentCell.RowIndex;
            int id = (int)dataGridView1.Rows[cur].Cells[0].Value;
            List<List<string>> data = new List<List<string>>();
            data = bd.ShowVP(id);
            for (int i = 0; i < data.Count; i++)
            {
                dataGridView4.Rows.Add();
                for (int j = 0; j < data[i].Count; j++)
                {
                    dataGridView4.Rows[i].Cells[j].Value = data[i][j];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int curO = dataGridView3.CurrentCell.RowIndex;
            int curd = dataGridView2.CurrentCell.RowIndex;
            List<string> data = new List<string>();
            data.Add(dataGridView2.Rows[curd].Cells[0].Value.ToString());
            data.Add(dataGridView3.Rows[curO].Cells[0].Value.ToString());
            data.Add(dataGridView3.Rows[curO].Cells[1].Value.ToString());
            int s = Int32.Parse(dataGridView3.Rows[curO].Cells[3].Value.ToString()) + Int32.Parse(dataGridView3.Rows[curO].Cells[4].Value.ToString()) + Int32.Parse(dataGridView3.Rows[curO].Cells[5].Value.ToString());
            data.Add(s.ToString());
            bd.AddVP(data);
            Zapoln_TablVP();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cur = dataGridView4.CurrentCell.RowIndex;
            List<string> d = new List<string>();
            d.Add(dataGridView4.Rows[cur].Cells[0].Value.ToString());
            d.Add(dataGridView4.Rows[cur].Cells[1].Value.ToString()); 
            d.Add(dataGridView4.Rows[cur].Cells[3].Value.ToString());
            bd.DeleteVP(d);
            Zapoln_TablVP();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cur = dataGridView1.CurrentCell.RowIndex;
            VihodGP v = new VihodGP(Int32.Parse(dataGridView1.Rows[cur].Cells[0].Value.ToString()));
            v.Show();
        }
    }
}
