using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace project3
{
    public partial class Form7 : Form
    {
        String connectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Person.mdb;";
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        DataTable data;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new OleDbConnection(connectionString);
                conn.Open();
                String query1 = "SELECT * FROM Person";
                adapter = new OleDbDataAdapter(query1, connectionString);
                data = new DataTable();
                adapter.Fill(data);
                dataGridView1.DataSource = data;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // The case is selected from the database according to the email that the user inputs inside the textbox.

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn = new OleDbConnection(connectionString);
                conn.Open();
                String query1 = "SELECT * FROM Person WHERE Email LIKE '" + textBox1.Text + "%'";
                adapter = new OleDbDataAdapter(query1, connectionString);
                data = new DataTable();
                adapter.Fill(data);
                dataGridView1.DataSource = data;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
