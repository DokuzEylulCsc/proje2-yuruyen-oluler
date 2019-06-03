using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
     public class Rezervasyon
        
    {
        private string id;
        public Kullanici kullanici { get; set; }
        public decimal Fiyat { get; set; }
        private DateTime gelistarihi, donustarihi;
        public DateTime getgelistarihi
        {
            get { return getgelistarihi; }
        }
        public DateTime getdonustarihi
        {
            get { return getdonustarihi; }
        }

        public string getId
        {
            get { return id; }
        }
      

        public Rezervasyon(string id,Kullanici kullanici,decimal Fiyat,DateTime gelistarihi,DateTime donustarihi)
        {
            this.id = id;
            this.kullanici = kullanici;
            this.Fiyat = Fiyat;
            this.gelistarihi = gelistarihi;
            this.donustarihi = donustarihi;


        }
        
    }
}
