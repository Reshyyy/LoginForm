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
    public partial class Books : Form
    {
        private SqlConnection con;
        public Books()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-UOSHB5L;Initial Catalog=LoginFormTest;Integrated Security=True");
            InitializeComponent();
        }
        public void loadDatagrid()
        {
            con.Open();
            SqlCommand com = new SqlCommand("select * from books order by accession_number asc", con);
            com.ExecuteNonQuery();

            SqlDataAdapter adap = new SqlDataAdapter(com);
            DataTable tab = new DataTable();

            adap.Fill(tab);
            grid1.DataSource = tab;

            con.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string an = txtno.Text;
            string t = txttitle.Text;
            string a = txtauthor.Text;
            con.Open();
            SqlCommand com = new SqlCommand("insert into books values ('" + an + "', '" + t + "', '" + a + "')", con);
            com.ExecuteNonQuery();

            MessageBox.Show("Successfully SAVED!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();
            loadDatagrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            con.Open();
            string no;
            no = txtno.Text;

            SqlCommand com = new SqlCommand("update books set title = '" + txttitle.Text + "', author='" + txtauthor.Text + "' where accession_number = '" + no + "'", con);
            com.ExecuteNonQuery();

            MessageBox.Show("Successfuly UPDATED!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            loadDatagrid();
        }

        private void grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtno.Text = grid1.Rows[e.RowIndex].Cells["accession_number"].Value.ToString();
            txttitle.Text = grid1.Rows[e.RowIndex].Cells["title"].Value.ToString();
            txtauthor.Text = grid1.Rows[e.RowIndex].Cells["author"].Value.ToString();
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("select * from books where title like '%" + txtSearch.Text + "%'", con);
            com.ExecuteNonQuery();

            SqlDataAdapter adap = new SqlDataAdapter(com);
            DataTable tab = new DataTable();

            adap.Fill(tab);
            grid1.DataSource = tab;

            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            string num = txtno.Text;

            DialogResult dr = MessageBox.Show("Are you sure you want to delete this?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                SqlCommand com = new SqlCommand("delete from books where accession_number = '" + num + "'", con);
                com.ExecuteNonQuery();
                MessageBox.Show("Successfully DELETE!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("CANCELLED!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
            loadDatagrid();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtno.Clear();
            txttitle.Clear();
            txtauthor.Clear();
            txtSearch.Clear();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("select * from books order by accession_number asc", con);
            com.ExecuteNonQuery();

            SqlDataAdapter adap = new SqlDataAdapter(com);
            DataTable tab = new DataTable();

            adap.Fill(tab);
            grid1.DataSource = tab;

            con.Close();


        }
    }
}
