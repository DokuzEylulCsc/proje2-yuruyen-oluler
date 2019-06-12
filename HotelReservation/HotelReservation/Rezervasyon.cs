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
        public List<Otel> Otels { get => otels; set => otels = value; }

        private List<Oda> odas = new List<Oda>();
        private List<Otel> otels = new List<Otel>();
        private DateTime gelistarihi, donustarihi;
      
        public Rezervasyon(DateTime gelistarihi,DateTime donustarihi)
        {
            this.Gelistarihi = gelistarihi;
            this.Donustarihi = donustarihi;
            Odas = new List<Oda>();
            Otels = new List<Otel>();
        }
        
    }
}
