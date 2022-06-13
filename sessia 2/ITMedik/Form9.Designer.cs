namespace ITMedik
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mIS_DIPDataSet5 = new ITMedik.MIS_DIPDataSet5();
            this.jOURNALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jOURNALTableAdapter = new ITMedik.MIS_DIPDataSet5TableAdapters.JOURNALTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDpatientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDoctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDiagnozDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anamezzabolevaniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anamezzhizniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zhalobyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecheniyeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazad = new System.Windows.Forms.Button();
            this.button_Poisk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mIS_DIPDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jOURNALBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dATADataGridViewTextBoxColumn,
            this.talonDataGridViewTextBoxColumn,
            this.iDpatientDataGridViewTextBoxColumn,
            this.iDDoctorDataGridViewTextBoxColumn,
            this.iDDiagnozDataGridViewTextBoxColumn,
            this.anamezzabolevaniaDataGridViewTextBoxColumn,
            this.anamezzhizniDataGridViewTextBoxColumn,
            this.zhalobyDataGridViewTextBoxColumn,
            this.lecheniyeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.jOURNALBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(908, 385);
            this.dataGridView1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(2, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 55);
            this.button2.TabIndex = 7;
            this.button2.Text = "Удалить запись";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(750, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "Создать новую запись";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(226, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(374, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // mIS_DIPDataSet5
            // 
            this.mIS_DIPDataSet5.DataSetName = "MIS_DIPDataSet5";
            this.mIS_DIPDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jOURNALBindingSource
            // 
            this.jOURNALBindingSource.DataMember = "JOURNAL";
            this.jOURNALBindingSource.DataSource = this.mIS_DIPDataSet5;
            // 
            // jOURNALTableAdapter
            // 
            this.jOURNALTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dATADataGridViewTextBoxColumn
            // 
            this.dATADataGridViewTextBoxColumn.DataPropertyName = "DATA";
            this.dATADataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dATADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dATADataGridViewTextBoxColumn.Name = "dATADataGridViewTextBoxColumn";
            this.dATADataGridViewTextBoxColumn.Width = 125;
            // 
            // talonDataGridViewTextBoxColumn
            // 
            this.talonDataGridViewTextBoxColumn.DataPropertyName = "Talon";
            this.talonDataGridViewTextBoxColumn.HeaderText = " Номер талона";
            this.talonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.talonDataGridViewTextBoxColumn.Name = "talonDataGridViewTextBoxColumn";
            this.talonDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDpatientDataGridViewTextBoxColumn
            // 
            this.iDpatientDataGridViewTextBoxColumn.DataPropertyName = "ID_patient";
            this.iDpatientDataGridViewTextBoxColumn.HeaderText = "Пациент";
            this.iDpatientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDpatientDataGridViewTextBoxColumn.Name = "iDpatientDataGridViewTextBoxColumn";
            this.iDpatientDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDDoctorDataGridViewTextBoxColumn
            // 
            this.iDDoctorDataGridViewTextBoxColumn.DataPropertyName = "ID_Doctor";
            this.iDDoctorDataGridViewTextBoxColumn.HeaderText = "Доктор";
            this.iDDoctorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDoctorDataGridViewTextBoxColumn.Name = "iDDoctorDataGridViewTextBoxColumn";
            this.iDDoctorDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDDiagnozDataGridViewTextBoxColumn
            // 
            this.iDDiagnozDataGridViewTextBoxColumn.DataPropertyName = "ID_Diagnoz";
            this.iDDiagnozDataGridViewTextBoxColumn.HeaderText = "Диагноз";
            this.iDDiagnozDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDiagnozDataGridViewTextBoxColumn.Name = "iDDiagnozDataGridViewTextBoxColumn";
            this.iDDiagnozDataGridViewTextBoxColumn.Width = 125;
            // 
            // anamezzabolevaniaDataGridViewTextBoxColumn
            // 
            this.anamezzabolevaniaDataGridViewTextBoxColumn.DataPropertyName = "Anamez_zabolevania";
            this.anamezzabolevaniaDataGridViewTextBoxColumn.HeaderText = "Анамаз заболевания";
            this.anamezzabolevaniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.anamezzabolevaniaDataGridViewTextBoxColumn.Name = "anamezzabolevaniaDataGridViewTextBoxColumn";
            this.anamezzabolevaniaDataGridViewTextBoxColumn.Width = 125;
            // 
            // anamezzhizniDataGridViewTextBoxColumn
            // 
            this.anamezzhizniDataGridViewTextBoxColumn.DataPropertyName = "Anamez_zhizni";
            this.anamezzhizniDataGridViewTextBoxColumn.HeaderText = "Анамез жизни";
            this.anamezzhizniDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.anamezzhizniDataGridViewTextBoxColumn.Name = "anamezzhizniDataGridViewTextBoxColumn";
            this.anamezzhizniDataGridViewTextBoxColumn.Width = 125;
            // 
            // zhalobyDataGridViewTextBoxColumn
            // 
            this.zhalobyDataGridViewTextBoxColumn.DataPropertyName = "Zhaloby";
            this.zhalobyDataGridViewTextBoxColumn.HeaderText = "Жалобы";
            this.zhalobyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.zhalobyDataGridViewTextBoxColumn.Name = "zhalobyDataGridViewTextBoxColumn";
            this.zhalobyDataGridViewTextBoxColumn.Width = 125;
            // 
            // lecheniyeDataGridViewTextBoxColumn
            // 
            this.lecheniyeDataGridViewTextBoxColumn.DataPropertyName = "Lecheniye";
            this.lecheniyeDataGridViewTextBoxColumn.HeaderText = "Лечение";
            this.lecheniyeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lecheniyeDataGridViewTextBoxColumn.Name = "lecheniyeDataGridViewTextBoxColumn";
            this.lecheniyeDataGridViewTextBoxColumn.Width = 125;
            // 
            // Nazad
            // 
            this.Nazad.Location = new System.Drawing.Point(2, 489);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(111, 45);
            this.Nazad.TabIndex = 9;
            this.Nazad.Text = "Назад";
            this.Nazad.UseVisualStyleBackColor = true;
            // 
            // button_Poisk
            // 
            this.button_Poisk.Location = new System.Drawing.Point(606, 24);
            this.button_Poisk.Name = "button_Poisk";
            this.button_Poisk.Size = new System.Drawing.Size(75, 23);
            this.button_Poisk.TabIndex = 10;
            this.button_Poisk.Text = "Поиск";
            this.button_Poisk.UseVisualStyleBackColor = true;
            this.button_Poisk.Click += new System.EventHandler(this.button_Poisk_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 546);
            this.Controls.Add(this.button_Poisk);
            this.Controls.Add(this.Nazad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form9";
            this.Text = "Журнал ";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mIS_DIPDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jOURNALBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private MIS_DIPDataSet5 mIS_DIPDataSet5;
        private System.Windows.Forms.BindingSource jOURNALBindingSource;
        private MIS_DIPDataSet5TableAdapters.JOURNALTableAdapter jOURNALTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn talonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDpatientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDoctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDiagnozDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anamezzabolevaniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anamezzhizniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zhalobyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecheniyeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Nazad;
        private System.Windows.Forms.Button button_Poisk;
    }
}