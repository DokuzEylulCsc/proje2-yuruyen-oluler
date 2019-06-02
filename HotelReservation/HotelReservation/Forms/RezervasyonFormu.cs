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
    public partial class RezervasyonFormu : Form
    {
        public RezervasyonFormu()
        {
            InitializeComponent();
        }
        public void SetAllCity(List<Otel> input)//https://stackoverflow.com/questions/20441019/how-to-access-list-from-another-form
        {
            foreach (Otel s in input)
            {
                comboBox1.Items.Add(s.sehirismi());
            }
        }
        private static List<Otel> otels = new List<Otel>();
        public static List<Otel> GetOtels
        {
            get { return otels; }
        }
        private void RezervasyonFormu_Load(object sender, EventArgs e)
        {
            foreach (Otel otel in GetOtels)
            {
                    comboBox1.Items.Add(otel.sehirismi());
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
