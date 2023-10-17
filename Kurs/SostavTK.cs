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
    public partial class SostavTK : Form
    {
        int id;
        public SostavTK(int i)
        {
            InitializeComponent();
            id = i;
        }

        private void SostavTK_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet14.рц". При необходимости она может быть перемещена или удалена.
            this.рцTableAdapter.Fill(this.kyrsovayaDataSet14.рц);
            ShowTable();
        }

        public void ShowTable()
        {
            List<List<string>> data = new List<List<string>>();
            data = bd.ShowTKS(id);
            dataGridView1.Rows.Clear();
            for (int i = 0; i < data.Count; i++)
            {
                dataGridView1.Rows.Add();
                for (int j = 0; j < data[i].Count; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = data[i][j];
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = dataGridView1.CurrentCell.RowIndex;
            textBox1.Text = dataGridView1.Rows[currentRow].Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.Rows[currentRow].Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.Rows[currentRow].Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.Rows[currentRow].Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.Rows[currentRow].Cells[6].Value.ToString();
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
                int idT = int.Parse(dataGridView1.Rows[currentRow].Cells[0].Value.ToString());
                int idO = int.Parse(dataGridView1.Rows[currentRow].Cells[1].Value.ToString());
                bd.DeleteTKO(idT, idO);
                ShowTable();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> data = new List<string>();
            data.Add(id.ToString());
            data.Add(bd.MaxTKO(id).ToString());
            data.Add(textBox1.Text);
            data.Add(textBox2.Text);
            data.Add(textBox3.Text);
            data.Add(textBox4.Text);
            data.Add(textBox5.Text);
            bd.AddTKO(data);
            ShowTable();
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
            data.Add(dataGridView1.Rows[currentRow].Cells[1].Value.ToString());
            data.Add(textBox1.Text);
            data.Add(textBox2.Text);
            data.Add(textBox3.Text);
            data.Add(textBox4.Text);
            data.Add(textBox5.Text);
            bd.EditTKO(data);
            ShowTable();
        }
    }
}
