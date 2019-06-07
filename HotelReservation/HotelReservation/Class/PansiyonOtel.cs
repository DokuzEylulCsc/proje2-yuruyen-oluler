using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    class PansiyonOtel:Otel
    {
        
        public PansiyonOtel(int id, string ad, string sehir, string yildiz, bool sauna, bool acikbufe, bool spa, bool havuz, bool oyunParki, bool internet, bool sporSalonu) : base(id, ad, sehir, yildiz, sauna, acikbufe, spa, havuz, oyunParki, internet, sporSalonu)
        {
          
        }
       
    }
}
