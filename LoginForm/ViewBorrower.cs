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
    public partial class ViewBorrower : Form
    {
        public ViewBorrower()
        {
            InitializeComponent();
        }

        private void txtsearchid_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-UOSHB5L;Initial Catalog=LoginFormTest;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from AddBorrower where idnum LIKE '"+txtsearchid.Text+"%' ";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            gridviewborrower.DataSource = DS.Tables[0];
        }

        private void ViewBorrower_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-UOSHB5L;Initial Catalog=LoginFormTest;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from AddBorrower";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            gridviewborrower.DataSource = DS.Tables[0];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String sname = txtname.Text;
            String idnum = txtidnumber.Text;
            String dep = txtdepartment.Text;
            Int64 contact = Int64.Parse(txtcontact.Text);
            String email = txtemail.Text;

            if(MessageBox.Show("Data will be Updated. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-UOSHB5L;Initial Catalog=LoginFormTest;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update AddBorrower set sname = '" + sname + "', idnum = '" + idnum + "', dep = '" + dep + "', contact = '" + contact + "', email = '" + email + "' where stuid = " + rowid + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                ViewBorrower_Load(this, null);
            }

        }

        int bid;
        Int64 rowid;
        private void gridviewborrower_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridviewborrower.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(gridviewborrower.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-UOSHB5L;Initial Catalog=LoginFormTest;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from AddBorrower where stuid = "+bid+"";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            rowid = Int64.Parse(DS.Tables[0].Rows[0][0].ToString());

            txtname.Text = DS.Tables[0].Rows[0][1].ToString();
            txtidnumber.Text = DS.Tables[0].Rows[0][2].ToString();
            txtdepartment.Text = DS.Tables[0].Rows[0][3].ToString();
            txtcontact.Text = DS.Tables[0].Rows[0][4].ToString();
            txtemail.Text = DS.Tables[0].Rows[0][5].ToString();
        }

        private void btnclearb_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtidnumber.Clear();
            txtdepartment.Clear();
            txtcontact.Clear();
            txtemail.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtsearchid.Clear();
        }
    }
}
