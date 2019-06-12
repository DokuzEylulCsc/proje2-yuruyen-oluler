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
    public partial class OdaEkleFormu : Form
    {
        public OdaEkleFormu()
        {
            InitializeComponent();
        }
        private static List<Otel> otels;
        public OdaEkleFormu(List<Otel> oteller)//otel listini bu forma çekmek için
        {
            otels = oteller;
            InitializeComponent();
        }
        private static List<Oda> odas;
        public static List<Oda> GetOdas
        {
            get { return odas; }
        }
        public static List<Otel> GetOtels
        {
            get { return otels; }
        }
        
        public void dosyaOlustur() //burası gereksiz lazım olursa diye yapmıştım
        {
            FileStream fileStream = new FileStream(@"./Oda.txt", FileMode.Create);
            StreamWriter sW = new StreamWriter(fileStream);
            foreach(Otel otel in otels)
            {
                string json = JsonConvert.SerializeObject(otel.Odalar, Formatting.Indented, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Objects,
                    TypeNameAssemblyFormat = System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple
                });
                sW.Write(json);
                sW.Flush();
                sW.Close();
                fileStream.Close();
            }
                    
        }
       

        private void OdaEkleFormu_Load(object sender, EventArgs e)
        {
        
            foreach (Otel otel in otels) // var olan otellerin isimlerini seçenek sunma
            {
                comboBox1.Items.Add(otel.Ad);
            }
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           string otelAd =(string)comboBox1.SelectedItem;
          foreach(Otel otel in otels)
            {
                if (otel.Ad.Equals(otelAd)) //Comboboxta seçilen ile otel'in adı aynı ise oda ekleme işlemini gerçekleştiriyor
                {
                    if (otel.Odalar == null) //otel.Odaları null döndürdüğü için böyle bir şey yapma gereksinimi duydum
                    {
                        otel.Odalar = new List<Oda>();
                    }
                    if (comboBox2.SelectedIndex == 0)
                    {
                       otel.Odalar.Add(new CiftKisilikOda(otel.Id,Int32.Parse(textBox1.Text),Int32.Parse(textBox2.Text), checkedListBox1.GetItemCheckState(0) == CheckState.Checked, checkedListBox1.GetItemCheckState(1) == CheckState.Checked, checkedListBox1.GetItemCheckState(2) == CheckState.Checked, checkedListBox1.GetItemCheckState(3) == CheckState.Checked));
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {
                        otel.Odalar.Add(new İkiKisilikOda(otel.Id, Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text), checkedListBox1.GetItemCheckState(0) == CheckState.Checked, checkedListBox1.GetItemCheckState(1) == CheckState.Checked, checkedListBox1.GetItemCheckState(2) == CheckState.Checked, checkedListBox1.GetItemCheckState(3) == CheckState.Checked));
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {
                        otel.Odalar.Add(new TekKisilikOda(otel.Id, Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text), checkedListBox1.GetItemCheckState(0) == CheckState.Checked, checkedListBox1.GetItemCheckState(1) == CheckState.Checked, checkedListBox1.GetItemCheckState(2) == CheckState.Checked, checkedListBox1.GetItemCheckState(3) == CheckState.Checked));
                    }
                    else if (comboBox2.SelectedIndex == 3)
                    {
                        otel.Odalar.Add(new UcKisilikOda(otel.Id, Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text), checkedListBox1.GetItemCheckState(0) == CheckState.Checked, checkedListBox1.GetItemCheckState(1) == CheckState.Checked, checkedListBox1.GetItemCheckState(2) == CheckState.Checked, checkedListBox1.GetItemCheckState(3) == CheckState.Checked));
                    }
                    break;
                }
            }

            OtelEkleFormu.dosyaOlustur(); //Otel.txt'in içindeki null olan Odaları doldurmasını sağlıyor
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
