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
    public partial class Checkinfrm : Form
    {
        private OleDbConnection connection = new System.Data.OleDb.OleDbConnection();
        OleDbCommand command = new OleDbCommand();


        public Checkinfrm()
        {

            InitializeComponent();
             
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Checkinfrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelmanageDataSet.Hoteldb' table. You can move, or remove it, as needed.
            this.hoteldbTableAdapter.Fill(this.hotelmanageDataSet.Hoteldb);

            connection.ConnectionString = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Hotelmanage.accdb;Jet OLEDB:Database Password=mmm999";

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


        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                connection.Open();

                command.Connection = connection;
                command.CommandText =
                     "INSERT INTO Hoteldb (ID, GuestFullName ,  DateBirth,  RoomNumb ,  RoomType , CheckInDate ,CheckOutDate ,NoOfAdults,NoOfChild,AdvancePayment,TotalBalance ) VALUES (' "
                     + this.textBox0.Text + " ',' "
                     + this.textBox1.Text + " ', '" + this.dbp.Text + " '  ,' " + this.textBox2.Text + " ' , '" + this.comboBox1.Text + "',  '" + this.dateTimePicker1.Text + "','" + this.dateTimePicker2.Text +
                   "'  ,'" + this.textBox5.Text + " ','" + this.textBox6.Text + " ',' " + this.textBox3.Text + " ',' " + this.textBox4.Text + " ') ";
                command.ExecuteNonQuery();
                

                MessageBox.Show("Geust Check-in");
                connection.Close();
                BindGridView();
            } catch (OleDbException ex)
            {

                if (ex.Message.Contains("primary"))
                { MessageBox.Show("ID Key is Unique Enter differnet ID please");
                    connection.Close();
                }
                 }
            
         

            


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        public void BindGridView()
        {
            
            
                connection.Open();
                string strSQL = "SELECT * FROM Hoteldb";  //
                OleDbCommand cmd = new OleDbCommand(strSQL, connection);
                DataTable table = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(table);
                dataGridView1.DataSource = table;
                connection.Close();
            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            command.Connection = connection;
            string query = "  update Hoteldb set GuestFullName='" + textBox1.Text +
                 "',DateBirth='" + dbp.Text +
                "',RoomNumb='" + textBox2.Text + "',RoomType='" + comboBox1.Text +
                "',CheckInDate='" + dateTimePicker1.Text +
                "',CheckOutDate='" + dateTimePicker2.Text + "',NoOfAdults='" + textBox5.Text + "',NoOfChild='" +
                textBox6.Text + "',AdvancePayment='" + textBox3.Text + "', TotalBalance='"+textBox4.Text+"' where ID=" + textBox0.Text+"";
            MessageBox.Show(query);
            command.CommandText = query;
            command.ExecuteNonQuery();
            MessageBox.Show("Recored Upadted succefly");
            connection.Close();
            BindGridView();
            
            
        }

       
    }


    }



