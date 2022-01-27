using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace project3
{
    public partial class Form6 : Form
    {
        String connectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Person.mdb;";
        OleDbConnection conn;
        String query1;
        OleDbCommand command;
        String name, email, phone;
        int i;

        bool[] check = { false, false, false, false, false, false, false };

        public Form6()
        {
            InitializeComponent();
        }

        public Form6(String Name, String Email, String Phone)
        {
            InitializeComponent();
            name = Name;
            email = Email;
            phone = Phone;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                // Searching inside the bool table to check which of the checkboxes are checked.

                for (int a = 0; a < 7; ++a)
                {
                    if (check[a] == true)
                    {

                        // Depending on which of the checkboxes are checked, the checkboxes' field is updated.

                        switch (a)
                        {
                            case 0:
                                {
                                    query1 = "UPDATE Person SET FullName=@name WHERE FullName=@fullname AND Email=@mail AND Phone=@number";
                                    command = new OleDbCommand(query1, conn);
                                    command.Parameters.AddWithValue("@name", textBox1.Text);
                                    command.Parameters.AddWithValue("@fullname", name);
                                    command.Parameters.AddWithValue("@mail", email);
                                    command.Parameters.AddWithValue("@number", phone);
                                    i = command.ExecuteNonQuery();
                                    name = textBox1.Text;
                                    break;
                                }
                            case 1:
                                {
                                    query1 = "UPDATE Person SET Email=@email WHERE FullName=@fullname AND Email=@mail AND Phone=@number";
                                    command = new OleDbCommand(query1, conn);
                                    command.Parameters.AddWithValue("@email", textBox2.Text);
                                    command.Parameters.AddWithValue("@fullname", name);
                                    command.Parameters.AddWithValue("@mail", email);
                                    command.Parameters.AddWithValue("@number", phone);
                                    i = command.ExecuteNonQuery();
                                    email = textBox2.Text;
                                    break;
                                }
                            case 2:
                                {
                                    query1 = "UPDATE Person SET Phone=@phone WHERE FullName=@fullname AND Email=@mail AND Phone=@number";
                                    command = new OleDbCommand(query1, conn);
                                    command.Parameters.AddWithValue("@phone", textBox3.Text);
                                    command.Parameters.AddWithValue("@fullname", name);
                                    command.Parameters.AddWithValue("@mail", email);
                                    command.Parameters.AddWithValue("@number", phone);
                                    i = command.ExecuteNonQuery();
                                    phone = textBox3.Text;
                                    break;
                                }
                            case 3:
                                {
                                    query1 = "UPDATE Person SET Sex=@sex WHERE FullName=@fullname AND Email=@mail AND Phone=@number";
                                    command = new OleDbCommand(query1, conn);
                                    command.Parameters.AddWithValue("@sex", comboBox1.Text);
                                    command.Parameters.AddWithValue("@fullname", name);
                                    command.Parameters.AddWithValue("@mail", email);
                                    command.Parameters.AddWithValue("@number", phone);
                                    i = command.ExecuteNonQuery();
                                    break;
                                }
                            case 4:
                                {
                                    query1 = "UPDATE Person SET Age=@age WHERE FullName=@fullname AND Email=@mail AND Phone=@number";
                                    command = new OleDbCommand(query1, conn);
                                    command.Parameters.AddWithValue("@age", comboBox2.Text);
                                    command.Parameters.AddWithValue("@fullname", name);
                                    command.Parameters.AddWithValue("@mail", email);
                                    command.Parameters.AddWithValue("@number", phone);
                                    i = command.ExecuteNonQuery();
                                    break;
                                }
                            case 5:
                                {
                                    query1 = "UPDATE Person SET PreExistingDiseases=@illness WHERE FullName=@fullname AND Email=@mail AND Phone=@number";
                                    command = new OleDbCommand(query1, conn);
                                    command.Parameters.AddWithValue("@illness", textBox4.Text);
                                    command.Parameters.AddWithValue("@fullname", name);
                                    command.Parameters.AddWithValue("@mail", email);
                                    command.Parameters.AddWithValue("@number", phone);
                                    i = command.ExecuteNonQuery();
                                    break;
                                }
                            case 6:
                                {
                                    query1 = "UPDATE Person SET Address=@address WHERE FullName=@fullname AND Email=@mail AND Phone=@number";
                                    command = new OleDbCommand(query1, conn);
                                    command.Parameters.AddWithValue("@address", textBox5.Text);
                                    command.Parameters.AddWithValue("@fullname", name);
                                    command.Parameters.AddWithValue("@mail", email);
                                    command.Parameters.AddWithValue("@number", phone);
                                    i = command.ExecuteNonQuery();
                                    break;
                                }
                        }
                    }
                }

                if (i == 1)
                {
                    MessageBox.Show("Case edited successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to edit case...");
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

        private void Form6_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(connectionString);
        }

        // Name

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox1.Enabled = true;
                check[0] = true;                       
            }
            else
            {
                textBox1.Enabled = false;
                check[0] = false;
            }
        }

        // Age

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboBox2.Enabled = true;
                check[4] = true;                    
            }
            else
            {
                comboBox2.Enabled = false;
                check[4] = false;
            }
        }

        // Illness

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                textBox4.Enabled = true;
                check[5] = true;                
            }
            else
            {
                textBox4.Enabled = false;
                check[5] = false;
            }
        }

        // Email

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox2.Enabled = true;
                check[1] = true;                    
            }
            else
            {
                textBox2.Enabled = false;
                check[1] = false;
            }
        }

        // Phone

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                textBox3.Enabled = true;
                check[2] = true;                
            }
            else
            {
                textBox3.Enabled = false;
                check[2] = false;
            }
        }

        // Address

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                textBox5.Enabled = true;
                check[6] = true;                
            }
            else
            {
                textBox5.Enabled = false;
                check[6] = false;
            }
        }

        // Sex

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                comboBox1.Enabled = true;
                check[3] = true;                
            }
            else
            {
                comboBox1.Enabled = false;
                check[3] = false;
            }
        }
    }
}
