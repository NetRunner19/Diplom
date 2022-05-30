using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMedik
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=NETRUNNER;Initial Catalog=MIS_DIP;Integrated Security=True");
            string InsertQuey = "Insert into PATIENTDIRECTORORY(FRESTNAME,LASTNAME,PATRONYMIC,BIRTHDAY,Snils,POL,PASSPORT,SERIALID,NUMBERID,Data_vydachi,PHAKTADRESS,ADRESS,PHONE,PRIMECHANIE,Grazhdanstvo,Vydan)Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker2.Value.ToString() + "','" + textBox4.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + dateTimePicker1.Value.ToString() + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox12.Text + "','" + comboBox3.Text + "','" + dateTimePicker1.Value.ToString() + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(InsertQuey, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Карта пациента внесена в базу");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox3.Enabled = false;
            }
            else
            {
                textBox3.Enabled = true;
            }
            textBox3.Text = "";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox10.Enabled = false;
                textBox11.Enabled = false;
            }
            else
            {
                textBox10.Enabled = true;
                textBox11.Enabled = true;
            }
            textBox10.Text = "";
            textBox11.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
