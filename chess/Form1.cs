using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace project2
{
    public partial class Form1 : Form
    {
        // My global variables.

        Point point;
        bool enable;
        int minutes1 = 9;
        int minutes2 = 9;
        int seconds1 = 60;
        int seconds2 = 60;
        int totalSeconds1, totalSeconds2;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(String Player_1, String Player_2, String timeStamp)
        {
            InitializeComponent();
            label9.Text = Player_1;
            label7.Text = Player_2;
            label5.Text = timeStamp;
        }

        List<PictureBox> pictureBoxes = new List<PictureBox>();

        // Initializing all the pieces.

        private void Form1_Load(object sender, EventArgs e)
        {
            Piece p1 = new Piece("Pawn", "Images/w_pawn.png");
            Piece p2 = new Piece("Pawn", "Images/w_pawn.png");
            Piece p3 = new Piece("Pawn", "Images/w_pawn.png");
            Piece p4 = new Piece("Pawn", "Images/w_pawn.png");
            Piece p5 = new Piece("Pawn", "Images/w_pawn.png");
            Piece p6 = new Piece("Pawn", "Images/w_pawn.png");
            Piece p7 = new Piece("Pawn", "Images/w_pawn.png");
            Piece p8 = new Piece("Pawn", "Images/b_pawn.png");
            Piece p9 = new Piece("Pawn", "Images/b_pawn.png");
            Piece p10 = new Piece("Pawn", "Images/b_pawn.png");
            Piece p11 = new Piece("Pawn", "Images/b_pawn.png");
            Piece p12 = new Piece("Pawn", "Images/b_pawn.png");
            Piece p13 = new Piece("Pawn", "Images/b_pawn.png");
            Piece p14 = new Piece("Pawn", "Images/b_pawn.png");
            Piece p15 = new Piece("Pawn", "Images/b_pawn.png");
            Piece p16 = new Piece("Pawn", "Images/b_pawn.png");
            Piece r1 = new Piece("Rook", "Images/w_rook.png");
            Piece r2 = new Piece("Rook", "Images/w_rook.png");
            Piece r3 = new Piece("Rook", "Images/b_rook.png");
            Piece r4 = new Piece("Rook", "Images/b_rook.png");
            Piece k1 = new Piece("Knight", "Images/w_knight.png");
            Piece k2 = new Piece("Knight", "Images/w_knight.png");
            Piece k3 = new Piece("Knight", "Images/b_knight.png");
            Piece k4 = new Piece("Knight", "Images/b_knight.png");
            Piece b1 = new Piece("Bishop", "Images/w_bishop.png");
            Piece b2 = new Piece("Bishop", "Images/w_bishop.png");
            Piece b3 = new Piece("Bishop", "Images/b_bishop.png");
            Piece b4 = new Piece("Bishop", "Images/b_bishop.png");
            Piece q1 = new Piece("Queen", "Images/w_queen.png");
            Piece q2 = new Piece("Queen", "Images/b_queen.png");
            Piece K1 = new Piece("King", "Images/w_king.png");
            Piece K2 = new Piece("King", "Images/b_king.png");

            // Matching the pictureboxes with the appropriate piece objects.

            pictureBox1.ImageLocation = p1.Image;
            pictureBox2.ImageLocation = p2.Image;
            pictureBox3.ImageLocation = p3.Image;
            pictureBox4.ImageLocation = p4.Image;
            pictureBox5.ImageLocation = p5.Image;
            pictureBox30.ImageLocation = p6.Image;
            pictureBox31.ImageLocation = p7.Image;
            pictureBox32.ImageLocation = p8.Image;
            pictureBox10.ImageLocation = r1.Image;
            pictureBox17.ImageLocation = r2.Image;
            pictureBox12.ImageLocation = k1.Image;
            pictureBox15.ImageLocation = k2.Image;
            pictureBox11.ImageLocation = b1.Image;
            pictureBox16.ImageLocation = b2.Image;
            pictureBox13.ImageLocation = q1.Image;
            pictureBox14.ImageLocation = K1.Image;
            pictureBox6.ImageLocation = p8.Image;
            pictureBox7.ImageLocation = p9.Image;
            pictureBox8.ImageLocation = p10.Image;
            pictureBox9.ImageLocation = p11.Image;
            pictureBox26.ImageLocation = p12.Image;
            pictureBox27.ImageLocation = p13.Image;
            pictureBox28.ImageLocation = p14.Image;
            pictureBox29.ImageLocation = p15.Image;
            pictureBox18.ImageLocation = r3.Image;
            pictureBox25.ImageLocation = r4.Image;
            pictureBox20.ImageLocation = k3.Image;
            pictureBox23.ImageLocation = k4.Image;
            pictureBox19.ImageLocation = b3.Image;
            pictureBox24.ImageLocation = b4.Image;
            pictureBox21.ImageLocation = q2.Image;
            pictureBox22.ImageLocation = K2.Image;

            // Adding all the pieces' pictureboxes in a list.

            pictureBoxes.Add(pictureBox1);
            pictureBoxes.Add(pictureBox2);
            pictureBoxes.Add(pictureBox3);
            pictureBoxes.Add(pictureBox4);
            pictureBoxes.Add(pictureBox5);
            pictureBoxes.Add(pictureBox6);
            pictureBoxes.Add(pictureBox7);
            pictureBoxes.Add(pictureBox8);
            pictureBoxes.Add(pictureBox9);
            pictureBoxes.Add(pictureBox10);
            pictureBoxes.Add(pictureBox11);
            pictureBoxes.Add(pictureBox12);
            pictureBoxes.Add(pictureBox13);
            pictureBoxes.Add(pictureBox14);
            pictureBoxes.Add(pictureBox15);
            pictureBoxes.Add(pictureBox16);
            pictureBoxes.Add(pictureBox17);
            pictureBoxes.Add(pictureBox18);
            pictureBoxes.Add(pictureBox19);
            pictureBoxes.Add(pictureBox20);
            pictureBoxes.Add(pictureBox21);
            pictureBoxes.Add(pictureBox22);
            pictureBoxes.Add(pictureBox23);
            pictureBoxes.Add(pictureBox24);
            pictureBoxes.Add(pictureBox25);
            pictureBoxes.Add(pictureBox26);
            pictureBoxes.Add(pictureBox27);
            pictureBoxes.Add(pictureBox28);
            pictureBoxes.Add(pictureBox29);
            pictureBoxes.Add(pictureBox30);
            pictureBoxes.Add(pictureBox31);
            pictureBoxes.Add(pictureBox32);

            // Matching the mouse events (up, move, down) with my custom methods in order to make the pictureBoxes move.

            foreach (PictureBox i in pictureBoxes)
            {
                i.MouseDown += mouseDown;
                i.MouseMove += mouseMove;
                i.MouseUp += mouseUp;
            }

            totalSeconds1 = (minutes1 * 60) + seconds1;
            totalSeconds2 = (minutes2 * 60) + seconds2;

            label3.Text = "00:00";
            label4.Text = "00:00";

            button1.Enabled = false;
        }

        // Custom methods for the pictureBoxes' movement.

        private void mouseUp(object sender, MouseEventArgs e)
        {
            enable = false;
        }

        private void mouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            enable = true;
        }

        private void mouseMove(object sender, MouseEventArgs e)
        {
            PictureBox box = (PictureBox)sender;

            if (enable)
            {
                box.Left = e.X + box.Left - point.X;
                box.Top = e.Y + box.Top - point.Y;
            }
        }

        // The buttons for starting the other player's timer.

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button1.Enabled = false;

            if (timer2.Enabled)
            {
                timer2.Enabled = false;
            }
            else
            {
                timer2.Enabled = true;
                timer1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = true;

            if (timer1.Enabled)
            {
                timer1.Enabled = false;
            }
            else
            {
                timer1.Enabled = true;
                timer2.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (totalSeconds1 > 0)
            {
                totalSeconds1--;
                minutes1 = totalSeconds1 / 60;
                seconds1 = totalSeconds1 - (minutes1 * 60);
                label3.Text = minutes1.ToString() + ":" + seconds1.ToString();
            }
            else
            {
                timer1.Stop();
                button1.Enabled = false;
                button2.Enabled = true;
                MessageBox.Show("Time 's up! Player 2 has lost...");
                minutes1 = 9;
                seconds1 = 00;
                minutes2 = 9;
                seconds2 = 00;
                totalSeconds1 = (minutes1 * 60) + seconds1;
                totalSeconds2 = (minutes2 * 60) + seconds2;
                label3.Text = minutes1.ToString() + ":" + seconds1.ToString();
                label4.Text = minutes2.ToString() + ":" + seconds2.ToString();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (totalSeconds2 > 0)
            {
                totalSeconds2--;
                minutes2 = totalSeconds2 / 60;
                seconds2 = totalSeconds2 - (minutes2 * 60);
                label4.Text = minutes2.ToString() + ":" + seconds2.ToString();
            }
            else
            {
                timer2.Stop();
                button1.Enabled = true;
                button2.Enabled = false;
                MessageBox.Show("Time 's up! Player 1 has lost...");
                minutes1 = 9;
                seconds1 = 60;
                minutes2 = 9;
                seconds2 = 60;
                totalSeconds1 = (minutes1 * 60) + seconds1;
                totalSeconds2 = (minutes2 * 60) + seconds2;
                label3.Text = minutes1.ToString() + ":" + seconds1.ToString();
                label4.Text = minutes2.ToString() + ":" + seconds2.ToString();
            }
        }
    }
}
