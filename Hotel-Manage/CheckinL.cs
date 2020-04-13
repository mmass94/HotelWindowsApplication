using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Manage
{
    public partial class CheckinL : Form
    {
        public CheckinL()
        {
            InitializeComponent();
        }

        private void CheckinL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelmanageDataSet.Hoteldb' table. You can move, or remove it, as needed.
            this.hoteldbTableAdapter.Fill(this.hotelmanageDataSet.Hoteldb);

        }
    }
}
