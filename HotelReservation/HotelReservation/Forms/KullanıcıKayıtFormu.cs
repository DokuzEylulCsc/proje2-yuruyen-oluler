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
using System.Collections;

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
            dosyaOlustur();
            KullanıcıGiriş kullanıcıGiriş = new KullanıcıGiriş(Kullanici.GetKullanici);
            kullanıcıGiriş.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminGiriş adminGiriş = new AdminGiriş();
            adminGiriş.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KullanıcıGiriş kullanıcıGiriş = new KullanıcıGiriş();
            kullanıcıGiriş.Show();
            this.Hide();
        }

        
        public static void dosyaOlustur() 
        {
            FileStream fileStream = new FileStream(@"./Kullanici.txt", FileMode.Create);
            StreamWriter sW = new StreamWriter(fileStream);

            string json = JsonConvert.SerializeObject(Kullanici.GetKullanici, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Objects,
                TypeNameAssemblyFormat = System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple
            });
            sW.Write(json);
            sW.Flush();
            sW.Close();
            fileStream.Close();
        }
        private void KullanıcıKayıtFormu_Load(object sender, EventArgs e)
        {
           
            string dosya_yolu = @"./Kullanici.txt";

            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string yazi = sw.ReadToEnd();
            sw.Close();
            fs.Close();
            Kullanici.GetKullanici = JsonConvert.DeserializeObject<List<Kullanici>>(yazi, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Objects
            });
            /*
            Kullanici.GetKullanici.AddRange(new List<Kullanici>
            {
                new Kullanici(1,"simge","simge","simgeakosman@gmail.com",54585),
                new Kullanici(2,"ayşe","1234","ayse@gmail.com",111),
                new Kullanici(3,"mehmet","asdasdf","mehmet@gmail.com",8522),
                new Kullanici(4,"caner","cnr1994","caner@gmail.com",76587),
                new Kullanici(5,"cengiz","cngz12","cengiz@gmail.com",7888),
                new Kullanici(6,"zekiye","74566","zekiye@gmail.com",9552),
                new Kullanici(7,"kader","7585","kader@gmail.com",8725),
                new Kullanici(8,"devrim","devrim","devrim@gmail.com",4154),
                new Kullanici(9,"ahu","ahu","ahu@gmail.com",9654),
                new Kullanici(10,"berat","berat","berat@gmail.com",4444),
                
            });
            dosyaOlustur();
            */

        }
    }
}
