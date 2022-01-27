using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace project3
{
    public partial class Form4 : Form
    {
        String connectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Person.mdb;";
        OleDbConnection conn;

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Checking if all the blanks are filled. If yes, delete case from the database.

            if (String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrWhiteSpace(textBox2.Text) || String.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please fill all the blanks!");
            }
            else
            {
                try
                {
                    conn.Open();
                    String query1 = "DELETE FROM Person WHERE FullName=@name AND Phone=@phone AND Email=@email";
                    OleDbCommand command = new OleDbCommand(query1, conn);

                    command.Parameters.AddWithValue("@name", textBox1.Text);
                    command.Parameters.AddWithValue("@phone", textBox3.Text);
                    command.Parameters.AddWithValue("@email", textBox2.Text);

                    int i = command.ExecuteNonQuery();

                    if (i == 1)
                    {
                        MessageBox.Show("Case deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Case not found!");
                    }
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

        private void Form4_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(connectionString);
        }
    }
}
