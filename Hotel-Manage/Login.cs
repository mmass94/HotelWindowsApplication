using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
namespace Hotel_Manage
{
    public partial class Login : Form
    {

        Form1 f1 = new Form1();
        public Login()
        {
            InitializeComponent();
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                textBox1.Focus();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                textBox2.Focus();
        }

       

            
    private void button1_KeyPress(object sender, KeyPressEventArgs e)
    {
        }

        private void button1_KeyPress(object sender, EventArgs e)
        {
            


            


            }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please Enter your UserName.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
                try
                {

                    HotelmanageDataSetTableAdapters.UsersTableAdapter user = new HotelmanageDataSetTableAdapters.UsersTableAdapter();

                    HotelmanageDataSet.UsersDataTable dt = user.GetDataBy1(textBox1.Text, textBox2.Text);



                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show(" you have been successfly loggedd in", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    f1.Show();
                    }
                    else
                    {
                        MessageBox.Show("your username or Password  is incorrect.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        }
    }
    



