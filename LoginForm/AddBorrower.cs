using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginForm
{
    public partial class AddBorrower : Form
    {
        public AddBorrower()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String name = txtname.Text;
            String idnum = txtidnumber.Text;
            String dep = txtdepartment.Text;
            Int64 contact = Int64.Parse(txtcontact.Text);
            String email = txtemail.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-UOSHB5L;Initial Catalog=LoginFormTest;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "insert into AddBorrower (sname,idnum,dep,contact,email) values('"+name+"', '"+idnum+"', '"+dep+"', '"+contact+"', '"+email+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
