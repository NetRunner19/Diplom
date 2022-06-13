using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ITMedik
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=NETRUNNER;Initial Catalog=MIS_DIP;Integrated Security=True");
            string InsertQuey = "Insert into DOCTOR(FERSTNAME,LASTNAME,PATRONYMIC,BIRTHDAY,KABINET,POSITION)Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Value.ToString() + "','" + textBox5.Text + "' ,'" + comboBox1.Text + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(InsertQuey, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Данные врача внесены в базу");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mIS_DIPDataSet2.DOLZHNOST". При необходимости она может быть перемещена или удалена.
            this.dOLZHNOSTTableAdapter.Fill(this.mIS_DIPDataSet2.DOLZHNOST);

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
