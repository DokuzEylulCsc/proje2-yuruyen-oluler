using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    class ButikOtel : Otel
    {
        public ButikOtel(string ad, string sehir, string yildiz, bool sauna, bool acikbufe, bool spa, bool havuz,bool oyunParki ,bool internet,bool sporSalonu) : base(ad, sehir, yildiz, sauna, acikbufe, spa, havuz,oyunParki,internet,sporSalonu)
        {

        }
        public override void OdaEkleme(string ad, string sehir, string yildiz, bool sauna, bool acikBufe, bool spa, bool havuz, bool oyunParki, bool internet, bool sporSalonu)
        {
          
        }
        public override void OdaSilme(string ad, string sehir, string yildiz, bool sauna, bool acikBufe, bool spa, bool havuz, bool oyunParki, bool internet, bool sporSalonu)
        {
        
        }
        public override void OdaArama(string ad, string sehir, string yildiz, bool sauna, bool acikBufe, bool spa, bool havuz, bool oyunParki, bool internet, bool sporSalonu)
        {
          
        }
    }
}
