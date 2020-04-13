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
    public partial class ReservedL : Form
    {
        public ReservedL()
        {
            InitializeComponent();
        }

        private void ReservedL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelmanageDataSet.Reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter.Fill(this.hotelmanageDataSet.Reservation);

        }
    }
}
