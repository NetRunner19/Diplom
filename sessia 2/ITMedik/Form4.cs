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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mIS_DIPDataSet4.DOCTOR". При необходимости она может быть перемещена или удалена.
            this.dOCTORTableAdapter1.Fill(this.mIS_DIPDataSet4.DOCTOR);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();
            form5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mIS_DIPDataSet4.Tables[0].Rows[dataGridView1.CurrentRow.Index].Delete();
            this.dOCTORTableAdapter1.Update(mIS_DIPDataSet4);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            Form5 form5 = new Form5();
            form4.Hide();
            form5.textBox1.Text = (String)mIS_DIPDataSet4.Tables[0].Rows[dataGridView1.CurrentRow.Index][1];
            form5.textBox2.Text = (String)mIS_DIPDataSet4.Tables[0].Rows[dataGridView1.CurrentRow.Index][2];
            form5.textBox3.Text = (String)mIS_DIPDataSet4.Tables[0].Rows[dataGridView1.CurrentRow.Index][3];
            form5.textBox5.Text = (String)mIS_DIPDataSet4.Tables[0].Rows[dataGridView1.CurrentRow.Index][5];
            form5.comboBox1.Text = (String)mIS_DIPDataSet4.Tables[0].Rows[dataGridView1.CurrentRow.Index][6];

            form5.ShowDialog();

            mIS_DIPDataSet1.Tables[0].Rows[dataGridView1.CurrentRow.Index][1] = form4.textBox1.Text;
            mIS_DIPDataSet1.Tables[0].AcceptChanges();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    dataGridView1.CurrentCell = null;
                    dataGridView1.Rows[i].Visible = false;

                    for (int c = 0; c < dataGridView1.Columns.Count; c++)
                    {
                        if (dataGridView1[c, i].Value.ToString() == textBox1.Text)
                        {
                            dataGridView1.Rows[i].Visible = true;
                            break;
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.CurrentCell = null;
                dataGridView1.Rows[i].Visible = false;

                for (int c = 0; c < dataGridView1.Columns.Count; c++)
                {
                    if (dataGridView1[c, i].Value.ToString() == textBox1.Text)
                    {
                        dataGridView1.Rows[i].Visible = true;
                        break;
                    }
                }
            }
        }
    }
}
