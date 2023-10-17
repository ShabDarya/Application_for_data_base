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
    public partial class PZ : Form
    {
        public PZ()
        {
            InitializeComponent();
            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker2.MaxDate = DateTime.Now;
            dateTimePicker3.MaxDate = DateTime.Now;
        }

        private void PZ_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet41.рц". При необходимости она может быть перемещена или удалена.
            this.рцTableAdapter.Fill(this.kyrsovayaDataSet41.рц);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet40.состав_тк_пз". При необходимости она может быть перемещена или удалена.
            this.состав_тк_пзTableAdapter.Fill(this.kyrsovayaDataSet40.состав_тк_пз);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet39.тк_пз". При необходимости она может быть перемещена или удалена.
            this.тк_пзTableAdapter.Fill(this.kyrsovayaDataSet39.тк_пз);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet38.нп". При необходимости она может быть перемещена или удалена.
            this.нпTableAdapter.Fill(this.kyrsovayaDataSet38.нп);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet36.производственный_заказ". При необходимости она может быть перемещена или удалена.
            this.производственный_заказTableAdapter.Fill(this.kyrsovayaDataSet36.производственный_заказ);
            //Zapoln_TablTKOP();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = dataGridView1.CurrentCell.RowIndex;
            textBox1.Text = dataGridView1.Rows[currentRow].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[currentRow].Cells[2].Value.ToString();
            dateTimePicker1.Value = DateTime.Parse(dataGridView1.Rows[currentRow].Cells[3].Value.ToString());
            if (dataGridView1.Rows[currentRow].Cells[4].Value.ToString() != "") dateTimePicker2.Value = DateTime.Parse(dataGridView1.Rows[currentRow].Cells[4].Value.ToString());
            else dateTimePicker2.Value = dateTimePicker2.MinDate;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = dataGridView3.CurrentCell.RowIndex;
            dateTimePicker3.Value = DateTime.Parse(dataGridView3.Rows[currentRow].Cells[2].Value.ToString());
            Zapoln_TablTKOP();
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = dataGridView4.CurrentCell.RowIndex;
            textBox3.Text = dataGridView4.Rows[currentRow].Cells[1].Value.ToString();
            textBox4.Text = dataGridView4.Rows[currentRow].Cells[2].Value.ToString();
            textBox5.Text = dataGridView4.Rows[currentRow].Cells[3].Value.ToString();
            textBox6.Text = dataGridView4.Rows[currentRow].Cells[4].Value.ToString();
            textBox7.Text = dataGridView4.Rows[currentRow].Cells[5].Value.ToString();
            textBox8.Text = dataGridView4.Rows[currentRow].Cells[6].Value.ToString();
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
                bd.DeletePZ(id);
                this.производственный_заказTableAdapter.Fill(this.kyrsovayaDataSet36.производственный_заказ);
            }
        }

        private void button7_Click(object sender, EventArgs e)
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
                int id = int.Parse(dataGridView3.Rows[currentRow].Cells[1].Value.ToString());
                bd.DeleteSost(id);
                bd.DeleteTKPZ(id);
                this.тк_пзTableAdapter.Fill(this.kyrsovayaDataSet39.тк_пз);
                this.состав_тк_пзTableAdapter.Fill(this.kyrsovayaDataSet40.состав_тк_пз);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int currentRow = dataGridView4.CurrentCell.RowIndex;
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
                int id = int.Parse(dataGridView4.Rows[currentRow].Cells[0].Value.ToString());
                int op = int.Parse(dataGridView4.Rows[currentRow].Cells[1].Value.ToString());
                bd.DeleteTKPZOP(id, op);
                this.состав_тк_пзTableAdapter.Fill(this.kyrsovayaDataSet40.состав_тк_пз);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> data = new List<string>();
            data.Add(bd.MaxIDPZ().ToString());
            data.Add(textBox1.Text);
            data.Add(textBox2.Text);
            data.Add(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            if (dateTimePicker2.Value.ToString("yyyy-MM-dd") != dateTimePicker2.MinDate.ToString("yyyy-MM-dd"))
                data.Add(dateTimePicker2.Value.ToString("yyyy-MM-dd"));
            else data.Add(" ");
            bd.AddPZ(data);
            this.производственный_заказTableAdapter.Fill(this.kyrsovayaDataSet36.производственный_заказ);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int cur = dataGridView1.CurrentCell.RowIndex;
            List<string> data = new List<string>();
            data.Add(dataGridView1.Rows[cur].Cells[0].Value.ToString());            
            data.Add(dateTimePicker3.Value.ToString("yyyy-MM-dd"));
            bd.AddTKPZ(data);
            this.тк_пзTableAdapter.Fill(this.kyrsovayaDataSet39.тк_пз);
            int tk = bd.MaxIDTKPZ();
            if (tk > 0) 
                Sostav((int)dataGridView1.Rows[cur].Cells[0].Value, tk);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int cur = dataGridView3.CurrentCell.RowIndex;
            List<string> data = new List<string>();
            data.Add(dataGridView3.Rows[cur].Cells[1].Value.ToString());
            data.Add(textBox3.Text);
            data.Add(textBox4.Text);
            data.Add(textBox5.Text);
            data.Add(textBox6.Text);
            data.Add(textBox7.Text);
            data.Add(textBox8.Text);
            bd.AddTKPZOP(data);
            this.состав_тк_пзTableAdapter.Fill(this.kyrsovayaDataSet40.состав_тк_пз);
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
            data.Add(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            data.Add(dateTimePicker2.Value.ToString("yyyy-MM-dd"));
            bd.EditPZ(data);
            this.производственный_заказTableAdapter.Fill(this.kyrsovayaDataSet36.производственный_заказ);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int currentRow = dataGridView3.CurrentCell.RowIndex;
            if (currentRow < 0)
            {
                return;
            }
            List<string> data = new List<string>();
            data.Add(dataGridView3.Rows[currentRow].Cells[0].Value.ToString());
            data.Add(dataGridView3.Rows[currentRow].Cells[1].Value.ToString());
            data.Add(dateTimePicker3.Value.ToString("yyyy-MM-dd"));
            bd.EditPZTK(data);
            this.тк_пзTableAdapter.Fill(this.kyrsovayaDataSet39.тк_пз);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int currentRow = dataGridView4.CurrentCell.RowIndex;
            if (currentRow < 0)
            {
                return;
            }
            List<string> data = new List<string>();
            data.Add(dataGridView4.Rows[currentRow].Cells[0].Value.ToString());
            data.Add(textBox3.Text);
            data.Add(textBox4.Text);
            data.Add(textBox5.Text);
            data.Add(textBox6.Text);
            data.Add(textBox7.Text);
            data.Add(textBox8.Text);
            bd.EditPZTKOP(data);
            this.состав_тк_пзTableAdapter.Fill(this.kyrsovayaDataSet40.состав_тк_пз);
        }
        //SELECT * FROM `состав тк` ст WHERE ст.`Код ТК`= (SELECT н.`Код ТК` FROM нп н WHERE н.`Код НП`=1) 
        //SELECT пз.`Код НП` FROM `производственный заказ` пз WHERE пз.`Код ПЗ`=1
        public void Sostav(int pz, int tk)
        {
            List<List<string>> data = new List<List<string>>();
            data = bd.ShowSostavTKPZ(pz);
            for(int i = 0; i < data.Count; i++)
            {
                bd.AddOP(tk, data[i]);
            }
            this.состав_тк_пзTableAdapter.Fill(this.kyrsovayaDataSet40.состав_тк_пз);
        }

        public void Zapoln_TablTKOP()
        {
            dataGridView4.Rows.Clear();
            int cur = dataGridView3.CurrentCell.RowIndex;
            int id = (int)dataGridView3.Rows[cur].Cells[1].Value;
            List<List<string>> data = new List<List<string>>();
            data = bd.ShowTKPZOPP(id);
            for (int i = 0; i < data.Count; i++)
            {
                dataGridView4.Rows.Add();
                for (int j = 0; j < data[i].Count; j++)
                {
                    dataGridView4.Rows[i].Cells[j].Value = data[i][j];
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dateTimePicker2.Value = dateTimePicker2.MinDate;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int c = dataGridView1.CurrentCell.RowIndex;
            Jurn j = new Jurn(int.Parse(dataGridView1.Rows[c].Cells[0].Value.ToString()));
            j.Show();
        }
    }
}
