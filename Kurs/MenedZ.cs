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
    public partial class MenedZ : Form
    {
        public MenedZ()
        {
            InitializeComponent();
        }

        private void MenedZ_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet6.закупка". При необходимости она может быть перемещена или удалена.
            this.закупкаTableAdapter.Fill(this.kyrsovayaDataSet6.закупка);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.закупкаTableAdapter.Fill(this.kyrsovayaDataSet6.закупка);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int currentRow = dataGridView1.CurrentCell.RowIndex;
            if (currentRow < 0)
            {
                return;
            }
            string message = "Вы уверены, что хотите удалить эту строку?";
            string title = "Удаление строки";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {

                int id = int.Parse(dataGridView1.Rows[currentRow].Cells[0].Value.ToString());
                bd.DeleteZak(id);
                this.закупкаTableAdapter.Fill(this.kyrsovayaDataSet6.закупка);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> q = new List<string>();
            MenedZak a = new MenedZak(q);
            a.button1.Text = "Добавить";
            a.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            a.Show();
            this.закупкаTableAdapter.Fill(this.kyrsovayaDataSet6.закупка);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int cur = dataGridView1.CurrentCell.RowIndex;
            List<string> q = new List<string>();
            q.Add(dataGridView1.Rows[cur].Cells[0].Value.ToString());
            q.Add(dataGridView1.Rows[cur].Cells[1].Value.ToString());
            q.Add(dataGridView1.Rows[cur].Cells[2].Value.ToString());
            q.Add(dataGridView1.Rows[cur].Cells[3].Value.ToString());
            q.Add(dataGridView1.Rows[cur].Cells[4].Value.ToString());
            MenedZak a = new MenedZak(q);
            a.button1.Text = "Изменить";
            a.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            a.Show();
            this.закупкаTableAdapter.Fill(this.kyrsovayaDataSet6.закупка);
        }
    }
}
