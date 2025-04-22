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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();

        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-VR49SG3;Initial Catalog=UniversityLibraryManagement;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);

            try
            {
                con.Open();
                string query = "Select book_category as 'book categories' ,count(*) as 'Count' from Books group by book_category";
                SqlCommand myCommand = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(myCommand);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                
                string query1 = "select availability as 'Availability' , count(*) as 'Count' from Copied_books group by availability";
                SqlCommand myCommand1 = new SqlCommand(query1, con);
                SqlDataAdapter da1 = new SqlDataAdapter(myCommand1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView2.DataSource = dt1;

                
                string query2 = "select condition as 'Condition' , count(*) as 'Count'  from Copied_books group by condition";
                SqlCommand myCommand2 = new SqlCommand(query2, con);
                SqlDataAdapter da2 = new SqlDataAdapter(myCommand2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView3.DataSource = dt2;

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

        private void button4_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();
            Visible= false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update update  = new Update();
            update.Show();  
            Visible= false; 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Book_loaned book_Loaned = new Book_loaned();
            book_Loaned.Show();
            Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Select form_select = new Select();
            form_select.Show();
            Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
