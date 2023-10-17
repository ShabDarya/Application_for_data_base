
namespace Kurs
{
    partial class SostavSpec
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
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.едИмзеренияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСпецификацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодТКDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.нпBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kyrsovayaDataSet16 = new Kurs.kyrsovayaDataSet16();
            this.нпTableAdapter = new Kurs.kyrsovayaDataSet16TableAdapters.нпTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.кодТКDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерОперацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерРЦDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.составТкBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kyrsovayaDataSet17 = new Kurs.kyrsovayaDataSet17();
            this.состав_ткTableAdapter = new Kurs.kyrsovayaDataSet17TableAdapters.состав_ткTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.нпBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovayaDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.составТкBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovayaDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
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
            this.наименованиеDataGridViewTextBoxColumn,
            this.едИмзеренияDataGridViewTextBoxColumn,
            this.кодСпецификацииDataGridViewTextBoxColumn,
            this.кодТКDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.нпBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(541, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(462, 279);
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
            // нпBindingSource
            // 
            this.нпBindingSource.DataMember = "нп";
            this.нпBindingSource.DataSource = this.kyrsovayaDataSet16;
            // 
            // kyrsovayaDataSet16
            // 
            this.kyrsovayaDataSet16.DataSetName = "kyrsovayaDataSet16";
            this.kyrsovayaDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // нпTableAdapter
            // 
            this.нпTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодТКDataGridViewTextBoxColumn1,
            this.номерОперацииDataGridViewTextBoxColumn,
            this.номерРЦDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.составТкBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(541, 296);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(462, 117);
            this.dataGridView2.TabIndex = 1;
            // 
            // кодТКDataGridViewTextBoxColumn1
            // 
            this.кодТКDataGridViewTextBoxColumn1.DataPropertyName = "Код ТК";
            this.кодТКDataGridViewTextBoxColumn1.HeaderText = "Код ТК";
            this.кодТКDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.кодТКDataGridViewTextBoxColumn1.Name = "кодТКDataGridViewTextBoxColumn1";
            this.кодТКDataGridViewTextBoxColumn1.ReadOnly = true;
            this.кодТКDataGridViewTextBoxColumn1.Width = 62;
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
            // номерРЦDataGridViewTextBoxColumn
            // 
            this.номерРЦDataGridViewTextBoxColumn.DataPropertyName = "Номер РЦ";
            this.номерРЦDataGridViewTextBoxColumn.HeaderText = "Номер РЦ";
            this.номерРЦDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерРЦDataGridViewTextBoxColumn.Name = "номерРЦDataGridViewTextBoxColumn";
            this.номерРЦDataGridViewTextBoxColumn.ReadOnly = true;
            this.номерРЦDataGridViewTextBoxColumn.Width = 96;
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.описаниеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            this.описаниеDataGridViewTextBoxColumn.ReadOnly = true;
            this.описаниеDataGridViewTextBoxColumn.Width = 103;
            // 
            // составТкBindingSource
            // 
            this.составТкBindingSource.DataMember = "состав тк";
            this.составТкBindingSource.DataSource = this.kyrsovayaDataSet17;
            // 
            // kyrsovayaDataSet17
            // 
            this.kyrsovayaDataSet17.DataSetName = "kyrsovayaDataSet17";
            this.kyrsovayaDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // состав_ткTableAdapter
            // 
            this.состав_ткTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView3.Location = new System.Drawing.Point(12, 12);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(523, 278);
            this.dataGridView3.TabIndex = 2;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Код спецификации";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 149;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Код НП";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 62;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Порядковый номер";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Кол-во";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 82;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ед. изм";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Код НП (не повторяется)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(193, 298);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(193, 326);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 22);
            this.textBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Порядковый номер";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(193, 355);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(147, 22);
            this.textBox3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Кол-во";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(193, 386);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(147, 22);
            this.textBox4.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ед. изм.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(406, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(406, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 34);
            this.button2.TabIndex = 12;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(406, 379);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 34);
            this.button3.TabIndex = 13;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(346, 298);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 115);
            this.button4.TabIndex = 14;
            this.button4.Text = "Очистить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SostavSpec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 431);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SostavSpec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Состав";
            this.Load += new System.EventHandler(this.SostavSpec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.нпBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovayaDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.составТкBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovayaDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private kyrsovayaDataSet16 kyrsovayaDataSet16;
        private System.Windows.Forms.BindingSource нпBindingSource;
        private kyrsovayaDataSet16TableAdapters.нпTableAdapter нпTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодНПDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn едИмзеренияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСпецификацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодТКDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private kyrsovayaDataSet17 kyrsovayaDataSet17;
        private System.Windows.Forms.BindingSource составТкBindingSource;
        private kyrsovayaDataSet17TableAdapters.состав_ткTableAdapter состав_ткTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодТКDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерОперацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерРЦDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
    }
}