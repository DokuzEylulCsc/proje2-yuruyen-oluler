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
    public partial class KullanıcıGiriş : Form
    {
        public KullanıcıGiriş()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Kullanici k in Kullanici.GetKullaniciList)
            {
                
                if (textBox2.Text==k.getadi && textBox3.Text == k.GetSifre)
                {
                    RezervasyonFormu rezervasyonFormu = new RezervasyonFormu();
                    rezervasyonFormu.Show(); this.Hide();

                }
               
            }
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KullanıcıKayıtFormu kullanıcıKayıtFormu = new KullanıcıKayıtFormu();
            kullanıcıKayıtFormu.Show(); this.Hide();
        }
    }
}
