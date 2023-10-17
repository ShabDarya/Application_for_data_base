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
    public partial class VihodGP : Form
    {
        static int pz;
        public VihodGP(int q)
        {
            InitializeComponent();
            pz = q;
        }

        private void VihodGP_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet46.выход_гп". При необходимости она может быть перемещена или удалена.
            this.выход_гпTableAdapter.Fill(this.kyrsovayaDataSet46.выход_гп);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet45.склад". При необходимости она может быть перемещена или удалена.
            this.складTableAdapter.Fill(this.kyrsovayaDataSet45.склад);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet44.нп". При необходимости она может быть перемещена или удалена.
            this.нпTableAdapter.Fill(this.kyrsovayaDataSet44.нп);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cur = dataGridView3.CurrentCell.RowIndex;
            List<string> q = new List<string>();
            List<int> z = new List<int>();
            z.Add(int.Parse(dataGridView3.Rows[cur].Cells[2].Value.ToString()));
            z.Add(int.Parse(dataGridView3.Rows[cur].Cells[3].Value.ToString()));
            z.Add(int.Parse(dataGridView3.Rows[cur].Cells[4].Value.ToString()));
            bd.MinusZapas(z);
            q.Add(dataGridView3.Rows[cur].Cells[0].Value.ToString());
            q.Add(dataGridView3.Rows[cur].Cells[1].Value.ToString());
            q.Add(textBox1.Text);
            q.Add(textBox2.Text);
            q.Add(textBox3.Text);
            bd.EditVihod(q);
            this.выход_гпTableAdapter.Fill(this.kyrsovayaDataSet46.выход_гп);
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int c = dataGridView3.CurrentCell.RowIndex;
            textBox1.Text = dataGridView3.Rows[c].Cells[2].Value.ToString();
            textBox2.Text = dataGridView3.Rows[c].Cells[3].Value.ToString();
            textBox3.Text = dataGridView3.Rows[c].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int c = dataGridView3.CurrentCell.RowIndex;

            if (c < 0)
            {
                return;
            }
            string message = "Вы уверены, что хотите удалить эту строку?";
            string title = "Удаление строки";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {

                int id = int.Parse(dataGridView3.Rows[c].Cells[0].Value.ToString());
                List<int> d = new List<int>();
                d.Add(int.Parse(dataGridView3.Rows[c].Cells[2].Value.ToString()));
                d.Add(int.Parse(dataGridView3.Rows[c].Cells[3].Value.ToString()));
                d.Add(int.Parse(dataGridView3.Rows[c].Cells[4].Value.ToString()));
                bd.DeleteVihod(id, d);
                this.выход_гпTableAdapter.Fill(this.kyrsovayaDataSet46.выход_гп);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> d = new List<string> {pz.ToString(), textBox1.Text, textBox2.Text, textBox3.Text};
            bd.AddVihod(d);
            this.выход_гпTableAdapter.Fill(this.kyrsovayaDataSet46.выход_гп);
        }
    }
}
