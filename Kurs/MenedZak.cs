using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kurs
{
    public partial class MenedZak : Form
    {
        List<string> str;
        public MenedZak(List<string> q)
        {
            InitializeComponent();
            dateTimePicker1.MaxDate= DateTime.Now;
            str = q;
            if (str.Count > 0)
            {
                textBox1.Text = str[1].ToString();
                textBox2.Text = str[2].ToString();
                textBox3.Text = str[3].ToString();
                dateTimePicker1.Value = DateTime.Parse(str[4]);
            }

        }

        private void MenedZak_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet12.склад". При необходимости она может быть перемещена или удалена.
            this.складTableAdapter.Fill(this.kyrsovayaDataSet12.склад);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet3.нп". При необходимости она может быть перемещена или удалена.
            this.нпTableAdapter.Fill(this.kyrsovayaDataSet3.нп);
            ShowTable();

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.нпTableAdapter.FillBy(this.kyrsovayaDataSet3.нп);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        public void ShowTable()
        {
            List<List<string>> data = new List<List<string>>();
            data = bd.ShowZak();
            for(int i = 0; i < data.Count; i++)
            {
                dataGridView2.Rows.Add();
                for (int j=0; j < data[i].Count; j++)
                {                  
                    dataGridView2.Rows[i].Cells[j].Value = data[i][j];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (str.Count > 0)
            {
                List<int> z = new List<int>();
                int c;
                for (int i = 0; i < str.Count; i++)
                {
                    if (Int32.TryParse(str[i], out c)) z.Add(c);
                }
                z.RemoveAt(0);
                bd.MinusZapas(z);
                str[1] = textBox1.Text;
                str[2] = textBox2.Text;
                str[3] = textBox3.Text;
                str[4] = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                bd.EditZak(str);
                this.Close();
            }
            else
            {
                str.Add(textBox1.Text);
                str.Add(textBox2.Text);
                str.Add(textBox3.Text);
                str.Add(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                bd.AddZak(str);
                this.Close();
            }
        }
    }
}
