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
    public partial class Look : Form
    {
        public Look()
        {
            InitializeComponent();
        }

        private void Look_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet47.запас". При необходимости она может быть перемещена или удалена.
            this.запасTableAdapter.Fill(this.kyrsovayaDataSet47.запас);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet35.склад". При необходимости она может быть перемещена или удалена.
            this.складTableAdapter.Fill(this.kyrsovayaDataSet35.склад);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet34.выполненные_операции". При необходимости она может быть перемещена или удалена.
            this.выполненные_операцииTableAdapter.Fill(this.kyrsovayaDataSet34.выполненные_операции);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet33.журнал_потребления". При необходимости она может быть перемещена или удалена.
            this.журнал_потребленияTableAdapter.Fill(this.kyrsovayaDataSet33.журнал_потребления);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet32.рц". При необходимости она может быть перемещена или удалена.
            this.рцTableAdapter.Fill(this.kyrsovayaDataSet32.рц);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet31.состав_спецификации". При необходимости она может быть перемещена или удалена.
            this.состав_спецификацииTableAdapter.Fill(this.kyrsovayaDataSet31.состав_спецификации);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet30.спецификация". При необходимости она может быть перемещена или удалена.
            this.спецификацияTableAdapter.Fill(this.kyrsovayaDataSet30.спецификация);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet29.состав_тк". При необходимости она может быть перемещена или удалена.
            this.состав_ткTableAdapter.Fill(this.kyrsovayaDataSet29.состав_тк);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet28.тк". При необходимости она может быть перемещена или удалена.
            this.ткTableAdapter.Fill(this.kyrsovayaDataSet28.тк);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet27.производственный_заказ". При необходимости она может быть перемещена или удалена.
            this.производственный_заказTableAdapter.Fill(this.kyrsovayaDataSet27.производственный_заказ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsovayaDataSet24.нп". При необходимости она может быть перемещена или удалена.
            this.нпTableAdapter.Fill(this.kyrsovayaDataSet24.нп);
            ShowB();

        }

        public void ShowB()
        {
            dataGridView12.Rows.Clear();
           List < List<string> > d = new List<List<string>>();
            d = bd.ShowBron();
            for(int i = 0; i < d.Count; i++)
            {
                dataGridView12.Rows.Add();
                for(int j = 0; j < d[i].Count; j++)
                {
                    dataGridView12.Rows[i].Cells[j].Value = d[i][j];
                }
            }
        }
    }
}
