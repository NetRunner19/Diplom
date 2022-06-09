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
using System.Text.RegularExpressions;

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
            string InsertQuey = "Insert into PATIENTDIRECTORORY(FRESTNAME,LASTNAME,PATRONYMIC,BIRTHDAY,Snils,POL,PASSPORT,SERIALID,NUMBERID,Data_vydachi,PHAKTADRESS,ADRESS,PHONE,PRIMECHANIE,Grazhdanstvo,Vydan)Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker2.Value.ToString() + "','" + maskedTextBox1.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + maskedTextBox2.Text + "','" + maskedTextBox3.Text + "','" + dateTimePicker1.Value.ToString() + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox12.Text + "','" + comboBox3.Text + "','" + dateTimePicker1.Value.ToString() + "')";

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
                textBox3.Text = "";
            }
            else
            {
                textBox3.Enabled = true;
            }
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox10.Enabled = false;
                textBox11.Enabled = false;
                textBox10.Text = "";
                textBox11.Text = "";
            }
            else
            {
                textBox10.Enabled = true;
                textBox11.Enabled = true;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Close();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string doc = Convert.ToString(comboBox2.SelectedItem);
            if (doc == "Паспорт РФ")
            {
                maskedTextBox2.Enabled = true;
                maskedTextBox3.Enabled = true;
                textBox7.Enabled = true;
                comboBox3.Enabled = true;
                dateTimePicker1.Enabled = true;
                dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
            }
            else
            {
                maskedTextBox2.Enabled = false;
                maskedTextBox3.Enabled = false;
                textBox7.Enabled = false;
                comboBox3.Enabled = false;

                maskedTextBox2.Clear();
                maskedTextBox3.Clear();
                textBox7.Clear();

                dateTimePicker1.Enabled = false;
                comboBox3.SelectedIndex = -1;
                dateTimePicker1.CustomFormat = " ";
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
            }
        }
    }
}
