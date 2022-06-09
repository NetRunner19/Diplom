using System;
using System.Data;
using System.Windows.Forms;

namespace ITMedik
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mIS_DIPDataSet.PATIENTDIRECTORORY". При необходимости она может быть перемещена или удалена.
            this.pATIENTDIRECTORORYTableAdapter.Fill(this.mIS_DIPDataSet.PATIENTDIRECTORORY);
            button3.Enabled = false;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            Form3 form3 = new Form3();
            this.Close();
            form3.ShowDialog();

      /*      DataRow NewRow = mIS_DIPDataSet.Tables[0].NewRow();
            NewRow[0] = Guid.NewGuid();
            NewRow[1] = form3.textBox1.Text;
            mIS_DIPDataSet.Tables[0].Rows.Add(NewRow);
            mIS_DIPDataSet.Tables[0].AcceptChanges();*/

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            Form3 form3 = new Form3();
            form2.Hide();
            form3.textBox1.Text = (String)mIS_DIPDataSet.Tables[0].Rows[dataGridView1.CurrentRow.Index][1];
            form3.textBox2.Text = (String)mIS_DIPDataSet.Tables[0].Rows[dataGridView1.CurrentRow.Index][1];
            form3.textBox3.Text = (String)mIS_DIPDataSet.Tables[0].Rows[dataGridView1.CurrentRow.Index][1];
            form3.comboBox1.Text = (String)mIS_DIPDataSet.Tables[0].Rows[dataGridView1.CurrentRow.Index][1];
            form3.maskedTextBox1.Text = (String)mIS_DIPDataSet.Tables[0].Rows[dataGridView1.CurrentRow.Index][1];
            //form3.dateTimePicker2.Text = (string)mIS_DIPDataSet.Tables[0].Rows[dataGridView1.CurrentRow.Index][1];
            form3.comboBox2.Text = (String)mIS_DIPDataSet.Tables[0].Rows[dataGridView1.CurrentRow.Index][1];
            form3.maskedTextBox2.Text = (String)mIS_DIPDataSet.Tables[0].Rows[dataGridView1.CurrentRow.Index][1];
            form3.maskedTextBox3.Text = (String)mIS_DIPDataSet.Tables[0].Rows[dataGridView1.CurrentRow.Index][1];
            //form3.dateTimePicker1.Text = (String)mIS_DIPDataSet.Tables[0].Rows[dataGridView1.CurrentRow.Index][1];
            form3.comboBox3.Text = (String)mIS_DIPDataSet.Tables[0].Rows[dataGridView1.CurrentRow.Index][1];
            form3.textBox7.Text = (String)mIS_DIPDataSet.Tables[0].Rows[dataGridView1.CurrentRow.Index][1];
            form3.textBox8.Text = (String)mIS_DIPDataSet.Tables[0].Rows[dataGridView1.CurrentRow.Index][1];
            form3.textBox9.Text = (String)mIS_DIPDataSet.Tables[0].Rows[dataGridView1.CurrentRow.Index][1];
            form3.textBox10.Text = (String)mIS_DIPDataSet.Tables[0].Rows[dataGridView1.CurrentRow.Index][1];
            form3.textBox11.Text = (String)mIS_DIPDataSet.Tables[0].Rows[dataGridView1.CurrentRow.Index][1];
            form3.textBox12.Text = (String)mIS_DIPDataSet.Tables[0].Rows[dataGridView1.CurrentRow.Index][1];
            form3.comboBox1.Text = (String)mIS_DIPDataSet.Tables[0].Rows[dataGridView1.CurrentRow.Index][1];
            form3.ShowDialog();

            mIS_DIPDataSet.Tables[0].Rows[dataGridView1.CurrentRow.Index][1] = form3.textBox1.Text;
            mIS_DIPDataSet.Tables[0].AcceptChanges();

        }

        public void button3_Click(object sender, EventArgs e)
        {
            /*if (MessageBox.Show($"Вы точно хотите удалить эту запись? ",$"Внимание",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Information,
       MessageBoxDefaultButton.Button1,
       MessageBoxOptions.DefaultDesktopOnly);
            )*/
            
            // строка удаления
            mIS_DIPDataSet.Tables[0].Rows[dataGridView1.CurrentRow.Index].Delete();
                this.pATIENTDIRECTORORYTableAdapter.Update(mIS_DIPDataSet);
         


            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                button3.Enabled = checkBox1.Checked;
            }
            else
            {
                button3.Enabled = false;
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 0)
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

        private void button1_Click_1(object sender, EventArgs e)
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
