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
    public partial class Borrow : Form
    {
        public Borrow()
        {
            InitializeComponent();
        }

        private void txtenteridno_TextChanged(object sender, EventArgs e)
        {
            if (txtenteridno.Text == "")
            {
                txtStudentName.Clear();
                txtDepartment.Clear();
                txtContactNumber.Clear();
                txtEmail.Clear();
            }
        }

        int count;
        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            if (txtenteridno.Text != "")
            {
                String eidno = txtenteridno.Text;
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UOSHB5L;Initial Catalog=LoginFormTest;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from AddBorrower where idnum = '" + eidno + "'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                //----------------------
                //Code to Count how many book has been issued on this ID Number

                cmd.CommandText = "select count(std_number) from BorrowBook where std_number = '" + eidno + "' and return_date is null";
                SqlDataAdapter DA1 = new SqlDataAdapter(cmd);
                DataSet DS1 = new DataSet();
                DA1.Fill(DS1);

                count = int.Parse(DS1.Tables[0].Rows[0][0].ToString());
                //----------------------

                if (DS.Tables[0].Rows.Count != 0)
                {
                    txtStudentName.Text = DS.Tables[0].Rows[0][1].ToString();
                    txtDepartment.Text = DS.Tables[0].Rows[0][3].ToString();
                    txtContactNumber.Text = DS.Tables[0].Rows[0][4].ToString();
                    txtEmail.Text = DS.Tables[0].Rows[0][5].ToString();
                }
                else
                {
                    txtStudentName.Clear();
                    txtDepartment.Clear();
                    txtContactNumber.Clear();
                    txtEmail.Clear();
                    MessageBox.Show("Invalid ID Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Borrow_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UOSHB5L;Initial Catalog=LoginFormTest;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("select title from books", con);
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    cmbBooks.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
            con.Close();
        }

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            if (txtStudentName.Text != "")
            {
                if (cmbBooks.SelectedIndex != -1 && count <= 2)
                {
                    String std_name = txtStudentName.Text;
                    String std_number = txtenteridno.Text;
                    String std_dept = txtDepartment.Text;
                    Int64 std_contact = Int64.Parse(txtContactNumber.Text);
                    String std_email = txtEmail.Text;
                    String book_name = cmbBooks.Text;
                    String borrow_date = dateTimePicker.Text;

                    String eidno = txtenteridno.Text;
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UOSHB5L;Initial Catalog=LoginFormTest;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "insert into BorrowBook (std_name,std_number,std_dept,std_contact,std_email,book_name,borrow_date) values ('" + std_name + "', '" + std_number + "',  '" + std_dept + "', " + std_contact + ", '" + std_email + "', '" + book_name + "', '" + borrow_date + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Book Borrowed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Select Book. OR Maximum number of Book has been borrowed.", "No Book selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter valid ID Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
