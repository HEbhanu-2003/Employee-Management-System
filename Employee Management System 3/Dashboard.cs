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

namespace Employee_Management_System_3
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {
            Display();
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void Display()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ABKRPIF;Initial Catalog=Employee;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Employee", con);
            Int32 Count = Convert.ToInt32(cmd.ExecuteScalar());
            if (Count > 0)
            {
                label3.Text = Convert.ToString(Count.ToString());
            }
            else
            {
                label3.Text = "0";
            }

            con.Close();
        }

        private void BackHome_Click(object sender, EventArgs e)
        {
            Home f3 = new Home();
            f3.Show();
        }
    }
}
