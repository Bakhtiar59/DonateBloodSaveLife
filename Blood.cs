using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DonateBloodSaveLife
{
    public partial class Blood : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\sayfi\Documents\FinalDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

        public Blood()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Please fill the required field");
            }
            else
            {

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "select * from Table2 where Address ='" + textBox5.Text + "'";
                cmd.CommandText = "select * from Table2 where BloodGroup ='" + comboBox2.Text + "'";
              
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                MessageBox.Show("Donor found");

                //disp_data();

                con.Close();
            }
        }
        private void Blood_Load(object sender, EventArgs e)
        {

        }

        //public void disp_data()
        //{
            //con.Open();
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select * from Table2 ";
            //cmd.ExecuteNonQuery();
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;

            //con.Close();
        //}

        //private void Blood_Load(object sender, EventArgs e)
        //{
            //disp_data();
        //}
    }
}
