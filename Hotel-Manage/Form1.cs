using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Hotel_Manage
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
        }
        private OleDbConnection connection = new System.Data.OleDb.OleDbConnection();
        private void button1_Click(object sender, EventArgs e)
        {
            Checkinfrm chf = new Checkinfrm();
            chf.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult mexit;
            mexit = MessageBox.Show("Confirm if you want to exit", "Hotel Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mexit == DialogResult.Yes)
            {

                Application.Exit();
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckOut cho = new CheckOut();
            cho.ShowDialog();
          
            
            
          

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Guests gs = new Guests();
            gs.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reservation rs = new Reservation();
            rs.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {
            Checkinfrm chf = new Checkinfrm();
              chf.ShowDialog();
        }

        private void rectangleShape2_Click(object sender, EventArgs e)
        {
            CheckOut cho = new CheckOut();
        
            cho.ShowDialog();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Checkinfrm chf = new Checkinfrm();
            chf.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Checkinfrm chf = new Checkinfrm();
            chf.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            CheckOut cho = new CheckOut();
            cho.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CheckOut cho = new CheckOut();
            cho.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Reservation rs = new Reservation();
            rs.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Reservation rs = new Reservation();
            rs.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Guests gs = new Guests();
            gs.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Guests gs = new Guests();
            gs.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            DialogResult mexit;
            mexit = MessageBox.Show("Confirm if you want to exit", "Hotel Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mexit == DialogResult.Yes)
            {

                Application.Exit();
                
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DialogResult mexit;
            mexit = MessageBox.Show("Confirm if you want to exit", "Hotel Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mexit == DialogResult.Yes)
            {

                Application.Exit();
                
            }
        }

        private void rectangleShape3_Click(object sender, EventArgs e)
        {
            Reservation rs = new Reservation();
            rs.ShowDialog();
        }

        private void rectangleShape4_Click(object sender, EventArgs e)
        {
            Guests gs = new Guests();
            gs.ShowDialog();
        }

        private void rectangleShape5_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lgn = new Login();
            lgn.Show();
        }

        private void rectangleShape6_Click(object sender, EventArgs e)
        {
            DialogResult mexit;
            mexit = MessageBox.Show("Confirm if you want to exit", "Hotel Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mexit == DialogResult.Yes)
            {

                Application.Exit();

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lgn = new Login();
            lgn.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lgn = new Login();
            lgn.Show();
        }

        private void newCheckinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Checkinfrm chf = new Checkinfrm();
            chf.ShowDialog();
        }

        private void newReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservation rs = new Reservation();
            rs.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult mexit;
            mexit = MessageBox.Show("Confirm if you want to exit", "Hotel Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mexit == DialogResult.Yes)
            {

                Application.Exit();

            }
        }

        private void checkInListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckinL cl = new CheckinL();
            cl.Show();
        }

        private void reservedListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservedL rl = new ReservedL();
            rl.Show();
        }

        private void guestsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuestL gl = new GuestL();
            gl.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Guests g = new Guests();
            g.Show();
        }
    }
}
