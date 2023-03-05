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

namespace LoginForm
{
    public partial class Borrower : Form
    {
        public Borrower()
        {
            InitializeComponent();
        }

        private void Borrower_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UOSHB5L;Initial Catalog=LoginFormTest;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("select title from books", con);
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                for(int i = 0; i < sdr.FieldCount; i++)
                {
                    cmbBooks.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
            con.Close();
        }

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            String st_name = txtStudentName.Text;
            String st_id = txtIDNumber.Text;
            String st_dep = txtDepartment.Text;
            String st_contact = txtContactNumber.Text;
            String st_email = txtEmail.Text;


        }

        private void btnCreateBorrowerAccount_Click(object sender, EventArgs e)
        {
            AddBorrower addBorrower = new AddBorrower();
            addBorrower.ShowDialog();
        }

        private void btnViewBorrowers_Click(object sender, EventArgs e)
        {
            ViewBorrower viewBorrower = new ViewBorrower();
            viewBorrower.ShowDialog();
        }
    }
}
