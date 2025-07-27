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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Employee f3 = new Employee();
            f3.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Dashboard f3 = new Dashboard();
            f3.Show();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
