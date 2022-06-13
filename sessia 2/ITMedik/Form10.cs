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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Savebatton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=NETRUNNER;Initial Catalog=MIS_DIP;Integrated Security=True");
            string InsertQuey = "Insert into JOURNAL(DATA,Talon,ID_patient,ID_Doktor,ID_Diagnoz,Anamez_zabolevania,Anamez_zhizni,Zhaloby,Lecheniye)Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Value.ToString() + "','" + textBox5.Text + "' ,'" + comboBox1.Text + "','" + comboBox1.Text + "','" + comboBox1.Text + "','" + comboBox1.Text + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(InsertQuey, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Данные врача внесены в базу");
        }
    }
}
