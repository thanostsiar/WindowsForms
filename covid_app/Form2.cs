using System;
using System.Windows.Forms;

namespace project3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(String ID, String Name)
        {
            InitializeComponent();
            usernameToolStripMenuItem.Text = ID;
            iDToolStripMenuItem.Text = Name;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O Εθνικός Οργανισμός Δημόσιας Υγείας (ΕΟΔΥ) είναι Νομικό Πρόσωπο Ιδιωτικού Δικαίου (ΝΠΙΔ), " +
                "που ιδρύθηκε με το Ν. 4633/2019 και υπάγεται στην εποπτεία του Υπουργού Υγείας. " +
                "Ο ΕΟΔΥ είναι καθολικός διάδοχος του προϋφιστάμενου Κέντρου Ελέγχου και Πρόληψης Νοσημάτων, " +
                "το οποίο καταργήθηκε από τον Ν.4600/9.3.2019 .");
        }
    }
}
