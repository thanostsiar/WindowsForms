using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace project3
{
    public partial class Form3 : Form
    {
        String connectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Person.mdb;";
        OleDbConnection conn;

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String timeStamp = DateTime.Now.ToString();

            // Initializing the new case.

            Person p1 = new Person(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text, comboBox2.Text, textBox4.Text, textBox5.Text, timeStamp);

            // Checking if all the blankls are filled. If yes, insert the case into the database.

            if (String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrWhiteSpace(textBox2.Text) || String.IsNullOrWhiteSpace(textBox3.Text) || String.IsNullOrWhiteSpace(textBox4.Text) || String.IsNullOrWhiteSpace(textBox5.Text) || String.IsNullOrWhiteSpace(comboBox1.Text) || String.IsNullOrWhiteSpace(comboBox2.Text))
            {
                MessageBox.Show("Please fill all the blanks!");
            }
            else
            {
                try
                {
                    conn.Open();
                    String query1 = "INSERT INTO Person(FullName, Email, Phone, Sex, Age, PreExistingDiseases, Address, [Timestamp]) VALUES (@name, @email, @phone, @sex, @age, @illness, @address, @date)";
                    OleDbCommand command = new OleDbCommand(query1, conn); 
                    command.Parameters.AddWithValue("@name", OleDbType.VarChar).Value = p1.Fullname;
                    command.Parameters.AddWithValue("@email", OleDbType.VarChar).Value = p1.Email;
                    command.Parameters.AddWithValue("@phone", OleDbType.Integer).Value = p1.Phone;
                    command.Parameters.AddWithValue("@sex", OleDbType.VarChar).Value = p1.Sex;
                    command.Parameters.AddWithValue("@age", OleDbType.Integer).Value = p1.Age;
                    command.Parameters.AddWithValue("@illness", OleDbType.VarChar).Value = p1.PreExisting_Diseases;
                    command.Parameters.AddWithValue("@address", OleDbType.VarChar).Value = p1.Address;
                    command.Parameters.AddWithValue("@date", OleDbType.VarChar).Value = p1.Timestamp;

                    int i = command.ExecuteNonQuery();

                    if (i == 1)
                    {
                        MessageBox.Show("Case added successfully!");
                    }
                }
                catch(Exception x)
                {
                    MessageBox.Show(x.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(connectionString); 
        }
    }
}
