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
        private void RezervasyonFormu_Load(object sender, EventArgs e)
        {

            string dosya_yolu = @"./Otel.txt";
            //Okuma işlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosyanın açılacağını,
            //3.parametre dosyaya erişimin veri okumak için olacağını gösterir.
            StreamReader sw = new StreamReader(fs);
            //Okuma işlemi için bir StreamReader nesnesi oluşturduk.
            string yazi = sw.ReadToEnd();
            //Son satır okunduktan sonra okuma işlemini bitirdik
            sw.Close();
            fs.Close();
            otels = JsonConvert.DeserializeObject<List<Otel>>(yazi, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Objects
            });
            foreach (Otel otel in otels)
            {
                    comboBox1.Items.Add(otel.Sehir);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
