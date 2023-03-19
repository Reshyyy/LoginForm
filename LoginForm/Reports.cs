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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-UOSHB5L;Initial Catalog=LoginFormTest;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from BorrowBook1 where return_date is null";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dg_reports1.DataSource = ds.Tables[0];

            
            
            cmd.CommandText = "select * from BorrowBook1 where return_date is not null";
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            dg_reports2.DataSource = ds1.Tables[0];
            
        }


        private void btnFilter_Click(object sender, EventArgs e)
        {
            ///*
            if(dateTimePicker1.Value <= dateTimePicker2.Value)
            { 
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-UOSHB5L;Initial Catalog=LoginFormTest;Integrated Security=True";
                SqlDataAdapter sdf = new SqlDataAdapter("select * from BorrowBook1 where borrow_date between '" + dateTimePicker1.Value + "' and '" + dateTimePicker2.Value + "' ", con);
                DataTable sd = new DataTable();
                sdf.Fill(sd);
                dg_reports1.DataSource = sd;

                /*
                SqlConnection con2 = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-UOSHB5L;Initial Catalog=LoginFormTest;Integrated Security=True";
                SqlDataAdapter sdf1 = new SqlDataAdapter("select * from BorrowBook1 where return_date between '" + dateTimePicker1.Value + "' and '" + dateTimePicker2.Value + "' ", con);
                DataTable sd1 = new DataTable();
                sdf1.Fill(sd1);
                dg_reports2.DataSource = sd;
                */
            }
            else
            {
                MessageBox.Show("From Date must be lesser than To Date", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            ///
            
            /*
            DateTime fromdate = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime todate = Convert.ToDateTime(dateTimePicker2.Text);
            if (fromdate <= todate)
            {
                TimeSpan ts = todate.Subtract(fromdate);
                int days = Convert.ToInt16(ts.Days);
                MessageBox.Show("Date Filtered. A specific range of " + days + " days displayed.", "Date Filter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-UOSHB5L;Initial Catalog=LoginFormTest;Integrated Security=True";
                string sqlquery = "select * from BorrowBook1 where borrow_date between '" + dateTimePicker1.Value + "' and '" + dateTimePicker2.Value + "' ";
                SqlCommand sqlcomm = new SqlCommand(sqlquery, con);
                con.Open();
                DataTable dt = new DataTable();
                dt.Load(sqlcomm.ExecuteReader());
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("From Date must be lesser than To Date", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            } 
            */

        }
    }
}

