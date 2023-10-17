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
    public partial class TK : Form
    {
        public TK()
        {
            InitializeComponent();
            dateTimePicker1.MaxDate = DateTime.Now;
        }

        private void TK_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet13.тк". При необходимости она может быть перемещена или удалена.
            this.ткTableAdapter.Fill(this.kyrsovayaDataSet13.тк);

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
                bd.DeleteTK(id);
                this.ткTableAdapter.Fill(this.kyrsovayaDataSet13.тк);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> data = new List<string> {dateTimePicker1.Value.ToString("yyyy-MM-dd"), textBox1.Text};
            bd.AddTK(data);
            this.ткTableAdapter.Fill(this.kyrsovayaDataSet13.тк);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int curRow= dataGridView1.CurrentCell.RowIndex; ;
            List<string> data = new List<string> { dataGridView1.Rows[curRow].Cells[0].Value.ToString(), dateTimePicker1.Value.ToString("yyyy-MM-dd"), textBox1.Text };
            bd.EditTK(data);
            this.ткTableAdapter.Fill(this.kyrsovayaDataSet13.тк);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = dataGridView1.CurrentCell.RowIndex;
            dateTimePicker1.Value = DateTime.Parse(dataGridView1.Rows[currentRow].Cells[1].Value.ToString());
            textBox1.Text = dataGridView1.Rows[currentRow].Cells[2].Value.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.ткTableAdapter.Fill(this.kyrsovayaDataSet13.тк);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int currentRow = dataGridView1.CurrentCell.RowIndex;
            if (currentRow < 0)
            {
                return;
            }
            string message = "Вы уверены, что хотите удалить состав этой ТК?";
            string title = "Удаление состава";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int id = int.Parse(dataGridView1.Rows[currentRow].Cells[0].Value.ToString());
                bd.DeleteTKS(id);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int currentRow = dataGridView1.CurrentCell.RowIndex;
            SostavTK tk = new SostavTK((int)dataGridView1.Rows[currentRow].Cells[0].Value);
            tk.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int currentRow = dataGridView1.CurrentCell.RowIndex;
            SostavTK tk = new SostavTK((int)dataGridView1.Rows[currentRow].Cells[0].Value);
            tk.Show();
        }
    }
}
