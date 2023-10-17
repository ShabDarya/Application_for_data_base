
namespace Kurs
{
    partial class MenedR
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
            this.кодРеализацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодНПDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСкладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колвоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.реализацияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kyrsovayaDataSet7 = new Kurs.kyrsovayaDataSet7();
            this.реализацияTableAdapter = new Kurs.kyrsovayaDataSet7TableAdapters.реализацияTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.реализацияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovayaDataSet7)).BeginInit();
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
            this.кодРеализацииDataGridViewTextBoxColumn,
            this.кодНПDataGridViewTextBoxColumn,
            this.кодСкладаDataGridViewTextBoxColumn,
            this.колвоDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.реализацияBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(440, 250);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодРеализацииDataGridViewTextBoxColumn
            // 
            this.кодРеализацииDataGridViewTextBoxColumn.DataPropertyName = "Код реализации";
            this.кодРеализацииDataGridViewTextBoxColumn.HeaderText = "Код реализации";
            this.кодРеализацииDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодРеализацииDataGridViewTextBoxColumn.Name = "кодРеализацииDataGridViewTextBoxColumn";
            this.кодРеализацииDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодРеализацииDataGridViewTextBoxColumn.Width = 133;
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
            // кодСкладаDataGridViewTextBoxColumn
            // 
            this.кодСкладаDataGridViewTextBoxColumn.DataPropertyName = "Код склада";
            this.кодСкладаDataGridViewTextBoxColumn.HeaderText = "Код склада";
            this.кодСкладаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодСкладаDataGridViewTextBoxColumn.Name = "кодСкладаDataGridViewTextBoxColumn";
            this.кодСкладаDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодСкладаDataGridViewTextBoxColumn.Width = 103;
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
            // реализацияBindingSource
            // 
            this.реализацияBindingSource.DataMember = "реализация";
            this.реализацияBindingSource.DataSource = this.kyrsovayaDataSet7;
            // 
            // kyrsovayaDataSet7
            // 
            this.kyrsovayaDataSet7.DataSetName = "kyrsovayaDataSet7";
            this.kyrsovayaDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // реализацияTableAdapter
            // 
            this.реализацияTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(440, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(171, 337);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(321, 337);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 40);
            this.button4.TabIndex = 4;
            this.button4.Text = "Редактировать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Реализация";
            // 
            // MenedR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 388);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MenedR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реализация";
            this.Load += new System.EventHandler(this.MenedR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.реализацияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyrsovayaDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private kyrsovayaDataSet7 kyrsovayaDataSet7;
        private System.Windows.Forms.BindingSource реализацияBindingSource;
        private kyrsovayaDataSet7TableAdapters.реализацияTableAdapter реализацияTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодРеализацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодНПDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСкладаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn колвоDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}