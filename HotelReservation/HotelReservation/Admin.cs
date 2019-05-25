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
        public string getid
        {
            get { return id; }
        }
        public string getadi
        {
            get { return adi; }
        }
        public string getsifre
        {
            get { return sifre; }
        }
        
        public Admin(string id, string adi, string sifre)
        {
            this.id = id;
            this.adi = adi;
            this.sifre = sifre;
        

        }
        public void BilgileriGöster()
        {

        }
        public void otelekle()
        {

        }
        public void odaekle()
        {

        }
    }
}
