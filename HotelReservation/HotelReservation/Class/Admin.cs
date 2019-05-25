using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    class Admin
    {
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
        public void bilgileriGöster()
        {

        }
        public void otelEkle()
        {

        }
        public void odaEkle()
        {

        }
    }
}
