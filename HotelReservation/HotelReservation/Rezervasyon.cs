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
       
        public string getId
        {
            get { return id; }
        }
      

        public Rezervasyon(string id,Kullanici kullanici,decimal Fiyat)
        {
            this.id = id;
            this.kullanici = kullanici;
            this.Fiyat = Fiyat;


        }
        
    }
}
