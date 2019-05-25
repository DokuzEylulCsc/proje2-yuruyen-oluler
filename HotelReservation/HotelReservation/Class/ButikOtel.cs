using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    class ButikOtel : Otel
    {
        public ButikOtel(string ad, string sehir, string yildiz, bool sauna, bool acikbufe, bool spa, bool havuz,bool internet) : base(ad, sehir, yildiz, sauna, acikbufe, spa, havuz,internet)
        {

        }
    }
}
