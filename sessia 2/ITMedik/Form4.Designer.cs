namespace ITMedik
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dOCTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mIS_DIPDataSet1 = new ITMedik.MIS_DIPDataSet1();
            this.dOCTORTableAdapter = new ITMedik.MIS_DIPDataSet1TableAdapters.DOCTORTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.mIS_DIPDataSet4 = new ITMedik.MIS_DIPDataSet4();
            this.dOCTORBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dOCTORTableAdapter1 = new ITMedik.MIS_DIPDataSet4TableAdapters.DOCTORTableAdapter();
            this.iDDoctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fERSTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lASTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATRONYMICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIRTHDAYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POSITION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kABINETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mIS_DIPDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mIS_DIPDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDoctorDataGridViewTextBoxColumn,
            this.fERSTNAMEDataGridViewTextBoxColumn,
            this.lASTNAMEDataGridViewTextBoxColumn,
            this.pATRONYMICDataGridViewTextBoxColumn,
            this.bIRTHDAYDataGridViewTextBoxColumn,
            this.POSITION,
            this.kABINETDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dOCTORBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 359);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // dOCTORBindingSource
            // 
            this.dOCTORBindingSource.DataMember = "DOCTOR";
            this.dOCTORBindingSource.DataSource = this.mIS_DIPDataSet1;
            // 
            // mIS_DIPDataSet1
            // 
            this.mIS_DIPDataSet1.DataSetName = "MIS_DIPDataSet1";
            this.mIS_DIPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dOCTORTableAdapter
            // 
            this.dOCTORTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(674, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Регистрация Нового врача";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(231, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(484, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(35, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 49);
            this.button3.TabIndex = 4;
            this.button3.Text = "Удалить карту врача";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // mIS_DIPDataSet4
            // 
            this.mIS_DIPDataSet4.DataSetName = "MIS_DIPDataSet4";
            this.mIS_DIPDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dOCTORBindingSource1
            // 
            this.dOCTORBindingSource1.DataMember = "DOCTOR";
            this.dOCTORBindingSource1.DataSource = this.mIS_DIPDataSet4;
            // 
            // dOCTORTableAdapter1
            // 
            this.dOCTORTableAdapter1.ClearBeforeFill = true;
            // 
            // iDDoctorDataGridViewTextBoxColumn
            // 
            this.iDDoctorDataGridViewTextBoxColumn.DataPropertyName = "ID_Doctor";
            this.iDDoctorDataGridViewTextBoxColumn.HeaderText = "Код доктора";
            this.iDDoctorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDoctorDataGridViewTextBoxColumn.Name = "iDDoctorDataGridViewTextBoxColumn";
            this.iDDoctorDataGridViewTextBoxColumn.Width = 125;
            // 
            // fERSTNAMEDataGridViewTextBoxColumn
            // 
            this.fERSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FERSTNAME";
            this.fERSTNAMEDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.fERSTNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fERSTNAMEDataGridViewTextBoxColumn.Name = "fERSTNAMEDataGridViewTextBoxColumn";
            this.fERSTNAMEDataGridViewTextBoxColumn.Width = 125;
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
            this.bIRTHDAYDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.bIRTHDAYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bIRTHDAYDataGridViewTextBoxColumn.Name = "bIRTHDAYDataGridViewTextBoxColumn";
            this.bIRTHDAYDataGridViewTextBoxColumn.Width = 125;
            // 
            // POSITION
            // 
            this.POSITION.DataPropertyName = "POSITION";
            this.POSITION.HeaderText = "Должность";
            this.POSITION.MinimumWidth = 6;
            this.POSITION.Name = "POSITION";
            this.POSITION.Width = 125;
            // 
            // kABINETDataGridViewTextBoxColumn
            // 
            this.kABINETDataGridViewTextBoxColumn.DataPropertyName = "KABINET";
            this.kABINETDataGridViewTextBoxColumn.HeaderText = "Кабинет";
            this.kABINETDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kABINETDataGridViewTextBoxColumn.Name = "kABINETDataGridViewTextBoxColumn";
            this.kABINETDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Список врачей";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mIS_DIPDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mIS_DIPDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MIS_DIPDataSet1 mIS_DIPDataSet1;
        private System.Windows.Forms.BindingSource dOCTORBindingSource;
        private MIS_DIPDataSet1TableAdapters.DOCTORTableAdapter dOCTORTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private MIS_DIPDataSet4 mIS_DIPDataSet4;
        private System.Windows.Forms.BindingSource dOCTORBindingSource1;
        private MIS_DIPDataSet4TableAdapters.DOCTORTableAdapter dOCTORTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDoctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fERSTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lASTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATRONYMICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIRTHDAYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn POSITION;
        private System.Windows.Forms.DataGridViewTextBoxColumn kABINETDataGridViewTextBoxColumn;
    }
}