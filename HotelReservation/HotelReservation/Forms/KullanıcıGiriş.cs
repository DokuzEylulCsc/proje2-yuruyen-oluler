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
        private static List<Kullanici> kullanicis;

        public static List<Kullanici> Kullanicis { get => kullanicis; set => kullanicis = value; }

        public KullanıcıGiriş(List<Kullanici> kullanicilar)
        {
            Kullanicis = kullanicilar;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Kullanici k in Kullanici.GetKullanici)
            {
                
                if (textBox2.Text==k.Adi&& textBox3.Text == k.Sifre)
                {
                    RezervasyonFormu rezervasyonFormu = new RezervasyonFormu(Kullanici.GetKullanici);
                    rezervasyonFormu.Show(); this.Hide();

                }
               
            }
           
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            KullanıcıKayıtFormu kullanıcıKayıtFormu = new KullanıcıKayıtFormu();
            kullanıcıKayıtFormu.Show(); this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void KullanıcıGiriş_Load(object sender, EventArgs e)
        {

        }
    }
}
