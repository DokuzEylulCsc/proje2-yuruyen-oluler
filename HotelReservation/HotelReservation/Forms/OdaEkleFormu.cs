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
    public partial class OdaEkleFormu : Form
    {
        public OdaEkleFormu()
        {
            InitializeComponent();
        }
        private static List<Otel> otels = new List<Otel>();
        public static List<Otel> GetOtels
        {
            get { return otels; }
        }

        public void SetAllCity(List<Otel> input)//https://stackoverflow.com/questions/20441019/how-to-access-list-from-another-form
        {
            otels = input;
            foreach (Otel s in input)
            {
                comboBox1.Items.Add(s.otelad());
            }
        }

        private void OdaEkleFormu_Load(object sender, EventArgs e)
        {
            foreach (Otel otel in GetOtels)
            {

                comboBox1.Items.Insert(otel.Id,otel.otelad());
            }
     
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = comboBox1.SelectedIndex;
          foreach(Otel otel in GetOtels)
            {
                if (otel.Id == id)
                {
                    if (comboBox2.SelectedIndex == 0)
                    {
                        otel.Odalar.Add(new CiftKisilikOda(textBox1.Text, textBox2.Text, checkedListBox1.GetItemCheckState(0) == CheckState.Checked, checkedListBox1.GetItemCheckState(0) == CheckState.Checked, checkedListBox1.GetItemCheckState(0) == CheckState.Checked, checkedListBox1.GetItemCheckState(0) == CheckState.Checked));
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {
                        otel.Odalar.Add(new İkiKisilikOda(textBox1.Text, textBox2.Text, checkedListBox1.GetItemCheckState(0) == CheckState.Checked, checkedListBox1.GetItemCheckState(0) == CheckState.Checked, checkedListBox1.GetItemCheckState(0) == CheckState.Checked, checkedListBox1.GetItemCheckState(0) == CheckState.Checked));
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {
                        otel.Odalar.Add(new TekKisilikOda(textBox1.Text, textBox2.Text, checkedListBox1.GetItemCheckState(0) == CheckState.Checked, checkedListBox1.GetItemCheckState(0) == CheckState.Checked, checkedListBox1.GetItemCheckState(0) == CheckState.Checked, checkedListBox1.GetItemCheckState(0) == CheckState.Checked));
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {
                        otel.Odalar.Add(new UcKisilikOda(textBox1.Text, textBox2.Text, checkedListBox1.GetItemCheckState(0) == CheckState.Checked, checkedListBox1.GetItemCheckState(0) == CheckState.Checked, checkedListBox1.GetItemCheckState(0) == CheckState.Checked, checkedListBox1.GetItemCheckState(0) == CheckState.Checked));
                    }
                }
            }
        }
    }
}
