using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace TEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connString = @"Data Source=192.168.77.196;Initial Catalog=T803;User ID=zaurmahmudov;Password=Z@urM@mud0v;TrustServerCertificate=True";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //sql connection object
                using (SqlConnection conn = new SqlConnection(connString))
                {

                    //retrieve the SQL Server instance version
                    string query = @"SELECT CONTACTNUM,DISPLAY,CCUSTNAME,BJOBTITLE,BPHONE,BMOBILE,EMAIL FROM IASADRBOOKCONTACT WHERE DISPLAY LIKE N'%" + textBox1.Text + "%';";

                    //define the SqlCommand object
                    SqlCommand cmd = new SqlCommand(query, conn);
                    //cmd.Parameters.AddWithValue("@DisplayName", Int32.Parse(textBox1.Text));


                    //Set the SqlDataAdapter object
                    SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                    //define dataset
                    DataSet ds = new DataSet();

                    //fill dataset with query results
                    dAdapter.Fill(ds);

                    //set DataGridView control to read-only
                    dataGridView1.ReadOnly = true;

                    //set the DataGridView control's data source/data table
                    dataGridView1.DataSource = ds.Tables[0];


                    //close connection
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string connetionString;
            //Microsoft.Data.SqlClient.SqlConnection cnn;
            //connetionString = @"Data Source=192.168.77.196;Initial Catalog=T803;User ID=zaurmahmudov;Password=Z@urM@mud0v;TrustServerCertificate=True";
            //cnn = new SqlConnection(connetionString);
            //cnn.Open();
            //MessageBox.Show("Connection Open  !");
            //cnn.Close();


            //set the connection string
            //string connString = @"Data Source=192.168.77.196;Initial Catalog=T803;User ID=zaurmahmudov;Password=Z@urM@mud0v;TrustServerCertificate=True";


            try
            {
                //sql connection object
                using (SqlConnection conn = new SqlConnection(connString))
                {

                    //retrieve the SQL Server instance version
                    string query = @"SELECT CONTACTNUM,DISPLAY,CCUSTNAME,BJOBTITLE,BPHONE,BMOBILE,EMAIL FROM IASADRBOOKCONTACT WHERE DISPLAY LIKE N'%" + textBox1.Text + "%';";

                    //define the SqlCommand object
                    SqlCommand cmd = new SqlCommand(query, conn);
                    //cmd.Parameters.AddWithValue("@DisplayName", Int32.Parse(textBox1.Text));


                    //Set the SqlDataAdapter object
                    SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                    //define dataset
                    DataSet ds = new DataSet();

                    //fill dataset with query results
                    dAdapter.Fill(ds);

                    //set DataGridView control to read-only
                    dataGridView1.ReadOnly = true;

                    //set the DataGridView control's data source/data table
                    dataGridView1.DataSource = ds.Tables[0];


                    //close connection
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //sql connection object
            using (SqlConnection conn = new SqlConnection(connString))
            {

                //retrieve the SQL Server instance version
                string query = @"
            SELECT DATENAME(year, GETDATE())  AS year
    , DATENAME(month, GETDATE())  AS month
    , DATENAME(day, GETDATE())  AS day
    , DATENAME(dayofyear, GETDATE())  AS dayofyear
    , DATENAME(weekday, GETDATE()) AS weekday
    , DATENAME(hour, GETDATE()) AS hour
    , DATENAME(MINUTE, GETDATE()) AS minute;";

                //define the SqlCommand object
                SqlCommand cmd = new SqlCommand(query, conn);


                //Set the SqlDataAdapter object
                SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                //define dataset
                DataSet ds = new DataSet();

                //fill dataset with query results
                dAdapter.Fill(ds);

                //set DataGridView control to read-only
                dataGridView1.ReadOnly = true;

                //set the DataGridView control's data source/data table
                dataGridView1.DataSource = ds.Tables[0];


                //close connection
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //sql connection object
            using (SqlConnection conn = new SqlConnection(connString))
            {

                //retrieve the SQL Server instance version
                string query = @"SELECT dateDIFF(DAY,GETDATE(),'20240930') AS GUN_QALIB";

                //define the SqlCommand object
                SqlCommand cmd = new SqlCommand(query, conn);


                //Set the SqlDataAdapter object
                SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                //define dataset
                DataSet ds = new DataSet();

                //fill dataset with query results
                dAdapter.Fill(ds);

                //set DataGridView control to read-only
                dataGridView1.ReadOnly = true;

                //set the DataGridView control's data source/data table
                dataGridView1.DataSource = ds.Tables[0];


                //close connection
                conn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //sql connection object
            using (SqlConnection conn = new SqlConnection(connString))
            {
                //retrieve the SQL Server instance version
                string query = @"SELECT dateDIFF(DAY,'20240311',GETDATE()) AS GUNDUR_ISLEYIREM";

                //define the SqlCommand object
                SqlCommand cmd = new SqlCommand(query, conn);


                //Set the SqlDataAdapter object
                SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                //define dataset
                DataSet ds = new DataSet();

                //fill dataset with query results
                dAdapter.Fill(ds);

                //set DataGridView control to read-only
                dataGridView1.ReadOnly = true;

                //set the DataGridView control's data source/data table
                dataGridView1.DataSource = ds.Tables[0];


                //close connection
                conn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
