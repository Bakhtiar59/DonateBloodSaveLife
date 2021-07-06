using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DonateBloodSaveLife
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DonorDetails dl = new DonorDetails();
            dl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Blood bl = new Blood();
            bl.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin ad = new Admin();
            ad.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
