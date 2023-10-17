
namespace Kurs
{
    partial class VihodGP
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
            this.kyrsovayaDataSet44 = new Kurs.kyrsovayaDataSet44();
            this.нпBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.нпTableAdapter = new Kurs.kyrsovayaDataSet44TableAdapters.нпTableAdapter();
            this.кодНПDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.методВозобновленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.едИмзеренияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСпецификацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодТКDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.kyrsovayaDataSet45 = new Kurs.kyrsovayaDataSet45();
            this.складBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.складTableAdapter = new Kurs.kyrsovayaDataSet45TableAdapters.складTableAdapter();
            this.кодСкладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.kyrsovayaDataSet46 = new Kurs.kyrsovayaDataSet46();
            this.выходГпBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.выход_гпTableAdapter = new Kurs.kyrsovayaDataSet46TableAdapters.выход_гпTableAdapter();
            this.кодВыходаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПЗDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодНПDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСкладаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovayaDataSet44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.нпBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovayaDataSet45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovayaDataSet46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выходГпBindingSource)).BeginInit();
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
            this.методВозобновленияDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.едИмзеренияDataGridViewTextBoxColumn,
            this.кодСпецификацииDataGridViewTextBoxColumn,
            this.кодТКDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.нпBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(810, 129);
            this.dataGridView1.TabIndex = 0;
            // 
            // kyrsovayaDataSet44
            // 
            this.kyrsovayaDataSet44.DataSetName = "kyrsovayaDataSet44";
            this.kyrsovayaDataSet44.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // нпBindingSource
            // 
            this.нпBindingSource.DataMember = "нп";
            this.нпBindingSource.DataSource = this.kyrsovayaDataSet44;
            // 
            // нпTableAdapter
            // 
            this.нпTableAdapter.ClearBeforeFill = true;
            // 
            // кодНПDataGridViewTextBoxColumn
            // 
            this.кодНПDataGridViewTextBoxColumn.DataPropertyName = "Код НП";
            this.кодНПDataGridViewTextBoxColumn.HeaderText = "Код НП";
            this.кодНПDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодНПDataGridViewTextBoxColumn.Name = "кодНПDataGridViewTextBoxColumn";
            this.кодНПDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодНПDataGridViewTextBoxColumn.Width = 86;
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
            // кодСпецификацииDataGridViewTextBoxColumn
            // 
            this.кодСпецификацииDataGridViewTextBoxColumn.DataPropertyName = "Код спецификации";
            this.кодСпецификацииDataGridViewTextBoxColumn.HeaderText = "Код спецификации";
            this.кодСпецификацииDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодСпецификацииDataGridViewTextBoxColumn.Name = "кодСпецификацииDataGridViewTextBoxColumn";
            this.кодСпецификацииDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодСпецификацииDataGridViewTextBoxColumn.Width = 149;
            // 
            // кодТКDataGridViewTextBoxColumn
            // 
            this.кодТКDataGridViewTextBoxColumn.DataPropertyName = "Код ТК";
            this.кодТКDataGridViewTextBoxColumn.HeaderText = "Код ТК";
            this.кодТКDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодТКDataGridViewTextBoxColumn.Name = "кодТКDataGridViewTextBoxColumn";
            this.кодТКDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодТКDataGridViewTextBoxColumn.Width = 62;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодСкладаDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.складBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(582, 13);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(240, 146);
            this.dataGridView2.TabIndex = 1;
            // 
            // kyrsovayaDataSet45
            // 
            this.kyrsovayaDataSet45.DataSetName = "kyrsovayaDataSet45";
            this.kyrsovayaDataSet45.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // складBindingSource
            // 
            this.складBindingSource.DataMember = "склад";
            this.складBindingSource.DataSource = this.kyrsovayaDataSet45;
            // 
            // складTableAdapter
            // 
            this.складTableAdapter.ClearBeforeFill = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Код НП";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 301);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(274, 301);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(469, 301);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Код склада";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(575, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 24);
            this.button1.TabIndex = 8;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(665, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 24);
            this.button2.TabIndex = 9;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(745, 301);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 24);
            this.button3.TabIndex = 10;
            this.button3.Text = "Редактировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодВыходаDataGridViewTextBoxColumn,
            this.кодПЗDataGridViewTextBoxColumn,
            this.кодНПDataGridViewTextBoxColumn1,
            this.количествоDataGridViewTextBoxColumn,
            this.кодСкладаDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.выходГпBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 13);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(564, 146);
            this.dataGridView3.TabIndex = 11;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // kyrsovayaDataSet46
            // 
            this.kyrsovayaDataSet46.DataSetName = "kyrsovayaDataSet46";
            this.kyrsovayaDataSet46.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // выходГпBindingSource
            // 
            this.выходГпBindingSource.DataMember = "выход гп";
            this.выходГпBindingSource.DataSource = this.kyrsovayaDataSet46;
            // 
            // выход_гпTableAdapter
            // 
            this.выход_гпTableAdapter.ClearBeforeFill = true;
            // 
            // кодВыходаDataGridViewTextBoxColumn
            // 
            this.кодВыходаDataGridViewTextBoxColumn.DataPropertyName = "Код выхода";
            this.кодВыходаDataGridViewTextBoxColumn.HeaderText = "Код выхода";
            this.кодВыходаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодВыходаDataGridViewTextBoxColumn.Name = "кодВыходаDataGridViewTextBoxColumn";
            this.кодВыходаDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодВыходаDataGridViewTextBoxColumn.Width = 113;
            // 
            // кодПЗDataGridViewTextBoxColumn
            // 
            this.кодПЗDataGridViewTextBoxColumn.DataPropertyName = "Код ПЗ";
            this.кодПЗDataGridViewTextBoxColumn.HeaderText = "Код ПЗ";
            this.кодПЗDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодПЗDataGridViewTextBoxColumn.Name = "кодПЗDataGridViewTextBoxColumn";
            this.кодПЗDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодПЗDataGridViewTextBoxColumn.Width = 85;
            // 
            // кодНПDataGridViewTextBoxColumn1
            // 
            this.кодНПDataGridViewTextBoxColumn1.DataPropertyName = "Код НП";
            this.кодНПDataGridViewTextBoxColumn1.HeaderText = "Код НП";
            this.кодНПDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.кодНПDataGridViewTextBoxColumn1.Name = "кодНПDataGridViewTextBoxColumn1";
            this.кодНПDataGridViewTextBoxColumn1.ReadOnly = true;
            this.кодНПDataGridViewTextBoxColumn1.Width = 86;
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            this.количествоDataGridViewTextBoxColumn.ReadOnly = true;
            this.количествоDataGridViewTextBoxColumn.Width = 115;
            // 
            // кодСкладаDataGridViewTextBoxColumn1
            // 
            this.кодСкладаDataGridViewTextBoxColumn1.DataPropertyName = "Код склада";
            this.кодСкладаDataGridViewTextBoxColumn1.HeaderText = "Код склада";
            this.кодСкладаDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.кодСкладаDataGridViewTextBoxColumn1.Name = "кодСкладаDataGridViewTextBoxColumn1";
            this.кодСкладаDataGridViewTextBoxColumn1.ReadOnly = true;
            this.кодСкладаDataGridViewTextBoxColumn1.Width = 112;
            // 
            // VihodGP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 349);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VihodGP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выход ГП";
            this.Load += new System.EventHandler(this.VihodGP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovayaDataSet44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.нпBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovayaDataSet45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovayaDataSet46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выходГпBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private kyrsovayaDataSet44 kyrsovayaDataSet44;
        private System.Windows.Forms.BindingSource нпBindingSource;
        private kyrsovayaDataSet44TableAdapters.нпTableAdapter нпTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодНПDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn методВозобновленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn едИмзеренияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСпецификацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодТКDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private kyrsovayaDataSet45 kyrsovayaDataSet45;
        private System.Windows.Forms.BindingSource складBindingSource;
        private kyrsovayaDataSet45TableAdapters.складTableAdapter складTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСкладаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private kyrsovayaDataSet46 kyrsovayaDataSet46;
        private System.Windows.Forms.BindingSource выходГпBindingSource;
        private kyrsovayaDataSet46TableAdapters.выход_гпTableAdapter выход_гпTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодВыходаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПЗDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодНПDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСкладаDataGridViewTextBoxColumn1;
    }
}