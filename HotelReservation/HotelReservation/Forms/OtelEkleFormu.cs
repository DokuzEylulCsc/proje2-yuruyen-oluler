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
                otels.Add(new ButikOtel(textBox1.Text, textBox2.Text, textBox3.Text, checkedListBox1.GetItemCheckState(0) == CheckState.Checked, checkedListBox1.GetItemCheckState(0) == CheckState.Checked, checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked));
            }
            else if ( comboBox1.SelectedIndex == 1)
            {
                otels.Add(new LuksOtel( textBox1.Text,  textBox2.Text,  textBox3.Text,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked));
            }
            else if ( comboBox1.SelectedIndex == 2)
            {
                otels.Add(new PansiyonOtel( textBox1.Text,  textBox2.Text,  textBox3.Text,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked));
            }
            else if ( comboBox1.SelectedIndex == 3)
            {
                otels.Add(new TatilKöyüOtel( textBox1.Text,  textBox2.Text,  textBox3.Text,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked,  checkedListBox1.GetItemCheckState(0) == CheckState.Checked));
            }
            listBox1.Items.Clear();
            foreach (Otel otel in GetOtels) 
            {
                listBox1.Items.Add(otel.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RezervasyonFormu rezervasyon = new RezervasyonFormu();
            rezervasyon.SetAllCity(otels); //https://stackoverflow.com/questions/20441019/how-to-access-list-from-another-form
            rezervasyon.Show();
        }

        private void OtelEkleFormu_Load(object sender, EventArgs e)
        {
            otels.AddRange(new List<Otel>() //https://www.tutorialsteacher.com/csharp/csharp-list
                { new LuksOtel("Anemon","İzmir","5",true,true,true,true,true,true,true),
                 new LuksOtel("Akra","Antalya","5",true,true,true,true,true,true,true),
                 new LuksOtel("İnci Class","İzmir","4",true,true,true,true,false,true,true),
                 new LuksOtel("Rixos","Antalya","5",true,true,true,true,true,true,true),
                 new LuksOtel("Asteria Kremlin","Antalya","5",true,true,true,true,false,true,true),
                 new LuksOtel("Lara Bulut","Antalya","5",true,true,true,true,false,true,true),
                 new LuksOtel("Delphin Diva","Antalya","5",true,true,true,true,true,true,true),
                 new LuksOtel("Swiss Otel","İzmir","5",true,true,true,true,true,true,true),
                 new LuksOtel("Hilton","İzmir","4",false,true,true,true,true,true,true),
                 new LuksOtel("Key","İzmir","5",true,true,true,true,true,true,true),
                 new LuksOtel("Wyndham Grand","İzmir","5",true,true,true,true,true,true,true),
                 new LuksOtel("Crowne Plaza","İzmir","5",true,true,true,true,false,true,true),
                 new ButikOtel("Otantik Butik Otel","Antalya","4",false,true,false,true,false,true,false),
                 new ButikOtel("Otantik Butik Otel","Antalya","4",false,true,false,true,false,true,false),
                 new ButikOtel("Otantik Butik Otel","Antalya","4",false,true,false,true,false,true,false),
                 new ButikOtel("La Porte Boutique Hotel","Antalya","4",false,true,false,true,false,true,false),
                 new ButikOtel("Let'stay Boutique Hotel","Antalya","4",true,true,false,true,false,true,false),
                 new ButikOtel("Sedir Palas Butik Otel","Antalya","3",false,true,false,false,false,true,false),
                 new ButikOtel("Kırlançe Butik Otel","İzmir","3",false,true,false,false,false,true,false),
                 new ButikOtel("Viva La Vita Butik Otel","İzmir","4",false,true,false,true,false,true,false),
                 new ButikOtel("Casa Bella Hotel ","İzmir","5",false,true,true,true,false,true,false),
                 new PansiyonOtel("Deniz Pansiyon","İzmir","2",false,false,false,false,false,true,false), 
                 new PansiyonOtel("Kalispera Pansiyon","İzmir","2",false,false,false,false,false,true,false),
                 new PansiyonOtel("Şirincem Pension","İzmir","2",false,false,false,false,false,true,false),
                 new PansiyonOtel("Altaris Pansiyon Olympos","Antalya","2",false,false,false,false,false,true,false),
                 new PansiyonOtel("Hane-i Keyif Pansiyon","Antalya","2",false,false,false,false,false,true,false),
                 new PansiyonOtel("Olympos Çamlık Pansiyon","Antalya","2",false,false,false,false,false,true,false),
                 new TatilKöyüOtel("Zigana Yayla Tatil Köyü","Trabzon","4",false,true,false,false,true,true,false),
                 new TatilKöyüOtel("Zigana Gümüşkayak Yaylakent","Trabzon","4",false,true,false,false,true,true,false),
                 new TatilKöyüOtel("Konak Palas Hotel","Trabzon","3",false,true,false,false,true,true,false),
                 new TatilKöyüOtel("Hamsikoy","Trabzon","3",false,true,false,false,true,true,false),
            });
        }
    }
}
