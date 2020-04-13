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
    public partial class CheckOut : Form
    {
        private OleDbConnection connection = new System.Data.OleDb.OleDbConnection();
        OleDbCommand command = new OleDbCommand();
        public CheckOut()
        {
            InitializeComponent();
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelmanageDataSet.Hoteldb' table. You can move, or remove it, as needed.
            this.hoteldbTableAdapter.Fill(this.hotelmanageDataSet.Hoteldb);
            connection.ConnectionString = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Hotelmanage.accdb;Jet OLEDB:Database Password=mmm999";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int RowsAffected = 0;

            connection.Open();
            string query = "DELETE FROM Hoteldb WHERE ID=@ID";
            command = new OleDbCommand(query);
            command.Connection = connection;

            command.Parameters.Add(new OleDbParameter("@ID", OleDbType.WChar, 150, "ID"));
            command.Parameters["@ID"].Value = textBox0.Text.Trim();
    RowsAffected = command.ExecuteNonQuery();
            if (RowsAffected > 0)
            {
                MessageBox.Show("Guest Checked Out successfly");
                BindGridView();
            }
            else
            {
                MessageBox.Show("There was nothing to be deleted");
                connection.Close();
            }
        }


        public void BindGridView()
        {


            //connection.Open();
            string strSQL = "SELECT * FROM Hoteldb";
            command = new OleDbCommand(strSQL);
            command.Connection = connection;

            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds, "Hoteldb");
            dataGridView1.DataSource = ds.Tables["Hoteldb"].DefaultView;

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
