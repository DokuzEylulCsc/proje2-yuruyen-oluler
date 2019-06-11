using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
     public class Rezervasyon
        
    {
        private int id;
        public int Id { get => id; set => id = value; }
        public DateTime Gelistarihi { get => gelistarihi; set => gelistarihi = value; }
        public DateTime Donustarihi { get => donustarihi; set => donustarihi = value; }

        private DateTime gelistarihi, donustarihi;
      
        public Rezervasyon(int id,DateTime gelistarihi,DateTime donustarihi)
        {
            this.Id = id;
            this.Gelistarihi = gelistarihi;
            this.Donustarihi = donustarihi;
            
        }
        
    }
}
