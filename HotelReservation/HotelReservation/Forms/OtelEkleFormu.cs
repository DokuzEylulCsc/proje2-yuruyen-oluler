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
            foreach (Otel otel in GetOtels) //Üniversitedeki fakülte list'ine eklenen değerleri listbox'a atma
            {
                listBox1.Items.Add(otel.ToString());
            }
        }

    }
}
