using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                
        }

        private void Logi_Click(object sender, EventArgs e)
        {
            string pass, username;
            pass = txtPassword.Text;
            username = txtUsername.Text;

            if (username == "hasindu" && pass == "123")
            {
                MessageBox.Show("Sucessfully Logged In!");
                Home obj = new Home();

                obj.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
