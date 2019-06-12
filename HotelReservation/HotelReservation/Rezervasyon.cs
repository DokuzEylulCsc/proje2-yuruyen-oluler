using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
     public class Rezervasyon
        
    {
        
        public DateTime Gelistarihi { get => gelistarihi; set => gelistarihi = value; }
        public DateTime Donustarihi { get => donustarihi; set => donustarihi = value; }
        public List<Oda> Odas { get => odas; set => odas = value; }

        private List<Oda> odas = new List<Oda>();

        private DateTime gelistarihi, donustarihi;
      
        public Rezervasyon(DateTime gelistarihi,DateTime donustarihi)
        {
            this.Gelistarihi = gelistarihi;
            this.Donustarihi = donustarihi;
            Odas = new List<Oda>();
            
        }
        
    }
}
