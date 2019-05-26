using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    class Rezervasyon
        
    {
        private string id;
        private DateTime gelistarihi, donustarihi;
        public string getId
        {
            get { return id; }
        }
        public DateTime getgelistarihi
        {
            get { return getgelistarihi; }
        }
        public DateTime getdonustarihi
        {
            get { return getdonustarihi; }
        }

        public Rezervasyon(string id, DateTime gelistarihi, DateTime donustarihi)
        {
            this.gelistarihi = gelistarihi;
            this.donustarihi = donustarihi;
            this.id = id;


        }
        
    }
}
