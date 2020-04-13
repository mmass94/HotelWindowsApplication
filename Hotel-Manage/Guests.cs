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
    public partial class Guests : Form
    {
        private OleDbConnection connection = new System.Data.OleDb.OleDbConnection();
        OleDbCommand command = new OleDbCommand();
        public Guests()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Guests_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelmanageDataSet1.Guests' table. You can move, or remove it, as needed.
            this.guestsTableAdapter.Fill(this.hotelmanageDataSet1.Guests);
            connection.ConnectionString = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Hotelmanage.accdb;Jet OLEDB:Database Password=mmm999";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();

            command.Connection = connection;
            command.CommandText =
                 "INSERT INTO Guests (ID, FirstName ,  MiddleName,  LastName ,  Gender , ContactNumb ,Address ,EmailAddress ) VALUES (' "
                 + this.textBox0.Text + " ',' "
                 + this.textBox1.Text + " ', '" + this.textBox3.Text + " '  ,' " + this.textBox2.Text + " ' , '" + this.comboBox1.Text + "',  '" + this.textBox4.Text + "','" + this.textBox5.Text +
               "'  ,'" + this.textBox6.Text + " ') ";
            command.ExecuteNonQuery();
            // connection.Close();

            MessageBox.Show("Geust's Data  Saved ");
            BindGridView();
            connection.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        public void BindGridView()
        {


            string strSQL = "SELECT * FROM  Guests";  //
            OleDbCommand cmd = new OleDbCommand(strSQL, connection);
            DataTable table = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(table);
            dataGridView1.DataSource = table;

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

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            command.Connection = connection;
            string query = "  delete from Guests where ID= " + textBox0.Text + "";

            MessageBox.Show(query);
            command.CommandText = query;
            command.ExecuteNonQuery();
            MessageBox.Show("Guest Exit successfly");
            BindGridView();
            connection.Close();
        }
    }
}
