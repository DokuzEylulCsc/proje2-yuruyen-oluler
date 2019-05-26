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

        public override void OdaEkleme(Oda oda)
        {

        }
        public override void OdaSilme(Oda oda)
        {

        }
        public override void OdaArama(Oda oda)
        {

        }
    }
}
