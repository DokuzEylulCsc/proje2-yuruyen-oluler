using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservation.Forms
{
    public partial class AdminPaneli : Form
    {
        AdminPaneli frm = new AdminPaneli();
        public AdminPaneli()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm.Show();
            frm.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OtelEkleFormu form = new OtelEkleFormu();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OdaEkleFormu odaEkleFormu = new OdaEkleFormu();
            odaEkleFormu.Show();
            this.Hide();
        }
    }
}
