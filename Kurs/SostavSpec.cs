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
    public partial class SostavSpec : Form
    {
        int id;
        public SostavSpec(int i)
        {
            InitializeComponent();
            id = i;
        }

        private void SostavSpec_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet17.состав_тк". При необходимости она может быть перемещена или удалена.
            this.состав_ткTableAdapter.Fill(this.kyrsovayaDataSet17.состав_тк);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet16.нп". При необходимости она может быть перемещена или удалена.
            this.нпTableAdapter.Fill(this.kyrsovayaDataSet16.нп);
            ShowTable();

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = dataGridView3.CurrentCell.RowIndex;
            textBox1.Text = dataGridView3.Rows[currentRow].Cells[1].Value.ToString();
            textBox2.Text = dataGridView3.Rows[currentRow].Cells[2].Value.ToString();
            textBox3.Text = dataGridView3.Rows[currentRow].Cells[3].Value.ToString();
            textBox4.Text = dataGridView3.Rows[currentRow].Cells[4].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        public void ShowTable()
        {
            List<List<string>> data = new List<List<string>>();
            data = bd.ShowSPO(id);
            dataGridView3.Rows.Clear();
            for (int i = 0; i < data.Count; i++)
            {
                dataGridView3.Rows.Add();
                for (int j = 0; j < data[i].Count; j++)
                {
                    dataGridView3.Rows[i].Cells[j].Value = data[i][j];
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int currentRow = dataGridView3.CurrentCell.RowIndex;
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
                int ids = int.Parse(dataGridView3.Rows[currentRow].Cells[0].Value.ToString());
                int idn = int.Parse(dataGridView3.Rows[currentRow].Cells[1].Value.ToString());
                bd.DeleteSPO(ids, idn);
                ShowTable();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> data = new List<string>();
            data.Add(id.ToString());
            data.Add(textBox1.Text);
            data.Add(textBox2.Text);
            data.Add(textBox3.Text);
            data.Add(textBox4.Text);
            bd.AddSPO(data);
            ShowTable();
        }

        private void button2_Click(object sender, EventArgs e)
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
            data.Add(textBox3.Text);
            data.Add(textBox4.Text);
            bd.EditSPO(data);
            ShowTable();
        }
    }
}
