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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Employee_Management_System_3
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-ABKRPIF;Initial Catalog=Employee;Integrated Security=True ");
                con.Open();
                SqlCommand command = new SqlCommand("insert into Employee values ('" + int.Parse(textBox1.Text) + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "' )", con);
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully Added.");
                con.Close();
                BindData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        void BindData()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-ABKRPIF;Initial Catalog=Employee;Integrated Security=True");
                SqlCommand command = new SqlCommand("select * from Employee", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Updatebutton_Click(object sender, EventArgs e)
        {
            try 
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-ABKRPIF;Initial Catalog=Employee;Integrated Security=True");
                con.Open();
                SqlCommand command = new SqlCommand("update Employee set EmployeeName = '" + textBox2.Text + "',Gender = '" + comboBox1.Text + "',ContactNumber = '" + textBox3.Text + "',Salary = '" + textBox4.Text + "' where EmployeeId='" + int.Parse(textBox1.Text) + "'", con);
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Updated.");
                BindData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-ABKRPIF;Initial Catalog=Employee;Integrated Security=True");
                SqlCommand command = new SqlCommand("select * from Employee", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        { 
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-ABKRPIF;Initial Catalog=Employee;Integrated Security=True");
                con.Open();
                SqlCommand command = new SqlCommand("Delete Employee where EmployeeId='" + int.Parse(textBox1.Text) + "'", con);
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Deleted.");
                BindData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-ABKRPIF;Initial Catalog=Employee;Integrated Security=True");
                SqlCommand command = new SqlCommand("select * from Employee where EmployeeId='" + int.Parse(textBox1.Text) + "' ", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SCalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                SCalculate.Text = "0";
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    SCalculate.Text = Convert.ToString(double.Parse(SCalculate.Text) + double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home f3 = new Home();
            f3.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
