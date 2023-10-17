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
    public partial class RC : Form
    {
        public RC()
        {
            InitializeComponent();
        }

        private void RC_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet23.рц". При необходимости она может быть перемещена или удалена.
            this.рцTableAdapter.Fill(this.kyrsovayaDataSet23.рц);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = dataGridView1.CurrentCell.RowIndex;
            textBox1.Text = dataGridView1.Rows[currentRow].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[currentRow].Cells[2].Value.ToString();
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
                bd.DeleteRC(id);
                this.рцTableAdapter.Fill(this.kyrsovayaDataSet23.рц);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> data = new List<string>();
            data.Add(bd.MaxIDRC().ToString());
            data.Add(textBox1.Text);
            data.Add(textBox2.Text);
            bd.AddRC(data);
            this.рцTableAdapter.Fill(this.kyrsovayaDataSet23.рц);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int currentRow = dataGridView1.CurrentCell.RowIndex;
            if (currentRow < 0)
            {
                return;
            }
            List<string> data = new List<string>();
            data.Add(dataGridView1.Rows[currentRow].Cells[0].Value.ToString());
            data.Add(textBox1.Text);
            data.Add(textBox2.Text);
            bd.EditRC(data);
            this.рцTableAdapter.Fill(this.kyrsovayaDataSet23.рц);
        }
    }
}
