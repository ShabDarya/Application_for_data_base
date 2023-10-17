
namespace Kurs
{
    partial class KladAdd
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
            this.kyrsovayaDataSet = new Kurs.kyrsovayaDataSet();
            this.kyrsovayaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодСкладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.складBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kyrsovayaDataSet2 = new Kurs.kyrsovayaDataSet2();
            this.складTableAdapter = new Kurs.kyrsovayaDataSet2TableAdapters.складTableAdapter();
            this.кодНПDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колвоДозаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.точкаДозаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.методВозобновленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.едИмзеренияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.периодОжиданиядниDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.кодНПDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колвоДозаказаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.точкаДозаказаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.методВозобновленияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.едИмзеренияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.периодОжиданиядниDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.нпBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kyrsovayaNP = new Kurs.kyrsovayaNP();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.нпTableAdapter = new Kurs.kyrsovayaNPTableAdapters.нпTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.НП = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovayaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovayaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovayaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.нпBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovayaNP)).BeginInit();
            this.fillBy1ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // kyrsovayaDataSet
            // 
            this.kyrsovayaDataSet.DataSetName = "kyrsovayaDataSet";
            this.kyrsovayaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kyrsovayaDataSetBindingSource
            // 
            this.kyrsovayaDataSetBindingSource.DataSource = this.kyrsovayaDataSet;
            this.kyrsovayaDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодСкладаDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.складBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(976, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(292, 150);
            this.dataGridView1.TabIndex = 0;
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
            this.складBindingSource.DataSource = this.kyrsovayaDataSet2;
            // 
            // kyrsovayaDataSet2
            // 
            this.kyrsovayaDataSet2.DataSetName = "kyrsovayaDataSet2";
            this.kyrsovayaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // складTableAdapter
            // 
            this.складTableAdapter.ClearBeforeFill = true;
            // 
            // кодНПDataGridViewTextBoxColumn
            // 
            this.кодНПDataGridViewTextBoxColumn.DataPropertyName = "Код НП";
            this.кодНПDataGridViewTextBoxColumn.HeaderText = "Код НП";
            this.кодНПDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодНПDataGridViewTextBoxColumn.Name = "кодНПDataGridViewTextBoxColumn";
            this.кодНПDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодНПDataGridViewTextBoxColumn.Width = 125;
            // 
            // колвоДозаказаDataGridViewTextBoxColumn
            // 
            this.колвоДозаказаDataGridViewTextBoxColumn.DataPropertyName = "Кол-во дозаказа";
            this.колвоДозаказаDataGridViewTextBoxColumn.HeaderText = "Кол-во дозаказа";
            this.колвоДозаказаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.колвоДозаказаDataGridViewTextBoxColumn.Name = "колвоДозаказаDataGridViewTextBoxColumn";
            this.колвоДозаказаDataGridViewTextBoxColumn.ReadOnly = true;
            this.колвоДозаказаDataGridViewTextBoxColumn.Width = 125;
            // 
            // точкаДозаказаDataGridViewTextBoxColumn
            // 
            this.точкаДозаказаDataGridViewTextBoxColumn.DataPropertyName = "Точка дозаказа";
            this.точкаДозаказаDataGridViewTextBoxColumn.HeaderText = "Точка дозаказа";
            this.точкаДозаказаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.точкаДозаказаDataGridViewTextBoxColumn.Name = "точкаДозаказаDataGridViewTextBoxColumn";
            this.точкаДозаказаDataGridViewTextBoxColumn.ReadOnly = true;
            this.точкаДозаказаDataGridViewTextBoxColumn.Width = 125;
            // 
            // методВозобновленияDataGridViewTextBoxColumn
            // 
            this.методВозобновленияDataGridViewTextBoxColumn.DataPropertyName = "Метод возобновления";
            this.методВозобновленияDataGridViewTextBoxColumn.HeaderText = "Метод возобновления";
            this.методВозобновленияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.методВозобновленияDataGridViewTextBoxColumn.Name = "методВозобновленияDataGridViewTextBoxColumn";
            this.методВозобновленияDataGridViewTextBoxColumn.ReadOnly = true;
            this.методВозобновленияDataGridViewTextBoxColumn.Width = 125;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            this.наименованиеDataGridViewTextBoxColumn.ReadOnly = true;
            this.наименованиеDataGridViewTextBoxColumn.Width = 125;
            // 
            // едИмзеренияDataGridViewTextBoxColumn
            // 
            this.едИмзеренияDataGridViewTextBoxColumn.DataPropertyName = "Ед_ имзерения";
            this.едИмзеренияDataGridViewTextBoxColumn.HeaderText = "Ед_ имзерения";
            this.едИмзеренияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.едИмзеренияDataGridViewTextBoxColumn.Name = "едИмзеренияDataGridViewTextBoxColumn";
            this.едИмзеренияDataGridViewTextBoxColumn.ReadOnly = true;
            this.едИмзеренияDataGridViewTextBoxColumn.Width = 125;
            // 
            // периодОжиданиядниDataGridViewTextBoxColumn
            // 
            this.периодОжиданиядниDataGridViewTextBoxColumn.DataPropertyName = "Период ожидания (дни)";
            this.периодОжиданиядниDataGridViewTextBoxColumn.HeaderText = "Период ожидания (дни)";
            this.периодОжиданиядниDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.периодОжиданиядниDataGridViewTextBoxColumn.Name = "периодОжиданиядниDataGridViewTextBoxColumn";
            this.периодОжиданиядниDataGridViewTextBoxColumn.ReadOnly = true;
            this.периодОжиданиядниDataGridViewTextBoxColumn.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Код НП";
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодНПDataGridViewTextBoxColumn1,
            this.колвоДозаказаDataGridViewTextBoxColumn1,
            this.точкаДозаказаDataGridViewTextBoxColumn1,
            this.методВозобновленияDataGridViewTextBoxColumn1,
            this.наименованиеDataGridViewTextBoxColumn1,
            this.едИмзеренияDataGridViewTextBoxColumn1,
            this.периодОжиданиядниDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.нпBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 53);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(958, 274);
            this.dataGridView2.TabIndex = 1;
            // 
            // кодНПDataGridViewTextBoxColumn1
            // 
            this.кодНПDataGridViewTextBoxColumn1.DataPropertyName = "Код НП";
            this.кодНПDataGridViewTextBoxColumn1.HeaderText = "Код НП";
            this.кодНПDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.кодНПDataGridViewTextBoxColumn1.Name = "кодНПDataGridViewTextBoxColumn1";
            this.кодНПDataGridViewTextBoxColumn1.ReadOnly = true;
            this.кодНПDataGridViewTextBoxColumn1.Width = 62;
            // 
            // колвоДозаказаDataGridViewTextBoxColumn1
            // 
            this.колвоДозаказаDataGridViewTextBoxColumn1.DataPropertyName = "Кол-во дозаказа";
            this.колвоДозаказаDataGridViewTextBoxColumn1.HeaderText = "Кол-во дозаказа";
            this.колвоДозаказаDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.колвоДозаказаDataGridViewTextBoxColumn1.Name = "колвоДозаказаDataGridViewTextBoxColumn1";
            this.колвоДозаказаDataGridViewTextBoxColumn1.ReadOnly = true;
            this.колвоДозаказаDataGridViewTextBoxColumn1.Width = 135;
            // 
            // точкаДозаказаDataGridViewTextBoxColumn1
            // 
            this.точкаДозаказаDataGridViewTextBoxColumn1.DataPropertyName = "Точка дозаказа";
            this.точкаДозаказаDataGridViewTextBoxColumn1.HeaderText = "Точка дозаказа";
            this.точкаДозаказаDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.точкаДозаказаDataGridViewTextBoxColumn1.Name = "точкаДозаказаDataGridViewTextBoxColumn1";
            this.точкаДозаказаDataGridViewTextBoxColumn1.ReadOnly = true;
            this.точкаДозаказаDataGridViewTextBoxColumn1.Width = 130;
            // 
            // методВозобновленияDataGridViewTextBoxColumn1
            // 
            this.методВозобновленияDataGridViewTextBoxColumn1.DataPropertyName = "Метод возобновления";
            this.методВозобновленияDataGridViewTextBoxColumn1.HeaderText = "Метод возобновления";
            this.методВозобновленияDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.методВозобновленияDataGridViewTextBoxColumn1.Name = "методВозобновленияDataGridViewTextBoxColumn1";
            this.методВозобновленияDataGridViewTextBoxColumn1.ReadOnly = true;
            this.методВозобновленияDataGridViewTextBoxColumn1.Width = 168;
            // 
            // наименованиеDataGridViewTextBoxColumn1
            // 
            this.наименованиеDataGridViewTextBoxColumn1.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn1.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.наименованиеDataGridViewTextBoxColumn1.Name = "наименованиеDataGridViewTextBoxColumn1";
            this.наименованиеDataGridViewTextBoxColumn1.ReadOnly = true;
            this.наименованиеDataGridViewTextBoxColumn1.Width = 135;
            // 
            // едИмзеренияDataGridViewTextBoxColumn1
            // 
            this.едИмзеренияDataGridViewTextBoxColumn1.DataPropertyName = "Ед_ имзерения";
            this.едИмзеренияDataGridViewTextBoxColumn1.HeaderText = "Ед_ имзерения";
            this.едИмзеренияDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.едИмзеренияDataGridViewTextBoxColumn1.Name = "едИмзеренияDataGridViewTextBoxColumn1";
            this.едИмзеренияDataGridViewTextBoxColumn1.ReadOnly = true;
            this.едИмзеренияDataGridViewTextBoxColumn1.Width = 127;
            // 
            // периодОжиданиядниDataGridViewTextBoxColumn1
            // 
            this.периодОжиданиядниDataGridViewTextBoxColumn1.DataPropertyName = "Период ожидания (дни)";
            this.периодОжиданиядниDataGridViewTextBoxColumn1.HeaderText = "Период ожидания (дни)";
            this.периодОжиданиядниDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.периодОжиданиядниDataGridViewTextBoxColumn1.Name = "периодОжиданиядниDataGridViewTextBoxColumn1";
            this.периодОжиданиядниDataGridViewTextBoxColumn1.ReadOnly = true;
            this.периодОжиданиядниDataGridViewTextBoxColumn1.Width = 146;
            // 
            // нпBindingSource
            // 
            this.нпBindingSource.DataMember = "нп";
            this.нпBindingSource.DataSource = this.kyrsovayaNP;
            // 
            // kyrsovayaNP
            // 
            this.kyrsovayaNP.DataSetName = "kyrsovayaNP";
            this.kyrsovayaNP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(1281, 31);
            this.fillBy1ToolStrip.TabIndex = 2;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click);
            // 
            // нпTableAdapter
            // 
            this.нпTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(977, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Код НП";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1084, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1084, 238);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(977, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Количество";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1084, 266);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(977, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Код склада";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(980, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить/изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // НП
            // 
            this.НП.AutoSize = true;
            this.НП.Location = new System.Drawing.Point(12, 30);
            this.НП.Name = "НП";
            this.НП.Size = new System.Drawing.Size(28, 17);
            this.НП.TabIndex = 10;
            this.НП.Text = "НП";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(976, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Склады";
            // 
            // KladAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 339);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.НП);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KladAdd";
            this.Load += new System.EventHandler(this.KladAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovayaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovayaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovayaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.нпBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovayaNP)).EndInit();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource kyrsovayaDataSetBindingSource;
        private kyrsovayaDataSet kyrsovayaDataSet;
        private kyrsovayaNP kyrsovayaNP;
        private System.Windows.Forms.BindingSource нпBindingSource;
        private kyrsovayaNPTableAdapters.нпTableAdapter нпTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private kyrsovayaDataSet2 kyrsovayaDataSet2;
        private System.Windows.Forms.BindingSource складBindingSource;
        private kyrsovayaDataSet2TableAdapters.складTableAdapter складTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСкладаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодНПDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn колвоДозаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn точкаДозаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn методВозобновленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn едИмзеренияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn периодОжиданиядниDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодНПDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn колвоДозаказаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn точкаДозаказаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn методВозобновленияDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn едИмзеренияDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn периодОжиданиядниDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label НП;
        private System.Windows.Forms.Label label4;
    }
}