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

namespace UniversityLibraryManagement
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-VR49SG3;Initial Catalog=UniversityLibraryManagement;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);

            try
            {
                con.Open();
                string query = "UPDATE Books SET title = @Title WHERE ISBN = @ISBN";
                SqlCommand myCommand = new SqlCommand(query, con);
                myCommand.Parameters.AddWithValue("@Title", textBox1.Text.ToString());
                myCommand.Parameters.AddWithValue("@ISBN", int.Parse(textBox5.Text.ToString()));
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully :)");
                textBox1.Clear();
                textBox5.Clear();
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

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-VR49SG3;Initial Catalog=UniversityLibraryManagement;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);

            try
            {
                con.Open();
                string query = "UPDATE Loan SET status = @Status WHERE ISBN = @ISBN and Student_id = @SID";
                SqlCommand myCommand = new SqlCommand(query, con);
                myCommand.Parameters.AddWithValue("@Status", textBox2.Text.ToString());
                myCommand.Parameters.AddWithValue("@SID", int.Parse(textBox4.Text.ToString()));
                myCommand.Parameters.AddWithValue("@ISBN", int.Parse(textBox3.Text.ToString()));
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully :)");
                textBox2.Clear();
                textBox4.Clear();
                textBox3.Clear();

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
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Add add_form = new Add();
            add_form.Show();
            Visible = false;
        }


        private void button8_Click(object sender, EventArgs e)
        {
            Add add_form = new Add();
            add_form.Show();
            Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Book_loaned book_Loaned = new Book_loaned();
            book_Loaned.Show(); 
            Visible = false;    
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.Show();
            Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Select form_select = new Select();
            form_select.Show();
            Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
            Visible = false;
        }
    }
}
