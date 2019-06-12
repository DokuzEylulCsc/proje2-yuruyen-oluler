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
    public partial class AdminGiriş : Form
    {
        public AdminGiriş()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            if (textBox3.Text == admin.getSifre) //şifre kontrölü
            {
                OtelEkleFormu otelEkleFormu = new OtelEkleFormu();
                otelEkleFormu.Show();
                this.Hide();
            }
           
        }

        private void AdminGiriş_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            KullanıcıKayıtFormu kullanıcıKayıtFormu = new KullanıcıKayıtFormu();
            kullanıcıKayıtFormu.Show();
            this.Hide();
        }
    }
}
