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
    public partial class BookPublisher_select : Form
    {
        public BookPublisher_select()
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
                string query = "Select * from book_publisher  Where publisher_id = @PID";
                SqlCommand myCommand = new SqlCommand(query, con);
                myCommand.Parameters.AddWithValue("@PID", int.Parse(textBox1.Text.ToString()));
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

        private void button1_Click(object sender, EventArgs e)
        {
            Select form_select = new Select();
            form_select.Show();
            Visible = false;
        }
    }
}
