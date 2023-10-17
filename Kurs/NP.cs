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
    public partial class NP : Form
    {
        public NP()
        {
            InitializeComponent();
        }

        private void NP_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet22.состав_спецификации". При необходимости она может быть перемещена или удалена.
            this.состав_спецификацииTableAdapter.Fill(this.kyrsovayaDataSet22.состав_спецификации);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet21.состав_тк". При необходимости она может быть перемещена или удалена.
            this.состав_ткTableAdapter.Fill(this.kyrsovayaDataSet21.состав_тк);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet20.спецификация". При необходимости она может быть перемещена или удалена.
            this.спецификацияTableAdapter.Fill(this.kyrsovayaDataSet20.спецификация);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet19.тк". При необходимости она может быть перемещена или удалена.
            this.ткTableAdapter.Fill(this.kyrsovayaDataSet19.тк);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet18.нп". При необходимости она может быть перемещена или удалена.
            this.нпTableAdapter.Fill(this.kyrsovayaDataSet18.нп);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = dataGridView1.CurrentCell.RowIndex;
            if(dataGridView1.Rows[currentRow].Cells[1].Value.ToString()!=null)
            textBox1.Text = dataGridView1.Rows[currentRow].Cells[1].Value.ToString();
            if (dataGridView1.Rows[currentRow].Cells[2].Value.ToString() != null)
                textBox2.Text = dataGridView1.Rows[currentRow].Cells[2].Value.ToString();
            if (dataGridView1.Rows[currentRow].Cells[3].Value.ToString() != null)
                textBox3.Text = dataGridView1.Rows[currentRow].Cells[3].Value.ToString();
            if (dataGridView1.Rows[currentRow].Cells[4].Value.ToString() != null)
                textBox4.Text = dataGridView1.Rows[currentRow].Cells[4].Value.ToString();
            if (dataGridView1.Rows[currentRow].Cells[5].Value.ToString() != null)
                textBox5.Text = dataGridView1.Rows[currentRow].Cells[5].Value.ToString();
            if (dataGridView1.Rows[currentRow].Cells[6].Value.ToString() != null)
                textBox6.Text = dataGridView1.Rows[currentRow].Cells[6].Value.ToString();
            if (dataGridView1.Rows[currentRow].Cells[7].Value.ToString() != null)
                textBox7.Text = dataGridView1.Rows[currentRow].Cells[7].Value.ToString();
            if (dataGridView1.Rows[currentRow].Cells[8].Value.ToString() != null)
                textBox8.Text = dataGridView1.Rows[currentRow].Cells[8].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
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
                bd.DeleteNP(id);
                this.нпTableAdapter.Fill(this.kyrsovayaDataSet18.нп);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> data = new List<string>();
            data.Add(bd.MaxIDNP().ToString());
            data.Add(textBox1.Text);
            data.Add(textBox2.Text);
            data.Add(textBox3.Text);
            data.Add(textBox4.Text);
            data.Add(textBox5.Text);
            data.Add(textBox6.Text);
            data.Add(textBox7.Text);
            data.Add(textBox8.Text);
            bd.AddNP(data);
            this.нпTableAdapter.Fill(this.kyrsovayaDataSet18.нп);
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
            data.Add(textBox3.Text);
            data.Add(textBox4.Text);
            data.Add(textBox5.Text);
            data.Add(textBox6.Text);
            data.Add(textBox7.Text);
            data.Add(textBox8.Text);
            bd.EditNP(data);
            this.нпTableAdapter.Fill(this.kyrsovayaDataSet18.нп);
        }
    }
}
