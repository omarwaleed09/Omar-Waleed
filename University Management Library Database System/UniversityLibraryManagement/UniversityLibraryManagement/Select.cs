using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityLibraryManagement
{
    public partial class Select : Form
    {
        public Select()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Add add_form = new Add();
            add_form.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student_select f = new Student_select();
            f.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_select admi = new Admin_select();
            admi.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Books_select book = new Books_select();
            book.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BookPublisher_select bk = new BookPublisher_select();
            bk.Show();
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

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
            Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Book_loaned book_Loaned = new Book_loaned();
            book_Loaned.Show();
            Visible = false;
        }
    }
}
