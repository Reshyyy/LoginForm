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
    public partial class MenuForm : Form
    {
        private SqlConnection con;
        public MenuForm()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-UOSHB5L;Initial Catalog=LoginFormTest;Integrated Security=True");
            InitializeComponent();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.ShowDialog();
        }

        private void borrowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrower borrower = new Borrower();
            borrower.ShowDialog();
        }


        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.Yes)
            {
                this.Close();
                LoginForm lf = new LoginForm();
                lf.ShowDialog();
            }
            else
            {
                this.Show();
            }
        }


        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.ShowDialog();
        }

        private void btnBorrower_Click(object sender, EventArgs e)
        {
            Borrower borrower = new Borrower();
            borrower.ShowDialog();
        }

        private void btnBorrowed_Click(object sender, EventArgs e)
        {
            Borrow borrow = new Borrow();
            borrow.ShowDialog();
        }

        private void btnReturned_Click(object sender, EventArgs e)
        {
            Return returnShow = new Return();
            returnShow.ShowDialog();
        }

        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrow borrow = new Borrow();
            borrow.ShowDialog();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Return returnShow = new Return();
            returnShow.ShowDialog();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports rpt = new Reports();
            rpt.ShowDialog();
        }
    }
}
