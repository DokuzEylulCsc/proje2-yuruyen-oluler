using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    class TatilKöyüOtel : Otel
    {

        public TatilKöyüOtel(string ad, string sehir, string yildiz, bool acikbufe, bool havuz) : base(ad, sehir, yildiz, acikbufe,havuz)
        {

        }
    }
}
