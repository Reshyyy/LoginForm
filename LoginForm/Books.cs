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
            SqlCommand com = new SqlCommand("select * from tbl_books1 order by accession_number asc", con);
            com.ExecuteNonQuery();

            SqlDataAdapter adap = new SqlDataAdapter(com);
            DataTable tab = new DataTable();

            adap.Fill(tab);
            grid1.DataSource = tab;

            con.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtno.Text != "" && txttitle.Text != "" && txtauthor.Text != "")
            {
                string an = txtno.Text;
                string t = txttitle.Text;
                string a = txtauthor.Text;
                Int64 price = Int64.Parse(txtprice.Text);
                Int64 qty = Int64.Parse(txtqty.Text);
                string p_date = datepurchased.Text;
                con.Open();
                SqlCommand com = new SqlCommand("insert into tbl_books1(accession_number,book_title,book_author,book_price,book_quantity,book_purchase_date) values ('" + an + "', '" + t + "', '" + a + "', "+price+" ," + qty + ", '" + p_date + "')", con);
                com.ExecuteNonQuery();

                MessageBox.Show("Successfully SAVED!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtno.Clear();
                txttitle.Clear();
                txtauthor.Clear();
                txtprice.Clear();
                txtqty.Clear();


                con.Close();
                loadDatagrid();
            }
            else
            {
                MessageBox.Show("Empty field. Please fill the fields.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Data will be Updated. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                con.Open();
                string no;
                no = txtno.Text;

                SqlCommand com = new SqlCommand("update tbl_books1 set book_title = '" + txttitle.Text + "', book_author='" + txtauthor.Text + "', book_price = "+txtprice.Text+", book_quantity = "+txtqty.Text+", book_purchase_date = '"+datepurchased.Text+"' where accession_number = '" + no + "'", con);
                com.ExecuteNonQuery();

                MessageBox.Show("Successfuly UPDATED!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //clear fields
                txtno.Clear();
                txttitle.Clear();
                txtauthor.Clear();
                txtprice.Clear();
                txtqty.Clear();
                con.Close();
                loadDatagrid();
            }
            
        }



        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("select * from tbl_books1 where book_title like '%" + txtSearch.Text + "%'", con);
            com.ExecuteNonQuery();

            SqlDataAdapter adap = new SqlDataAdapter(com);
            DataTable tab = new DataTable();

            adap.Fill(tab);
            grid1.DataSource = tab;

            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Deleted. Confirm?", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                con.Open();
                string num = txtno.Text;

                DialogResult dr = MessageBox.Show("Are you sure you want to delete this?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    SqlCommand com = new SqlCommand("delete from tbl_books1 where accession_number = '" + num + "'", con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Successfully DELETE!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //clear fields
                    txtno.Clear();
                    txttitle.Clear();
                    txtauthor.Clear();
                    txtprice.Clear();
                    txtqty.Clear();
                }
                else
                {
                    MessageBox.Show("CANCELLED!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
                loadDatagrid();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtno.Clear();
            txttitle.Clear();
            txtauthor.Clear();
            txtSearch.Clear();
            txtprice.Clear();
            txtqty.Clear();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("select * from tbl_books1 order by accession_number asc", con);
            com.ExecuteNonQuery();

            SqlDataAdapter adap = new SqlDataAdapter(com);
            DataTable tab = new DataTable();

            adap.Fill(tab);
            grid1.DataSource = tab;

            con.Close();


        }

        private void grid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtno.Text = grid1.Rows[e.RowIndex].Cells["accession_number"].Value.ToString();
            txttitle.Text = grid1.Rows[e.RowIndex].Cells["book_title"].Value.ToString();
            txtauthor.Text = grid1.Rows[e.RowIndex].Cells["book_author"].Value.ToString();
            txtprice.Text = grid1.Rows[e.RowIndex].Cells["book_price"].Value.ToString();
            txtqty.Text = grid1.Rows[e.RowIndex].Cells["book_quantity"].Value.ToString();
            datepurchased.Text = grid1.Rows[e.RowIndex].Cells["book_purchase_date"].Value.ToString();
        }
    }
}
