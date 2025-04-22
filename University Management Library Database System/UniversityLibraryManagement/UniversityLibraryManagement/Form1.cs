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
using System.Data.Sql;


namespace UniversityLibraryManagement
{
    public partial class Add : Form
    {


        public Add()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VR49SG3;Initial Catalog=UniversityLibraryManagement;Integrated Security=True");
            try
            {
                con.Open();
                string query = "Insert into Student (Name,Age,Email,PhoneNumber) values(@name,@age,@mail,@phone)";
                SqlCommand myCommand = new SqlCommand(query, con);
                myCommand.Parameters.AddWithValue("@name", textBox1.Text.ToString());
                myCommand.Parameters.AddWithValue("@age", textBox2.Text.ToString());
                myCommand.Parameters.AddWithValue("@mail", textBox3.Text.ToString());
                myCommand.Parameters.AddWithValue("@phone", textBox4.Text.ToString());
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Added Successfully :)");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            catch
            {
                MessageBox.Show("Wrong inputs");
            }
            finally
            {
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VR49SG3;Initial Catalog=UniversityLibraryManagement;Integrated Security=True");
            try
            {
                con.Open();
                string query = "Insert into Admins (Name,Phone_Number) values(@name,@phone)";
                SqlCommand myCommand = new SqlCommand(query, con);
                myCommand.Parameters.AddWithValue("@name", textBox6.Text.ToString());
                myCommand.Parameters.AddWithValue("@phone", textBox5.Text.ToString());
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Added Successfully :)");
                Refresh();
                textBox5.Clear();
                textBox6.Clear();
                
            }
            catch
            {
                MessageBox.Show("Wrong inputs");
            }
            finally
            {
                con.Close();
            }
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Update form_update = new Update();
            form_update.Show();
            Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.Show();
            Visible = false;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Update form_update = new Update();
            form_update.Show();
            Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Select form_select = new Select();
            form_select.Show();
            Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Book_loaned book_Loaned = new Book_loaned();    
            book_Loaned.Show();
            Visible=false; 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
            Visible = false;
        }
    }


    public partial class MainPage : Form
    {

    }
    public partial class MainForm : Form
    {

    }

}

