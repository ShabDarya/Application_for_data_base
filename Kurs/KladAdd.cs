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
    public partial class KladAdd : Form
    {
        List<string> str;    
        public KladAdd(List<string> q)
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

        private void KladAdd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet2.склад". При необходимости она может быть перемещена или удалена.
            this.складTableAdapter.Fill(this.kyrsovayaDataSet2.склад);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaNP.нп". При необходимости она может быть перемещена или удалена.
            this.нпTableAdapter.FillBy1(this.kyrsovayaNP.нп);

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.нпTableAdapter.FillBy1(this.kyrsovayaNP.нп);
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
                    if(Int32.TryParse(str[i], out c)) z.Add(c);
                }
                z.RemoveAt(0);
                str[1] = textBox1.Text;
                str[2] = textBox2.Text;
                str[3] = textBox3.Text;                
                bd.EditKurs(str, z);
                this.Close();
            }
            else
            {
                str.Add(textBox1.Text);
                str.Add(textBox2.Text);
                str.Add(textBox3.Text);
                bd.AddKurs(str);
                this.Close();
            }
        }
    }
}
