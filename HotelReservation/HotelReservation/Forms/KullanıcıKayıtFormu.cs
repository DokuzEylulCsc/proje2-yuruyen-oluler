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
       List<Kullanici> GetKullanici { get; } = new List<Kullanici>();
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            GetKullanici.Add(new Kullanici(textBox5.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text));
            string[] a = { textBox5.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text };
            var satir = new ListViewItem(a);
            listView1.Items.Add(satir);
            KullanıcıGiriş kullanici = new KullanıcıGiriş();
            
            KullanıcıGiriş kullanıcıGiriş = new KullanıcıGiriş();
            kullanıcıGiriş.Show(); this.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminGiriş adminGiriş = new AdminGiriş();
            adminGiriş.Show(); this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
