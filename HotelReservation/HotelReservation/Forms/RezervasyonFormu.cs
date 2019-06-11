using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservation.Forms
{
    public partial class RezervasyonFormu : Form
    {
        public RezervasyonFormu()
        {
            InitializeComponent();
        }
        private static List<Kullanici> kullanicis;
        public RezervasyonFormu(List<Kullanici> kullanicilar)
        {
            kullanicis = kullanicilar;
            InitializeComponent();
        }
        //public void SetAllCity(List<Otel> input)//https://stackoverflow.com/questions/20441019/how-to-access-list-from-another-form
        //{
        //    foreach (Otel s in input)
        //    {
        //        comboBox1.Items.Add(s.sehirismi());
        //    }
        //}
        private static List<Otel> otels = new List<Otel>();
        public static List<Otel> GetOtels
        {
            get { return otels; }
        }

        public static List<Kullanici> Kullanicis { get => kullanicis; set => kullanicis = value; }

        private void RezervasyonFormu_Load(object sender, EventArgs e)
        {
            string dosya_yolu = @"./Otel.txt";//sehirleri getirmek için dosyayı okuttum
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string yazi = sw.ReadToEnd(); 
            sw.Close();
            fs.Close();
            otels = JsonConvert.DeserializeObject<List<Otel>>(yazi, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Objects
            });

            foreach (Otel otel in otels)
            {

                if (!comboBox1.Items.Contains(otel.Sehir))
                {
                    comboBox1.Items.Add(otel.Sehir);
                }
                
            }
            KullanıcıKayıtFormu.dosyaOlustur();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
