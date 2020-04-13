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
    public partial class GuestL : Form
    {
        public GuestL()
        {
            InitializeComponent();
        }

        private void GuestL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelmanageDataSet.Guests' table. You can move, or remove it, as needed.
            this.guestsTableAdapter.Fill(this.hotelmanageDataSet.Guests);

        }
    }
}
