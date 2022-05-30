using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMedik
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mIS_DIPDataSet1.DOCTOR". При необходимости она может быть перемещена или удалена.
            this.dOCTORTableAdapter.Fill(this.mIS_DIPDataSet1.DOCTOR);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            Form5 form5 = new Form5();
            form4.Hide();
            form5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form4 form4 = new Form4();
            Form5 form5 = new Form5();
            form4.Hide();
            form5.textBox1.Text = (String)mIS_DIPDataSet1.Tables[0].Rows[dataGridView1.CurrentRow.Index][1];
            form5.textBox2.Text = (String)mIS_DIPDataSet1.Tables[0].Rows[dataGridView1.CurrentRow.Index][1];
            form5.textBox3.Text = (String)mIS_DIPDataSet1.Tables[0].Rows[dataGridView1.CurrentRow.Index][1];
           form5.comboBox1.Text = (String)mIS_DIPDataSet1.Tables[0].Rows[dataGridView1.CurrentRow.Index][1];
            
            form5.ShowDialog();

            mIS_DIPDataSet1.Tables[0].Rows[dataGridView1.CurrentRow.Index][1] = form4.textBox1.Text;
            mIS_DIPDataSet1.Tables[0].AcceptChanges();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"FERSTNAME LIKE '%{textBox1.Text}%'";
        }
    }
}
