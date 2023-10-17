
namespace Kurs
{
    partial class MenedZak
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодНПDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колвоДозаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.точкаДозаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.методВозобновленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.едИмзеренияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.периодОжиданиядниDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.нпBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kyrsovayaDataSet3 = new Kurs.kyrsovayaDataSet3();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.нпTableAdapter = new Kurs.kyrsovayaDataSet3TableAdapters.нпTableAdapter();
            this.kyrsovayaDataSet4 = new Kurs.kyrsovayaDataSet4();
            this.запасBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.запасTableAdapter = new Kurs.kyrsovayaDataSet4TableAdapters.запасTableAdapter();
            this.kyrsovayaDataSet5 = new Kurs.kyrsovayaDataSet5();
            this.запасBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.запасTableAdapter1 = new Kurs.kyrsovayaDataSet5TableAdapters.запасTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.кодСкладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.складBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kyrsovayaDataSet12 = new Kurs.kyrsovayaDataSet12();
            this.складTableAdapter = new Kurs.kyrsovayaDataSet12TableAdapters.складTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.нпBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovayaDataSet3)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovayaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.запасBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovayaDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.запасBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovayaDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодНПDataGridViewTextBoxColumn,
            this.колвоДозаказаDataGridViewTextBoxColumn,
            this.точкаДозаказаDataGridViewTextBoxColumn,
            this.методВозобновленияDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.едИмзеренияDataGridViewTextBoxColumn,
            this.периодОжиданиядниDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.нпBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(838, 327);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодНПDataGridViewTextBoxColumn
            // 
            this.кодНПDataGridViewTextBoxColumn.DataPropertyName = "Код НП";
            this.кодНПDataGridViewTextBoxColumn.HeaderText = "Код НП";
            this.кодНПDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодНПDataGridViewTextBoxColumn.Name = "кодНПDataGridViewTextBoxColumn";
            this.кодНПDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодНПDataGridViewTextBoxColumn.Width = 62;
            // 
            // колвоДозаказаDataGridViewTextBoxColumn
            // 
            this.колвоДозаказаDataGridViewTextBoxColumn.DataPropertyName = "Кол-во дозаказа";
            this.колвоДозаказаDataGridViewTextBoxColumn.HeaderText = "Кол-во дозаказа";
            this.колвоДозаказаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.колвоДозаказаDataGridViewTextBoxColumn.Name = "колвоДозаказаDataGridViewTextBoxColumn";
            this.колвоДозаказаDataGridViewTextBoxColumn.ReadOnly = true;
            this.колвоДозаказаDataGridViewTextBoxColumn.Width = 135;
            // 
            // точкаДозаказаDataGridViewTextBoxColumn
            // 
            this.точкаДозаказаDataGridViewTextBoxColumn.DataPropertyName = "Точка дозаказа";
            this.точкаДозаказаDataGridViewTextBoxColumn.HeaderText = "Точка дозаказа";
            this.точкаДозаказаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.точкаДозаказаDataGridViewTextBoxColumn.Name = "точкаДозаказаDataGridViewTextBoxColumn";
            this.точкаДозаказаDataGridViewTextBoxColumn.ReadOnly = true;
            this.точкаДозаказаDataGridViewTextBoxColumn.Width = 130;
            // 
            // методВозобновленияDataGridViewTextBoxColumn
            // 
            this.методВозобновленияDataGridViewTextBoxColumn.DataPropertyName = "Метод возобновления";
            this.методВозобновленияDataGridViewTextBoxColumn.HeaderText = "Метод возобновления";
            this.методВозобновленияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.методВозобновленияDataGridViewTextBoxColumn.Name = "методВозобновленияDataGridViewTextBoxColumn";
            this.методВозобновленияDataGridViewTextBoxColumn.ReadOnly = true;
            this.методВозобновленияDataGridViewTextBoxColumn.Width = 168;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            this.наименованиеDataGridViewTextBoxColumn.ReadOnly = true;
            this.наименованиеDataGridViewTextBoxColumn.Width = 135;
            // 
            // едИмзеренияDataGridViewTextBoxColumn
            // 
            this.едИмзеренияDataGridViewTextBoxColumn.DataPropertyName = "Ед_ имзерения";
            this.едИмзеренияDataGridViewTextBoxColumn.HeaderText = "Ед_ имзерения";
            this.едИмзеренияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.едИмзеренияDataGridViewTextBoxColumn.Name = "едИмзеренияDataGridViewTextBoxColumn";
            this.едИмзеренияDataGridViewTextBoxColumn.ReadOnly = true;
            this.едИмзеренияDataGridViewTextBoxColumn.Width = 127;
            // 
            // периодОжиданиядниDataGridViewTextBoxColumn
            // 
            this.периодОжиданиядниDataGridViewTextBoxColumn.DataPropertyName = "Период ожидания (дни)";
            this.периодОжиданиядниDataGridViewTextBoxColumn.HeaderText = "Период ожидания (дни)";
            this.периодОжиданиядниDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.периодОжиданиядниDataGridViewTextBoxColumn.Name = "периодОжиданиядниDataGridViewTextBoxColumn";
            this.периодОжиданиядниDataGridViewTextBoxColumn.ReadOnly = true;
            this.периодОжиданиядниDataGridViewTextBoxColumn.Width = 146;
            // 
            // нпBindingSource
            // 
            this.нпBindingSource.DataMember = "нп";
            this.нпBindingSource.DataSource = this.kyrsovayaDataSet3;
            // 
            // kyrsovayaDataSet3
            // 
            this.kyrsovayaDataSet3.DataSetName = "kyrsovayaDataSet3";
            this.kyrsovayaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1171, 25);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(29, 22);
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // нпTableAdapter
            // 
            this.нпTableAdapter.ClearBeforeFill = true;
            // 
            // kyrsovayaDataSet4
            // 
            this.kyrsovayaDataSet4.DataSetName = "kyrsovayaDataSet4";
            this.kyrsovayaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // запасBindingSource
            // 
            this.запасBindingSource.DataMember = "запас";
            this.запасBindingSource.DataSource = this.kyrsovayaDataSet4;
            // 
            // запасTableAdapter
            // 
            this.запасTableAdapter.ClearBeforeFill = true;
            // 
            // kyrsovayaDataSet5
            // 
            this.kyrsovayaDataSet5.DataSetName = "kyrsovayaDataSet5";
            this.kyrsovayaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // запасBindingSource1
            // 
            this.запасBindingSource1.DataMember = "запас";
            this.запасBindingSource1.DataSource = this.kyrsovayaDataSet5;
            // 
            // запасTableAdapter1
            // 
            this.запасTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView2.Location = new System.Drawing.Point(867, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(293, 200);
            this.dataGridView2.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Код НП";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 86;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Кол-во";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 82;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(689, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить/изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Код НП";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 368);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(412, 368);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 22);
            this.textBox2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Код склада";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(271, 368);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 22);
            this.textBox3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Кол-во";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Дата";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(542, 366);
            this.dateTimePicker1.MinDate = new System.DateTime(1988, 7, 14, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодСкладаDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.складBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(867, 257);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(293, 160);
            this.dataGridView3.TabIndex = 12;
            // 
            // кодСкладаDataGridViewTextBoxColumn
            // 
            this.кодСкладаDataGridViewTextBoxColumn.DataPropertyName = "Код склада";
            this.кодСкладаDataGridViewTextBoxColumn.HeaderText = "Код склада";
            this.кодСкладаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодСкладаDataGridViewTextBoxColumn.Name = "кодСкладаDataGridViewTextBoxColumn";
            this.кодСкладаDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодСкладаDataGridViewTextBoxColumn.Width = 112;
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            this.адресDataGridViewTextBoxColumn.ReadOnly = true;
            this.адресDataGridViewTextBoxColumn.Width = 77;
            // 
            // складBindingSource
            // 
            this.складBindingSource.DataMember = "склад";
            this.складBindingSource.DataSource = this.kyrsovayaDataSet12;
            // 
            // kyrsovayaDataSet12
            // 
            this.kyrsovayaDataSet12.DataSetName = "kyrsovayaDataSet12";
            this.kyrsovayaDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // складTableAdapter
            // 
            this.складTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(864, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Склады";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(867, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Запас";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "НП";
            // 
            // MenedZak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 419);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MenedZak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MenedZak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.нпBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovayaDataSet3)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovayaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.запасBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovayaDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.запасBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovayaDataSet12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private kyrsovayaDataSet3 kyrsovayaDataSet3;
        private System.Windows.Forms.BindingSource нпBindingSource;
        private kyrsovayaDataSet3TableAdapters.нпTableAdapter нпTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодНПDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn колвоДозаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn точкаДозаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn методВозобновленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn едИмзеренияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn периодОжиданиядниDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private kyrsovayaDataSet4 kyrsovayaDataSet4;
        private System.Windows.Forms.BindingSource запасBindingSource;
        private kyrsovayaDataSet4TableAdapters.запасTableAdapter запасTableAdapter;
        private kyrsovayaDataSet5 kyrsovayaDataSet5;
        private System.Windows.Forms.BindingSource запасBindingSource1;
        private kyrsovayaDataSet5TableAdapters.запасTableAdapter запасTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private kyrsovayaDataSet12 kyrsovayaDataSet12;
        private System.Windows.Forms.BindingSource складBindingSource;
        private kyrsovayaDataSet12TableAdapters.складTableAdapter складTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСкладаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}