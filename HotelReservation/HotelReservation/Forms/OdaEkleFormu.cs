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
        public OdaEkleFormu(List<Otel> oteller)
        {
            otels = oteller;
            InitializeComponent();
        }
        
        public static List<Otel> GetOtels
        {
            get { return otels; }
        }

      
        string [] s = new string[10000];
        string[] otelId = new string[200];
        string[] otelAd = new string[200];
        string[] sehir = new string[200];
        string[] yildiz = new string[200];
        string[] sauna = new string[200];
        string[] spa = new string[200];
        string[] havuz = new string[200];
        string[] acikBufe = new string[200];
        string[] oyunPark = new string[200];
        string[] internet = new string[200];
        string[] sporSalonu = new string[200];
        string[] lines = new string[2000];


        public void dosyaOlustur()
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
        public void yazdir()
        {

            foreach (Otel otel in otels)
            {
                listBox1.Items.Add(otel.Odalar);
            }

        }

        private void OdaEkleFormu_Load(object sender, EventArgs e)
        {
        
            foreach (Otel otel in otels)
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
                if (otel.Ad.Equals(otelAd))
                {
                    if (otel.Odalar == null)
                    {
                        otel.Odalar = new List<Oda>();
                    }
                    if (comboBox2.SelectedIndex == 0)
                    {
                       otel.Odalar.Add(new CiftKisilikOda(otel.Id,Int32.Parse(textBox1.Text),Int32.Parse(textBox2.Text), checkedListBox1.GetItemCheckState(0) == CheckState.Checked, checkedListBox1.GetItemCheckState(0) == CheckState.Checked, checkedListBox1.GetItemCheckState(0) == CheckState.Checked, checkedListBox1.GetItemCheckState(0) == CheckState.Checked));
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {
                        otel.Odalar.Add(new İkiKisilikOda(otel.Id, Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text),checkedListBox1.GetItemCheckState(0) == CheckState.Checked, checkedListBox1.GetItemCheckState(0) == CheckState.Checked, checkedListBox1.GetItemCheckState(0) == CheckState.Checked, checkedListBox1.GetItemCheckState(0) == CheckState.Checked));
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {
                        otel.Odalar.Add(new TekKisilikOda(otel.Id, Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text), checkedListBox1.GetItemCheckState(0) == CheckState.Checked, checkedListBox1.GetItemCheckState(0) == CheckState.Checked, checkedListBox1.GetItemCheckState(0) == CheckState.Checked, checkedListBox1.GetItemCheckState(0) == CheckState.Checked));
                    }
                    else if (comboBox2.SelectedIndex == 3)
                    {
                        otel.Odalar.Add(new UcKisilikOda(otel.Id, Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text), checkedListBox1.GetItemCheckState(0) == CheckState.Checked, checkedListBox1.GetItemCheckState(0) == CheckState.Checked, checkedListBox1.GetItemCheckState(0) == CheckState.Checked, checkedListBox1.GetItemCheckState(0) == CheckState.Checked));
                    }
                    break;
                }
            }

            OtelEkleFormu.dosyaOlustur();
          
        }

       
    }
}
