using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace project3
{
    public partial class Form5 : Form
    {
        String connectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Person.mdb;";
        OleDbConnection conn;

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Checking if all the blanks are filled. If yes, select a person from the database.

            if (String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrWhiteSpace(textBox2.Text) || String.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please fill all the blanks!");
            }
            else
            {
                try
                {
                    conn.Open();
                    String query1 = "SELECT FullName, Email, Phone FROM Person WHERE FullName=@name AND Email=@email AND Phone=@phone";
                    OleDbCommand command = new OleDbCommand(query1, conn);

                    command.Parameters.AddWithValue("@name", textBox1.Text);
                    command.Parameters.AddWithValue("@email", textBox2.Text);
                    command.Parameters.AddWithValue("@phone", textBox3.Text);

                    OleDbDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        MessageBox.Show("Case found successfully!");
                        Form6 form6 = new Form6(textBox1.Text, textBox2.Text, textBox3.Text);
                        form6.Show();
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
    }
}
