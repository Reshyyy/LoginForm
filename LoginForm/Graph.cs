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
using System.Windows.Forms.DataVisualization.Charting;

namespace LoginForm
{
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();
        }

        private void Graph_Load(object sender, EventArgs e)
        {
            // Establish a connection to the database
            string connectionString = "Data Source=DESKTOP-OQ7MM4J;Initial Catalog=LoginFormTest;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // Define the SQL query
            string query = "SELECT borrowed.BorrowedCount, returned.ReturnedCount FROM (SELECT COUNT(*) AS BorrowedCount FROM BorrowBook2 WHERE return_date IS NULL) AS borrowed INNER JOIN(SELECT COUNT(*) AS ReturnedCount FROM BorrowBook2 WHERE return_date IS NOT NULL) AS returned ON 1 = 1";

            // Execute the SQL query and fill the DataTable with the results
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                // Display the results in the DataGridView
                dataGridView1.DataSource = table;

                // Configure the chart control
                chart1.Series.Clear();  // Remove any existing series from the chart
                chart1.ChartAreas[0].AxisX.Interval = -5;  // Set the interval between X-axis labels to 1
                chart1.ChartAreas[0].AxisX.LabelStyle.Angle = 0;  // Rotate the X-axis labels by -45 degrees


                // Create a new series for the borrowed and returned book count
                Series borrowedSeries = new Series();
                borrowedSeries.Name = "Borrowed";
                borrowedSeries.ChartType = SeriesChartType.Column;
                borrowedSeries.Color = Color.Blue;

                Series returnedSeries = new Series();
                returnedSeries.Name = "Returned";
                returnedSeries.Color = Color.Green;

                // Add data points to the series
                foreach (DataRow row in table.Rows)
                {
                    int borrowedCount = Convert.ToInt32(row["BorrowedCount"]);
                    borrowedSeries.Points.AddXY("Borrowed Returned", borrowedCount);

                }
                foreach (DataRow row in table.Rows)
                {
                    int returnedCount = Convert.ToInt32(row["ReturnedCount"]);
                    returnedSeries.Points.AddXY("Returned", returnedCount);
                }

                // Add the series to the chart
                chart1.Series.Add(borrowedSeries);
                chart1.Series.Add(returnedSeries);
            }
        }
    }
}
