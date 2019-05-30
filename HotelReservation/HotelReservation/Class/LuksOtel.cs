using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    class LuksOtel : Otel
    {
        
        public LuksOtel(string ad, string sehir, string yildiz, bool sauna, bool acikBufe, bool spa, bool havuz, bool oyunParki, bool internet, bool sporSalonu) : base(ad, sehir, yildiz, sauna, acikBufe, spa, havuz,oyunParki,internet,oyunParki)
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
