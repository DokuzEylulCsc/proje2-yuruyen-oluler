using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservation
{
    class Admin
    {
        List<Otel> otelList = new List<Otel>();
        private string id, adi,sifre;
        public string getId
        {
            get { return id; }
        }
        public string getAdi
        {
            get { return adi; }
        }
        public string getSifre
        {
            get { return sifre; }
        }
        
        public Admin(string id, string adi, string sifre)
        {
            this.id = id;
            this.adi = adi;
            this.sifre = sifre;
        

        }
        public Admin()
        {

        }

        public void bilgileriGöster(Otel otel)
        {
            
        }
        Forms.OtelEkleFormu OtelEkleFormu = new Forms.OtelEkleFormu();
        public static List<Otel> otels = new List<Otel>();
        public void OtelEkle()
        {
            if (OtelEkleFormu.comboBox1.SelectedIndex == 0)
            {
                otels.Add(new ButikOtel(OtelEkleFormu.textBox1.Text, OtelEkleFormu.textBox2.Text, OtelEkleFormu.textBox3.Text, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked));

            }
            else if (OtelEkleFormu.comboBox1.SelectedIndex == 1)
            {
                otels.Add(new LuksOtel(OtelEkleFormu.textBox1.Text, OtelEkleFormu.textBox2.Text, OtelEkleFormu.textBox3.Text, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked));
            }
            else if (OtelEkleFormu.comboBox1.SelectedIndex == 2)
            {
                otels.Add(new PansiyonOtel(OtelEkleFormu.textBox1.Text, OtelEkleFormu.textBox2.Text, OtelEkleFormu.textBox3.Text, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked));
            }
            else if (OtelEkleFormu.comboBox1.SelectedIndex == 3)
            {
                otels.Add(new TatilKöyüOtel(OtelEkleFormu.textBox1.Text, OtelEkleFormu.textBox2.Text, OtelEkleFormu.textBox3.Text, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked, OtelEkleFormu.checkedListBox1.GetItemCheckState(0) == CheckState.Checked));
            }
        }
        public void OtelSil(Otel otel)
        {

        }

        public Otel Otel
        {
            get => default(Otel);
            set
            {
            }
        }
    }

    public class Class1
    {
    }
}
