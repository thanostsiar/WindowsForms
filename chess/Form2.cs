using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace project2
{
    public partial class Form2 : Form
    {
        String connectionString = "Data Source=Matches.db;Version=3;";
        SQLiteConnection conn;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String timeStamp = DateTime.Now.ToString();

            // Making sure the players have inputed their information. If yes, insert them into the database.

            if (String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrWhiteSpace(textBox2.Text) || String.IsNullOrWhiteSpace(textBox3.Text) || String.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Please fill all the blanks!");
            }
            else
            {
                Form1 form1 = new Form1(textBox1.Text, textBox2.Text, timeStamp);
                form1.Show();

                conn.Open();

                try
                {
                    String insertQuery = "Insert into Matches(Player1, Player2, Email1, Email2, Timestamp) values(@player1, @player2, @email1, @email2, @timeStamp)";
                    SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@player1", textBox1.Text);
                    cmd.Parameters.AddWithValue("@player2", textBox2.Text);
                    cmd.Parameters.AddWithValue("@email1", textBox3.Text);
                    cmd.Parameters.AddWithValue("@email2", textBox4.Text);
                    cmd.Parameters.AddWithValue("@timeStamp", timeStamp);
                    cmd.ExecuteNonQuery();
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

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString);
        }
    }
}
