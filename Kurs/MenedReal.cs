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
    public partial class MenedReal : Form
    {
        List<string> str;
        public MenedReal(List<string> q)
        {
            InitializeComponent();
            str = q;
            if (str.Count > 0)
            {
                textBox1.Text = str[1].ToString();
                textBox2.Text = str[2].ToString();
                textBox3.Text = str[3].ToString();
            }
        }

        private void MenedReal_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet9.склад". При необходимости она может быть перемещена или удалена.
            this.складTableAdapter.Fill(this.kyrsovayaDataSet9.склад);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet8.нп". При необходимости она может быть перемещена или удалена.
            this.нпTableAdapter.Fill(this.kyrsovayaDataSet8.нп);
            ShowTable();

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.нпTableAdapter.FillBy(this.kyrsovayaDataSet8.нп);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.запасTableAdapter.FillBy(this.kyrsovayaDataSet10.запас);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
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
                z.Add(z[1]);
                z.RemoveAt(1);
                str[1] = textBox1.Text;
                str[2] = textBox2.Text;
                str[3] = textBox3.Text;
                bd.EditReal(str, z);
                this.Close();
            }
            else
            {
                str.Add(textBox1.Text);
                str.Add(textBox2.Text);
                str.Add(textBox3.Text);
                bd.AddReal(str);
                this.Close();
            }
        }

        public void ShowTable()
        {
            List<List<string>> data = new List<List<string>>();
            data = bd.ShowZak();
            for (int i = 0; i < data.Count; i++)
            {
                dataGridView3.Rows.Add();
                for (int j = 0; j < data[i].Count; j++)
                {
                    dataGridView3.Rows[i].Cells[j].Value = data[i][j];
                }
            }
        }
    }
}
