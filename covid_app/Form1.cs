using System;
using System.Windows.Forms;

namespace project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Logging in after filling all the blanks.

            if (String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrWhiteSpace(textBox2.Text) || String.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please fill all the blanks!");
            }
            else
            {
                Form2 form2 = new Form2(textBox1.Text, textBox2.Text);
                form2.Show();
            } 
        }
    }
}
