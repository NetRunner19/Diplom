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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mIS_DIPDataSet5.JOURNAL". При необходимости она может быть перемещена или удалена.
            this.jOURNALTableAdapter.Fill(this.mIS_DIPDataSet5.JOURNAL);

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

        private void button_Poisk_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            Form10 form10 = new Form10();
            form10.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mIS_DIPDataSet5.Tables[0].Rows[dataGridView1.CurrentRow.Index].Delete();
            this.jOURNALTableAdapter.Update(mIS_DIPDataSet5);
        }
    }
}
