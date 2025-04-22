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

namespace UniversityLibraryManagement
{
    public partial class Book_loaned : Form
    {
        public Book_loaned()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-VR49SG3;Initial Catalog=UniversityLibraryManagement;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);

            try
            {
                con.Open();
                string query = "select b.title as 'Book Title ' , s.Name as 'Student Name' " +
                                        "from Books b, Student s , loan l " +
                                        "where s.Student_id = @SID  and  s.Student_id= l.Student_id and l.ISBN = b.ISBN";
                SqlCommand myCommand = new SqlCommand(query, con);
                myCommand.Parameters.AddWithValue("@SID", int.Parse(textBox1.Text.ToString()));

                SqlDataAdapter da = new SqlDataAdapter(myCommand);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                textBox1.Clear();
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

        private void button8_Click(object sender, EventArgs e)
        {
            Add add_form = new Add();
            add_form.Show();
            Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.Show();
            Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
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

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
            Visible = false;
        }
    }
}
