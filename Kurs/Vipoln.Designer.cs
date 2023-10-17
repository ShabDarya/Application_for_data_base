
namespace Kurs
{
    partial class Vipoln
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
            this.кодПЗDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодНПDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колвоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаСозданияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗавершенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.производственныйЗаказBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kyrsovayaDataSet42 = new Kurs.kyrsovayaDataSet42();
            this.производственный_заказTableAdapter = new Kurs.kyrsovayaDataSet42TableAdapters.производственный_заказTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.кодПотребленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПЗDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодНПDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодТКDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерОперацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.журналПотребленияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kyrsovayaDataSet43 = new Kurs.kyrsovayaDataSet43();
            this.журнал_потребленияTableAdapter = new Kurs.kyrsovayaDataSet43TableAdapters.журнал_потребленияTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.производственныйЗаказBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovayaDataSet42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.журналПотребленияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovayaDataSet43)).BeginInit();
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
            this.кодПЗDataGridViewTextBoxColumn,
            this.кодНПDataGridViewTextBoxColumn,
            this.колвоDataGridViewTextBoxColumn,
            this.датаСозданияDataGridViewTextBoxColumn,
            this.датаЗавершенияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.производственныйЗаказBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(578, 186);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // кодПЗDataGridViewTextBoxColumn
            // 
            this.кодПЗDataGridViewTextBoxColumn.DataPropertyName = "Код ПЗ";
            this.кодПЗDataGridViewTextBoxColumn.HeaderText = "Код ПЗ";
            this.кодПЗDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодПЗDataGridViewTextBoxColumn.Name = "кодПЗDataGridViewTextBoxColumn";
            this.кодПЗDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодПЗDataGridViewTextBoxColumn.Width = 62;
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
            // колвоDataGridViewTextBoxColumn
            // 
            this.колвоDataGridViewTextBoxColumn.DataPropertyName = "Кол-во";
            this.колвоDataGridViewTextBoxColumn.HeaderText = "Кол-во";
            this.колвоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.колвоDataGridViewTextBoxColumn.Name = "колвоDataGridViewTextBoxColumn";
            this.колвоDataGridViewTextBoxColumn.ReadOnly = true;
            this.колвоDataGridViewTextBoxColumn.Width = 82;
            // 
            // датаСозданияDataGridViewTextBoxColumn
            // 
            this.датаСозданияDataGridViewTextBoxColumn.DataPropertyName = "Дата создания";
            this.датаСозданияDataGridViewTextBoxColumn.HeaderText = "Дата создания";
            this.датаСозданияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаСозданияDataGridViewTextBoxColumn.Name = "датаСозданияDataGridViewTextBoxColumn";
            this.датаСозданияDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаСозданияDataGridViewTextBoxColumn.Width = 126;
            // 
            // датаЗавершенияDataGridViewTextBoxColumn
            // 
            this.датаЗавершенияDataGridViewTextBoxColumn.DataPropertyName = "Дата завершения";
            this.датаЗавершенияDataGridViewTextBoxColumn.HeaderText = "Дата завершения";
            this.датаЗавершенияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаЗавершенияDataGridViewTextBoxColumn.Name = "датаЗавершенияDataGridViewTextBoxColumn";
            this.датаЗавершенияDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаЗавершенияDataGridViewTextBoxColumn.Width = 143;
            // 
            // производственныйЗаказBindingSource
            // 
            this.производственныйЗаказBindingSource.DataMember = "производственный заказ";
            this.производственныйЗаказBindingSource.DataSource = this.kyrsovayaDataSet42;
            // 
            // kyrsovayaDataSet42
            // 
            this.kyrsovayaDataSet42.DataSetName = "kyrsovayaDataSet42";
            this.kyrsovayaDataSet42.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // производственный_заказTableAdapter
            // 
            this.производственный_заказTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView2.Location = new System.Drawing.Point(598, 13);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(378, 186);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Код ПЗ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 62;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Код ТК ПЗ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 82;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Дата изменения";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 135;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataGridView3.Location = new System.Drawing.Point(12, 205);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(963, 227);
            this.dataGridView3.TabIndex = 2;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Код ТК";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 62;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Номер операции";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 136;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Номер РЦ";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 96;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Время перевода";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 134;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Время подготовки";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 144;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Время работы";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 121;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Описание";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 103;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView4.ColumnHeadersHeight = 29;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            this.dataGridView4.Location = new System.Drawing.Point(983, 13);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(402, 294);
            this.dataGridView4.TabIndex = 0;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Код выполн. операций";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 187;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Код ПЗ";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 85;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Код ТК";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 84;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Номер операции";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 148;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Потраченное время";
            this.Column15.MinimumWidth = 6;
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 170;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(981, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(981, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Выход ГП";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(981, 400);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 32);
            this.button3.TabIndex = 5;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодПотребленияDataGridViewTextBoxColumn,
            this.кодПЗDataGridViewTextBoxColumn1,
            this.кодНПDataGridViewTextBoxColumn1,
            this.кодТКDataGridViewTextBoxColumn,
            this.номерОперацииDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.журналПотребленияBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(1117, 314);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 24;
            this.dataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView5.Size = new System.Drawing.Size(268, 118);
            this.dataGridView5.TabIndex = 6;
            // 
            // кодПотребленияDataGridViewTextBoxColumn
            // 
            this.кодПотребленияDataGridViewTextBoxColumn.DataPropertyName = "Код потребления";
            this.кодПотребленияDataGridViewTextBoxColumn.HeaderText = "Код потребления";
            this.кодПотребленияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодПотребленияDataGridViewTextBoxColumn.Name = "кодПотребленияDataGridViewTextBoxColumn";
            this.кодПотребленияDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодПотребленияDataGridViewTextBoxColumn.Width = 140;
            // 
            // кодПЗDataGridViewTextBoxColumn1
            // 
            this.кодПЗDataGridViewTextBoxColumn1.DataPropertyName = "Код ПЗ";
            this.кодПЗDataGridViewTextBoxColumn1.HeaderText = "Код ПЗ";
            this.кодПЗDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.кодПЗDataGridViewTextBoxColumn1.Name = "кодПЗDataGridViewTextBoxColumn1";
            this.кодПЗDataGridViewTextBoxColumn1.ReadOnly = true;
            this.кодПЗDataGridViewTextBoxColumn1.Width = 62;
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
            // кодТКDataGridViewTextBoxColumn
            // 
            this.кодТКDataGridViewTextBoxColumn.DataPropertyName = "Код ТК";
            this.кодТКDataGridViewTextBoxColumn.HeaderText = "Код ТК";
            this.кодТКDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодТКDataGridViewTextBoxColumn.Name = "кодТКDataGridViewTextBoxColumn";
            this.кодТКDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодТКDataGridViewTextBoxColumn.Width = 62;
            // 
            // номерОперацииDataGridViewTextBoxColumn
            // 
            this.номерОперацииDataGridViewTextBoxColumn.DataPropertyName = "Номер операции";
            this.номерОперацииDataGridViewTextBoxColumn.HeaderText = "Номер операции";
            this.номерОперацииDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерОперацииDataGridViewTextBoxColumn.Name = "номерОперацииDataGridViewTextBoxColumn";
            this.номерОперацииDataGridViewTextBoxColumn.ReadOnly = true;
            this.номерОперацииDataGridViewTextBoxColumn.Width = 136;
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
            // журналПотребленияBindingSource
            // 
            this.журналПотребленияBindingSource.DataMember = "журнал потребления";
            this.журналПотребленияBindingSource.DataSource = this.kyrsovayaDataSet43;
            // 
            // kyrsovayaDataSet43
            // 
            this.kyrsovayaDataSet43.DataSetName = "kyrsovayaDataSet43";
            this.kyrsovayaDataSet43.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // журнал_потребленияTableAdapter
            // 
            this.журнал_потребленияTableAdapter.ClearBeforeFill = true;
            // 
            // Vipoln
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 444);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Vipoln";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выполнение операций";
            this.Load += new System.EventHandler(this.Vipoln_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.производственныйЗаказBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovayaDataSet42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.журналПотребленияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovayaDataSet43)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private kyrsovayaDataSet42 kyrsovayaDataSet42;
        private System.Windows.Forms.BindingSource производственныйЗаказBindingSource;
        private kyrsovayaDataSet42TableAdapters.производственный_заказTableAdapter производственный_заказTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПЗDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодНПDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn колвоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаСозданияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗавершенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView5;
        private kyrsovayaDataSet43 kyrsovayaDataSet43;
        private System.Windows.Forms.BindingSource журналПотребленияBindingSource;
        private kyrsovayaDataSet43TableAdapters.журнал_потребленияTableAdapter журнал_потребленияTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПотребленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПЗDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодНПDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодТКDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерОперацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
    }
}