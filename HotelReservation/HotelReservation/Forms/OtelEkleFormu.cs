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
    public partial class OtelEkleFormu : Form
    {
        public OtelEkleFormu()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.OtelEkle();
            
        }
    }
}
