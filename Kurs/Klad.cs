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
    public partial class Klad : Form
    {
        public Klad()
        {
            InitializeComponent();
        }

        private void Klad_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet.поступление". При необходимости она может быть перемещена или удалена.
            this.поступлениеTableAdapter.Fill(this.kyrsovayaDataSet.поступление);

        }

        private void button2_Click(object sender, EventArgs e)
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
                bd.DeleteKurs(id);
                this.поступлениеTableAdapter.Fill(this.kyrsovayaDataSet.поступление);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> q = new List<string>();
            KladAdd a = new KladAdd(q);
            a.button1.Text = "Добавить";
            a.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            a.Show();
            this.поступлениеTableAdapter.Fill(this.kyrsovayaDataSet.поступление);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.поступлениеTableAdapter.Fill(this.kyrsovayaDataSet.поступление);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cur = dataGridView1.CurrentCell.RowIndex;
            List<string> q = new List<string>();
            q.Add(dataGridView1.Rows[cur].Cells[0].Value.ToString());
            q.Add(dataGridView1.Rows[cur].Cells[1].Value.ToString());
            q.Add(dataGridView1.Rows[cur].Cells[3].Value.ToString());
            q.Add(dataGridView1.Rows[cur].Cells[2].Value.ToString());
            KladAdd a = new KladAdd(q);
            a.button1.Text = "Изменить";
            a.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            a.Show();
            this.поступлениеTableAdapter.Fill(this.kyrsovayaDataSet.поступление);
        }
    }
}
