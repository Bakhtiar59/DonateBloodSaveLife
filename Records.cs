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
    public partial class Records : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\sayfi\Documents\FinalDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        public Records()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Display_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || comboBox1.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox4.Text == "" ||textBox3.Text == "" || comboBox3.Text == "")
            {
                MessageBox.Show("Please fill the required fields");
            }

            else
            {

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Table2 values ('" + textBox1.Text + "','" + comboBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox4.Text + "','" + textBox3.Text + "','" + comboBox3.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                //textBox1.Text = "";
                //comboBox1.Text = "";
                //textBox2.Text = "";
                //comboBox2.Text = "";
                //textBox3.Text = "";
                //textBox4.Text = "";
                //textBox5.Text = "";
                //textBox6.Text = "";
                disp_data();

                MessageBox.Show("Record saved successfully");


            }
        }
        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Table2 ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void Records_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please fill the required fields");
            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Table2 where name = '" + textBox1.Text + "'";
                //cmd.CommandText = "delete from BLOOD where Gender ='"+comboBox1.Text + "'";
                //cmd.CommandText = "delete from BLOOD where Weight ='" + textBox2.Text + "'";
                //cmd.CommandText = "delete from BLOOD where Blood group ='" + comboBox2.Text + "'";
                //cmd.CommandText = "delete from BLOOD where Age ='" + textBox3.Text + "'";
                //cmd.CommandText = "delete from BLOOD where Contact ='" + textBox4.Text + "'"; 
                //cmd.CommandText = "delete from BLOOD where Address ='" + textBox5.Text + "'";
                //cmd.CommandText = "delete from BLOOD where LTBD =,'" + textBox6.Text + "'";

                cmd.ExecuteNonQuery();
                con.Close();
                disp_data();

                MessageBox.Show("Record Deleted successfully");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please fill the required fields");
            }
            else
            {

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update  Table2 set name = '" + textBox2.Text + "'where name='" + textBox1.Text + "'";
                //cmd.CommandText = "update  Table2 set name = '" + comboBox1.Text + "'where name='" + textBox5.Text + "'";
                //cmd.CommandText = "update  Table2 set name = '" + comboBox1.Text + "'where name='" + textBox3.Text + "'";

                //cmd.CommandText = "update  Table2 set name = '" + textBox5.Text + "'where name='" + textBox1.Text + "'";
                //cmd.CommandText = "update  Table2 set name = '" + textBox3.Text + "'where name='" + textBox1.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                disp_data();

                MessageBox.Show("Record Update successfully");
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin k = new Admin();
            k.Show();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

       

        
    }
}
