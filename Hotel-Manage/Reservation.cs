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
    public partial class Reservation : Form
    {

        private OleDbConnection connection = new System.Data.OleDb.OleDbConnection();
             OleDbCommand command = new OleDbCommand();

        public Reservation()
        {
            InitializeComponent();

           
    }

        private void Reservation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelmanageDataSet3.Reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter1.Fill(this.hotelmanageDataSet3.Reservation);
            // TODO: This line of code loads data into the 'hotelmanageDataSet2.Reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter.Fill(this.hotelmanageDataSet2.Reservation);
            connection.ConnectionString = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Hotelmanage.accdb;Jet OLEDB:Database Password=mmm999";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                command.Connection = connection;
                command.CommandText =
                     "INSERT INTO Reservation (ID, GuestFullName ,  DateBirth,  RoomNumb ,  RoomType , CheckInDate ,CheckOutDate ,NoOfAdults,NoOfChild,AdvancePayment,TotalBalance ) VALUES (' "
                     + this.textBox0.Text + " ',' "
                     + this.textBox1.Text + " ', '" + this.dbp.Text + " '  ,' " + this.textBox2.Text + " ' , '" + this.comboBox1.Text + "',  '" + this.dateTimePicker1.Text + "','" + this.dateTimePicker2.Text +
                   "'  ,'" + this.textBox5.Text + " ','" + this.textBox6.Text + " ',' " + this.textBox3.Text + " ',' " + this.textBox4.Text + " ') ";
                command.ExecuteNonQuery();

                MessageBox.Show("Reservation Done");
                connection.Close();
                BindGridView();
               

            }
            catch (OleDbException ex)
            {

                if (ex.Message.Contains("primary"))
                {
                    MessageBox.Show("ID Key is Unique Enter differnet ID please");
                    connection.Close();
                }

            }
        }

        public void BindGridView()
        {
            connection.Open();

            string strSQL = "SELECT * FROM Reservation";  //
            OleDbCommand cmd = new OleDbCommand(strSQL, connection);
            DataTable table = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult inexit;
            inexit = MessageBox.Show("Confirm if you want to exit", "Hotel Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (inexit == DialogResult.Yes)
            {

                this.Close();
            }
        }
    }
}
