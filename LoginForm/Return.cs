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
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-UOSHB5L;Initial Catalog=LoginFormTest;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from BorrowBook1 where std_number = '"+txtenteridno.Text+"' and return_date IS NULL";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if(ds.Tables[0].Rows.Count != 0)
            {
                gridReturn.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid ID or No Book Borrowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-UOSHB5L;Initial Catalog=LoginFormTest;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "update BorrowBook1 set return_date = '"+dtreturndate.Value+"' where std_number = '"+txtenteridno.Text+"' and id = "+rowid+" ";
            cmd.ExecuteNonQuery();

            //increase inventory
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = con;
            cmd1.CommandText = "update tbl_books1 set book_quantity = book_quantity + 1 where book_title='"+txtBookName.Text+"'";
            cmd1.ExecuteNonQuery();
            con.Close();


            MessageBox.Show("Returned Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Return_Load(this, null);

            txtenteridno.Clear();
            txtBookName.Clear();
            txtBorrowedDate.Clear();

        }

        String bname;
        String bdate;
        Int64 rowid;
        private void gridReturn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(gridReturn.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int64.Parse(gridReturn.Rows[e.RowIndex].Cells[0].Value.ToString());
                bname = gridReturn.Rows[e.RowIndex].Cells[6].Value.ToString();
                bdate = gridReturn.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            txtBookName.Text = bname;
            txtBorrowedDate.Text = bdate;
        }

        private void Return_Load(object sender, EventArgs e)
        {

        }
    }
}
