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
      
        private static List<Rezervasyon> rezervasyons = new List<Rezervasyon>();
        private static List<Otel> otels = new List<Otel>();
        private static List<Oda> odas = new List<Oda>();

        public static List<Kullanici> Kullanicis { get => kullanicis; set => kullanicis = value; }
        public static List<Rezervasyon> Rezervasyons { get => rezervasyons; set => rezervasyons = value; }
        public static List<Otel> Otels { get => otels; set => otels = value; }
        public static List<Oda> Odas { get => odas; set => odas = value; }

        private void RezervasyonFormu_Load(object sender, EventArgs e)
        {

            string dosya_yolu = @"./Otel.txt";//sehirleri getirmek için json dosyasından otel bilgilerini aldım.
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string yazi = sw.ReadToEnd();
            sw.Close();
            fs.Close();
            Otels = JsonConvert.DeserializeObject<List<Otel>>(yazi, new JsonSerializerSettings //Otels list'ini json dosyasından okuma
            {
                TypeNameHandling = TypeNameHandling.Objects
            });

           

            foreach (Otel otel in Otels)
            {

                if (!comboBox1.Items.Contains(otel.Sehir)) //Aynı şehirleri tekrar eklemesin diye
                {
                    comboBox1.Items.Add(otel.Sehir);//Varolan şehirlerden seçim yapması için
                    
                }
               
            }
            KullanıcıKayıtFormu.dosyaOlustur();

        }

        private void button1_Click(object sender, EventArgs e) 
        {
            string sehir =(string) comboBox1.SelectedItem;
            string yildiz = (string)comboBox2.SelectedItem;

            
                foreach (Otel otel in Otels)
                {
                    if (otel.Odalar == null)
                    {

                    }

                    else
                    {
                        foreach (Oda oda in otel.Odalar)
                        {
                            if (otel.Odalar == null)
                            {

                            }
                            else
                            {
                                if (sehir.Equals(otel.Sehir) && yildiz.Equals(otel.Yildiz) && ((oda.Fiyat > Int64.Parse(textBox1.Text)) && (oda.Fiyat < Int64.Parse(textBox2.Text))) && otel.Sauna == (checkedListBox1.GetItemCheckState(0) == CheckState.Checked) && otel.AcikBufe == (checkedListBox1.GetItemCheckState(1) == CheckState.Checked) && otel.Spa == (checkedListBox1.GetItemCheckState(2) == CheckState.Checked) && otel.Havuz == (checkedListBox1.GetItemCheckState(3) == CheckState.Checked) && otel.OyunParki == (checkedListBox1.GetItemCheckState(4) == CheckState.Checked) && otel.Internet == (checkedListBox1.GetItemCheckState(5) == CheckState.Checked) && otel.SporSalonu == (checkedListBox1.GetItemCheckState(6) == CheckState.Checked))
                                {
                                    if (oda.MiniBar == (checkedListBox2.GetItemCheckState(0) == CheckState.Checked) && oda.Jakuzi == (checkedListBox2.GetItemCheckState(1) == CheckState.Checked) && oda.DenizManzara == (checkedListBox2.GetItemCheckState(2) == CheckState.Checked) && oda.Tv == (checkedListBox2.GetItemCheckState(3) == CheckState.Checked))
                                    {

                                        listBox1.Items.Add(oda.OdaId);
                                    }

                                }
                            }

                        }
                    }

                
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sehir = (string)comboBox1.SelectedItem;
            string yildiz = (string)comboBox2.SelectedItem;
            int secilen=(int)listBox1.SelectedItem;
            foreach(Kullanici kullanici in Kullanicis)
            {
                foreach (Otel otel in Otels)
                {

                    if (otel.Odalar == null)
                    {

                    }

                    else
                    {
                        foreach (Oda oda in otel.Odalar)
                        {
                            if (secilen == (oda.OdaId))

                                if (otel.Odalar == null)
                                {

                                }
                                else
                                {
                                    if (sehir.Equals(otel.Sehir) && yildiz.Equals(otel.Yildiz) && ((oda.Fiyat > Int64.Parse(textBox1.Text)) && (oda.Fiyat < Int64.Parse(textBox2.Text))) && otel.Sauna == (checkedListBox1.GetItemCheckState(0) == CheckState.Checked) && otel.AcikBufe == (checkedListBox1.GetItemCheckState(1) == CheckState.Checked) && otel.Spa == (checkedListBox1.GetItemCheckState(2) == CheckState.Checked) && otel.Havuz == (checkedListBox1.GetItemCheckState(3) == CheckState.Checked) && otel.OyunParki == (checkedListBox1.GetItemCheckState(4) == CheckState.Checked) && otel.Internet == (checkedListBox1.GetItemCheckState(5) == CheckState.Checked) && otel.SporSalonu == (checkedListBox1.GetItemCheckState(6) == CheckState.Checked))
                                    {
                                        if (oda.MiniBar == (checkedListBox2.GetItemCheckState(0) == CheckState.Checked) && oda.Jakuzi == (checkedListBox2.GetItemCheckState(1) == CheckState.Checked) && oda.DenizManzara == (checkedListBox2.GetItemCheckState(2) == CheckState.Checked) && oda.Tv == (checkedListBox2.GetItemCheckState(3) == CheckState.Checked))
                                        {
                                            kullanici.Rezervasyonlar.Add(new Rezervasyon(dateTimePicker1.Value, dateTimePicker2.Value));
                                        }

                                    }
                                }

                        }
                    }

                }
            }
          
            KullanıcıKayıtFormu.dosyaOlustur();

            //
        }
    }
}
