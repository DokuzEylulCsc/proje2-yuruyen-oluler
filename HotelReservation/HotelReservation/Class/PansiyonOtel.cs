using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    class PansiyonOtel:Otel
    {
        
        public PansiyonOtel(string ad, string sehir, string yildiz, bool internet) : base(ad, sehir, yildiz, internet)
        {
            
        }
    }
}
