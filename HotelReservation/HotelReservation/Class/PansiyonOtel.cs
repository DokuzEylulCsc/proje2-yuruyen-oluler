using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    class PansiyonOtel:Otel
    {
        
        public PansiyonOtel(string ad, string sehir, string yildiz, bool sauna, bool acikbufe, bool spa, bool havuz, bool oyunParki, bool internet, bool sporSalonu) : base(ad, sehir, yildiz, sauna, acikbufe, spa, havuz, oyunParki, internet, sporSalonu)
        {
            
        }
        public override List<Oda> OdaEkleme(Otel otel)
        {
            return new List<Oda>();
        }
        public override List<Oda> OdaSilme(Otel otel)
        {
            return new List<Oda>();
        }
        public override List<Oda> OdaArama(Otel otel)
        {
            return new List<Oda>();
        }
    }
}
