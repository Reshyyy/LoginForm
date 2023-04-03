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
using System.Drawing.Printing;
using System.Reflection.Metadata;
using System.Xml.Linq;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using Document = iTextSharp.text.Document;

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
            con.ConnectionString = "Data Source=DESKTOP-OQ7MM4J;Initial Catalog=LoginFormTest;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from BorrowBook2 where return_date is null";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dg_reports1.DataSource = ds.Tables[0];



            cmd.CommandText = "select * from BorrowBook2 where return_date is not null";
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            dg_reports2.DataSource = ds1.Tables[0];

        }


        private void btnFilter_Click(object sender, EventArgs e)
        {
            ///*
            if (dateTimePicker1.Value <= dateTimePicker2.Value)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-OQ7MM4J;Initial Catalog=LoginFormTest;Integrated Security=True";
                SqlDataAdapter sdf = new SqlDataAdapter("select * from BorrowBook2 where borrow_date between '" + dateTimePicker1.Value + "' and '" + dateTimePicker2.Value + "' ", con);
                DataTable sd = new DataTable();
                sdf.Fill(sd);
                dg_reports1.DataSource = sd;

            }
            else
            {
                MessageBox.Show("From Date must be lesser than To Date", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dg_reports1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void exportGridToPDF(DataGridView dgw, string filename)
        {
            try
            {
                BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
                PdfPTable pdftable = new PdfPTable(dgw.Columns.Count);
                pdftable.DefaultCell.Padding = 3;
                pdftable.WidthPercentage = 100;
                pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
                pdftable.DefaultCell.BorderWidth = 1;

                iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
                //Add header
                foreach (DataGridViewColumn column in dgw.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    pdftable.AddCell(cell);

                }

                foreach (DataGridViewRow row in dgw.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                    }
                }
                var savefiledialog = new SaveFileDialog();
                savefiledialog.FileName = filename;
                savefiledialog.DefaultExt = ".pdf";
                if (savefiledialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(savefiledialog.FileName, FileMode.Create))
                    {
                        Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                        PdfWriter.GetInstance(pdfdoc, stream);
                        pdfdoc.Open();
                        //header
                        Paragraph para = new Paragraph("REPORTS\n\n", FontFactory.GetFont("verdana", 15, iTextSharp.text.Font.BOLD));
                        para.Alignment = Element.ALIGN_CENTER;
                        pdfdoc.Add(para);
                        pdfdoc.Add(pdftable);
                        pdfdoc.Close();
                        stream.Close();
                    }
                    MessageBox.Show("Data Export Successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while exporting Data" + ex.Message);
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            exportGridToPDF(dg_reports2, "test");
        }

        private void btnShowGraph_Click(object sender, EventArgs e)
        {
            Graph showgraph = new Graph();
            showgraph.ShowDialog();
        }
    }
}

