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
            foreach (Otel otel in GetOtels) 
            {
                listBox1.Items.Add(otel.ToString());
            }

            OdaEkleFormu odaEkleFormu = new OdaEkleFormu();
            odaEkleFormu.SetAllCity(otels);
            odaEkleFormu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //RezervasyonFormu rezervasyon = new RezervasyonFormu();
            //rezervasyon.SetAllCity(otels); //https://stackoverflow.com/questions/20441019/how-to-access-list-from-another-form
            //rezervasyon.Show();
            
        }

        private void OtelEkleFormu_Load(object sender, EventArgs e)
        {
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
                 new ButikOtel(14,"Otantik Butik Otel","Antalya","4",false,true,false,true,false,true,false),
                 new ButikOtel(15,"Otantik Butik Otel","Antalya","4",false,true,false,true,false,true,false),
                 new ButikOtel(16,"La Porte Boutique Hotel","Antalya","4",false,true,false,true,false,true,false),
                 new ButikOtel(17,"Let'stay Boutique Hotel","Antalya","4",true,true,false,true,false,true,false),
                 new ButikOtel(18,"Sedir Palas Butik Otel","Antalya","3",false,true,false,false,false,true,false),
                 new ButikOtel(19,"Kırlançe Butik Otel","İzmir","3",false,true,false,false,false,true,false),
                 new ButikOtel(20,"Viva La Vita Butik Otel","İzmir","4",false,true,false,true,false,true,false),
                 new ButikOtel(21,"Casa Bella Hotel ","İzmir","5",false,true,true,true,false,true,false),
                 new PansiyonOtel(22,"Deniz Pansiyon","İzmir","2",false,false,false,false,false,true,false), 
                 new PansiyonOtel(23,"Kalispera Pansiyon","İzmir","2",false,false,false,false,false,true,false),
                 new PansiyonOtel(24,"Şirincem Pension","İzmir","2",false,false,false,false,false,true,false),
                 new PansiyonOtel(25,"Altaris Pansiyon Olympos","Antalya","2",false,false,false,false,false,true,false),
                 new PansiyonOtel(26,"Hane-i Keyif Pansiyon","Antalya","2",false,false,false,false,false,true,false),
                 new PansiyonOtel(27,"Olympos Çamlık Pansiyon","Antalya","2",false,false,false,false,false,true,false),
                 new TatilKöyüOtel(28,"Zigana Yayla Tatil Köyü","Trabzon","4",false,true,false,false,true,true,false),
                 new TatilKöyüOtel(29,"Zigana Gümüşkayak Yaylakent","Trabzon","4",false,true,false,false,true,true,false),
                 new TatilKöyüOtel(30,"Konak Palas Hotel","Trabzon","3",false,true,false,false,true,true,false),
                 new TatilKöyüOtel(31,"Hamsikoy","Trabzon","3",false,true,false,false,true,true,false),
            });
        }
    }
}
