namespace ITMedik
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDpatientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fRESTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lASTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATRONYMICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIRTHDAYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pASSPORTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sERIALIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMBERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHAKTADRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHOTODataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.pRIMECHANIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grazhdanstvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snilsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTDIRECTORORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mIS_DIPDataSet = new ITMedik.MIS_DIPDataSet();
            this.pATIENTDIRECTORORYTableAdapter = new ITMedik.MIS_DIPDataSetTableAdapters.PATIENTDIRECTORORYTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTDIRECTORORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mIS_DIPDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(294, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(388, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(877, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "Создать карту пациента";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDpatientDataGridViewTextBoxColumn,
            this.fRESTNAMEDataGridViewTextBoxColumn,
            this.lASTNAMEDataGridViewTextBoxColumn,
            this.pATRONYMICDataGridViewTextBoxColumn,
            this.bIRTHDAYDataGridViewTextBoxColumn,
            this.pOLDataGridViewTextBoxColumn,
            this.pASSPORTDataGridViewTextBoxColumn,
            this.sERIALIDDataGridViewTextBoxColumn,
            this.nUMBERIDDataGridViewTextBoxColumn,
            this.pHAKTADRESSDataGridViewTextBoxColumn,
            this.aDRESSDataGridViewTextBoxColumn,
            this.pHONEDataGridViewTextBoxColumn,
            this.pHOTODataGridViewImageColumn,
            this.pRIMECHANIEDataGridViewTextBoxColumn,
            this.grazhdanstvoDataGridViewTextBoxColumn,
            this.snilsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pATIENTDIRECTORORYBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(993, 428);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // iDpatientDataGridViewTextBoxColumn
            // 
            this.iDpatientDataGridViewTextBoxColumn.DataPropertyName = "ID_patient";
            this.iDpatientDataGridViewTextBoxColumn.HeaderText = "Код пациента";
            this.iDpatientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDpatientDataGridViewTextBoxColumn.Name = "iDpatientDataGridViewTextBoxColumn";
            this.iDpatientDataGridViewTextBoxColumn.Width = 125;
            // 
            // fRESTNAMEDataGridViewTextBoxColumn
            // 
            this.fRESTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FRESTNAME";
            this.fRESTNAMEDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.fRESTNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fRESTNAMEDataGridViewTextBoxColumn.Name = "fRESTNAMEDataGridViewTextBoxColumn";
            this.fRESTNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // lASTNAMEDataGridViewTextBoxColumn
            // 
            this.lASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LASTNAME";
            this.lASTNAMEDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.lASTNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lASTNAMEDataGridViewTextBoxColumn.Name = "lASTNAMEDataGridViewTextBoxColumn";
            this.lASTNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // pATRONYMICDataGridViewTextBoxColumn
            // 
            this.pATRONYMICDataGridViewTextBoxColumn.DataPropertyName = "PATRONYMIC";
            this.pATRONYMICDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.pATRONYMICDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pATRONYMICDataGridViewTextBoxColumn.Name = "pATRONYMICDataGridViewTextBoxColumn";
            this.pATRONYMICDataGridViewTextBoxColumn.Width = 125;
            // 
            // bIRTHDAYDataGridViewTextBoxColumn
            // 
            this.bIRTHDAYDataGridViewTextBoxColumn.DataPropertyName = "BIRTHDAY";
            this.bIRTHDAYDataGridViewTextBoxColumn.HeaderText = "День рождения";
            this.bIRTHDAYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bIRTHDAYDataGridViewTextBoxColumn.Name = "bIRTHDAYDataGridViewTextBoxColumn";
            this.bIRTHDAYDataGridViewTextBoxColumn.Width = 125;
            // 
            // pOLDataGridViewTextBoxColumn
            // 
            this.pOLDataGridViewTextBoxColumn.DataPropertyName = "POL";
            this.pOLDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.pOLDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pOLDataGridViewTextBoxColumn.Name = "pOLDataGridViewTextBoxColumn";
            this.pOLDataGridViewTextBoxColumn.Width = 125;
            // 
            // pASSPORTDataGridViewTextBoxColumn
            // 
            this.pASSPORTDataGridViewTextBoxColumn.DataPropertyName = "PASSPORT";
            this.pASSPORTDataGridViewTextBoxColumn.HeaderText = "Тип документа";
            this.pASSPORTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pASSPORTDataGridViewTextBoxColumn.Name = "pASSPORTDataGridViewTextBoxColumn";
            this.pASSPORTDataGridViewTextBoxColumn.Width = 125;
            // 
            // sERIALIDDataGridViewTextBoxColumn
            // 
            this.sERIALIDDataGridViewTextBoxColumn.DataPropertyName = "SERIALID";
            this.sERIALIDDataGridViewTextBoxColumn.HeaderText = "Серия";
            this.sERIALIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sERIALIDDataGridViewTextBoxColumn.Name = "sERIALIDDataGridViewTextBoxColumn";
            this.sERIALIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nUMBERIDDataGridViewTextBoxColumn
            // 
            this.nUMBERIDDataGridViewTextBoxColumn.DataPropertyName = "NUMBERID";
            this.nUMBERIDDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.nUMBERIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nUMBERIDDataGridViewTextBoxColumn.Name = "nUMBERIDDataGridViewTextBoxColumn";
            this.nUMBERIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // pHAKTADRESSDataGridViewTextBoxColumn
            // 
            this.pHAKTADRESSDataGridViewTextBoxColumn.DataPropertyName = "PHAKTADRESS";
            this.pHAKTADRESSDataGridViewTextBoxColumn.HeaderText = "Факт.адресс";
            this.pHAKTADRESSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pHAKTADRESSDataGridViewTextBoxColumn.Name = "pHAKTADRESSDataGridViewTextBoxColumn";
            this.pHAKTADRESSDataGridViewTextBoxColumn.Width = 125;
            // 
            // aDRESSDataGridViewTextBoxColumn
            // 
            this.aDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADRESS";
            this.aDRESSDataGridViewTextBoxColumn.HeaderText = "Адресс";
            this.aDRESSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aDRESSDataGridViewTextBoxColumn.Name = "aDRESSDataGridViewTextBoxColumn";
            this.aDRESSDataGridViewTextBoxColumn.Width = 125;
            // 
            // pHONEDataGridViewTextBoxColumn
            // 
            this.pHONEDataGridViewTextBoxColumn.DataPropertyName = "PHONE";
            this.pHONEDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.pHONEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pHONEDataGridViewTextBoxColumn.Name = "pHONEDataGridViewTextBoxColumn";
            this.pHONEDataGridViewTextBoxColumn.Width = 125;
            // 
            // pHOTODataGridViewImageColumn
            // 
            this.pHOTODataGridViewImageColumn.DataPropertyName = "PHOTO";
            this.pHOTODataGridViewImageColumn.HeaderText = "Фото";
            this.pHOTODataGridViewImageColumn.MinimumWidth = 6;
            this.pHOTODataGridViewImageColumn.Name = "pHOTODataGridViewImageColumn";
            this.pHOTODataGridViewImageColumn.Width = 125;
            // 
            // pRIMECHANIEDataGridViewTextBoxColumn
            // 
            this.pRIMECHANIEDataGridViewTextBoxColumn.DataPropertyName = "PRIMECHANIE";
            this.pRIMECHANIEDataGridViewTextBoxColumn.HeaderText = "Примечание";
            this.pRIMECHANIEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRIMECHANIEDataGridViewTextBoxColumn.Name = "pRIMECHANIEDataGridViewTextBoxColumn";
            this.pRIMECHANIEDataGridViewTextBoxColumn.Width = 125;
            // 
            // grazhdanstvoDataGridViewTextBoxColumn
            // 
            this.grazhdanstvoDataGridViewTextBoxColumn.DataPropertyName = "Grazhdanstvo";
            this.grazhdanstvoDataGridViewTextBoxColumn.HeaderText = "Гражданство";
            this.grazhdanstvoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.grazhdanstvoDataGridViewTextBoxColumn.Name = "grazhdanstvoDataGridViewTextBoxColumn";
            this.grazhdanstvoDataGridViewTextBoxColumn.Width = 125;
            // 
            // snilsDataGridViewTextBoxColumn
            // 
            this.snilsDataGridViewTextBoxColumn.DataPropertyName = "Snils";
            this.snilsDataGridViewTextBoxColumn.HeaderText = "Снилс";
            this.snilsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.snilsDataGridViewTextBoxColumn.Name = "snilsDataGridViewTextBoxColumn";
            this.snilsDataGridViewTextBoxColumn.Width = 125;
            // 
            // pATIENTDIRECTORORYBindingSource
            // 
            this.pATIENTDIRECTORORYBindingSource.DataMember = "PATIENTDIRECTORORY";
            this.pATIENTDIRECTORORYBindingSource.DataSource = this.mIS_DIPDataSet;
            // 
            // mIS_DIPDataSet
            // 
            this.mIS_DIPDataSet.DataSetName = "MIS_DIPDataSet";
            this.mIS_DIPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pATIENTDIRECTORORYTableAdapter
            // 
            this.pATIENTDIRECTORORYTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 44);
            this.button3.TabIndex = 5;
            this.button3.Text = "Удалить карту пациента";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 71);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(184, 20);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Подтвердите удаление";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(689, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 548);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Поиск краты пациента";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTDIRECTORORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mIS_DIPDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MIS_DIPDataSet mIS_DIPDataSet;
        private System.Windows.Forms.BindingSource pATIENTDIRECTORORYBindingSource;
        private MIS_DIPDataSetTableAdapters.PATIENTDIRECTORORYTableAdapter pATIENTDIRECTORORYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDpatientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fRESTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lASTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATRONYMICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIRTHDAYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pASSPORTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sERIALIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMBERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHAKTADRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pHOTODataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIMECHANIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grazhdanstvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
    }
}