using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System_Simple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard da = new Dashboard("Guest");
            da.Show();
            this.Hide();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "" ||  txtPassword.Text == null)
            {
                guna2MessageDialog2.Show("Please Enter Username");
                txtUsername.Focus();
                return;
            }else if(txtPassword.Text == "" || txtPassword.Text == null)
            {
                guna2MessageDialog2.Show("Please Enter Password");
                txtPassword.Focus();
                return;
            }

            if(txtUsername.Text=="admin"&& txtPassword.Text == "123")
            {
                Dashboard da = new Dashboard("Admin");
                da.Show();
                this.Hide();
            }
            else
            {
                guna2MessageDialog1.Show("Incorrect Username or Password !");
            }
        }
    }
}
