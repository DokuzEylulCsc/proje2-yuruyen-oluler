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
    public partial class OtelEkleFormu : Form
    {
        public OtelEkleFormu()
        {
            InitializeComponent();
        }
      
        private static List<Otel> otels = new List<Otel>();
        public static List<Otel> GetOtels
        {
            get { return otels; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                otels.Add(new ButikOtel(int.Parse(textBox4.Text), textBox1.Text, textBox2.Text, textBox3.Text, checkedListBox1.GetItemCheckState(0) == CheckState.Checked, checkedListBox1.GetItemCheckState(0) == CheckState.Checked, checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked));
            }
            else if ( comboBox1.SelectedIndex == 1)
            {
                otels.Add(new LuksOtel(int.Parse(textBox4.Text), textBox1.Text,  textBox2.Text,  textBox3.Text,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked));
            }
            else if ( comboBox1.SelectedIndex == 2)
            {
                otels.Add(new PansiyonOtel(int.Parse(textBox4.Text), textBox1.Text,  textBox2.Text,  textBox3.Text,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked));
            }
            else if ( comboBox1.SelectedIndex == 3)
            {
                otels.Add(new TatilKöyüOtel(int.Parse(textBox4.Text), textBox1.Text,  textBox2.Text,  textBox3.Text,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked));
            }
            listBox1.Items.Clear();

            dosyaOlustur();
        }
        public static void dosyaOlustur() //https://stackoverflow.com/questions/15880574/deserialize-collection-of-interface-instances
        {
            FileStream fileStream = new FileStream(@"./Otel.txt", FileMode.Create);
            StreamWriter sW = new StreamWriter(fileStream);

            string json = JsonConvert.SerializeObject(otels, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Objects,
                TypeNameAssemblyFormat = System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple
            });
            sW.Write(json);
            sW.Flush();
            sW.Close();
            fileStream.Close();
        }
        public void yazdir()
        {
            foreach (Otel otel in otels)
            {
                listBox1.Items.Add(otel.Ad);
            }

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            
            OdaEkleFormu odaEkleFormu = new OdaEkleFormu(otels);
            odaEkleFormu.Show();
            this.Hide();
            //RezervasyonFormu rezervasyon = new RezervasyonFormu();
            //rezervasyon.SetAllCity(otels); //https://stackoverflow.com/questions/20441019/how-to-access-list-from-another-form
            //rezervasyon.Show();

        }

        private void OtelEkleFormu_Load(object sender, EventArgs e)
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
            yazdir();
            
            /*
            otels.AddRange(new List<Otel>() //https://www.tutorialsteacher.com/csharp/csharp-list
               { new LuksOtel(1,"Anemon","İzmir","5",true,true,true,true,true,true,true),
                 new LuksOtel(2,"Akra","Antalya","5",true,true,true,true,true,true,true),
                 new LuksOtel(3,"İnci Class","İzmir","4",true,true,true,true,false,true,true),
                 new LuksOtel(4,"Rixos","Antalya","5",true,true,true,true,true,true,true),
                new LuksOtel(5,"Asteria Kremlin","Antalya","5",true,true,true,true,false,true,true),
                new LuksOtel(6,"Lara Bulut","Antalya","5",true,true,true,true,false,true,true),
                 new LuksOtel(7,"Delphin Diva","Antalya","5",true,true,true,true,true,true,true),
                 new LuksOtel(8,"Swiss Otel","İzmir","5",true,true,true,true,true,true,true),
                new LuksOtel(9,"Hilton","İzmir","4",false,true,true,true,true,true,true),
                 new LuksOtel(10,"Key","İzmir","5",true,true,true,true,true,true,true),
               new LuksOtel(11,"Wyndham Grand","İzmir","5",true,true,true,true,true,true,true),
                new LuksOtel(12,"Crowne Plaza","İzmir","5",true,true,true,true,false,true,true),
                new ButikOtel(13,"Otantik Butik Otel","Antalya","4",false,true,false,true,false,true,false),
                new ButikOtel(14,"La Porte Boutique Hotel","Antalya","4",false,true,false,true,false,true,false),
                new ButikOtel(15,"Let'stay Boutique Hotel","Antalya","4",true,true,false,true,false,true,false),
                 new ButikOtel(16,"Sedir Palas Butik Otel","Antalya","3",false,true,false,false,false,true,false),
                new ButikOtel(17,"Kırlançe Butik Otel","İzmir","3",false,true,false,false,false,true,false),
                 new ButikOtel(18,"Viva La Vita Butik Otel","İzmir","4",false,true,false,true,false,true,false),
               new ButikOtel(19,"Casa Bella Hotel ","İzmir","5",false,true,true,true,false,true,false),
                 new PansiyonOtel(20,"Deniz Pansiyon","İzmir","2",false,false,false,false,false,true,false), 
                new PansiyonOtel(21,"Kalispera Pansiyon","İzmir","2",false,false,false,false,false,true,false),
                 new PansiyonOtel(22,"Şirincem Pension","İzmir","2",false,false,false,false,false,true,false),
                 new PansiyonOtel(23,"Altaris Pansiyon Olympos","Antalya","2",false,false,false,false,false,true,false),
                 new PansiyonOtel(24,"Hane-i Keyif Pansiyon","Antalya","2",false,false,false,false,false,true,false),
                 new PansiyonOtel(25,"Olympos Çamlık Pansiyon","Antalya","2",false,false,false,false,false,true,false),
                 new TatilKöyüOtel(26,"Zigana Yayla Tatil Köyü","Trabzon","4",false,true,false,false,true,true,false),
                 new TatilKöyüOtel(27,"Zigana Gümüşkayak Yaylakent","Trabzon","4",false,true,false,false,true,true,false),
                 new TatilKöyüOtel(28,"Konak Palas Hotel","Trabzon","3",false,true,false,false,true,true,false),
                new TatilKöyüOtel(29,"Hamsikoy","Trabzon","3",false,true,false,false,true,true,false),
            });
            dosyaOlustur();
            */

        }
    }
}
