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
    public partial class KullanıcıKayıtFormu : Form
    {
        public KullanıcıKayıtFormu()
        {
            InitializeComponent();
        }
        Kullanici Kullanici = new Kullanici();


        private void button1_Click(object sender, EventArgs e)
        {
            
            Kullanici.GetKullanici.Add(new Kullanici(Int32.Parse(textBox1.Text), textBox2.Text, textBox3.Text,textBox4.Text, Int32.Parse(textBox5.Text))); 
            KullanıcıGiriş kullanıcıGiriş = new KullanıcıGiriş();
            kullanıcıGiriş.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminGiriş adminGiriş = new AdminGiriş();
            adminGiriş.Show();
            this.Hide();
        }

    }
}
