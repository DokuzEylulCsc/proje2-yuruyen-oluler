using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
   abstract class Otel
    {
        private string ad,yildiz,sehir;
        private bool sauna,acikBufe,spa,havuz,internet,sporSalonu,oyunParki;
        public string getAd
        {
            get
            {
                return ad;

            }
        }
        public string getSehir
        {
            get
            {
                return sehir;

            }
        }
        public string getYildiz
        {
            get
            {
                return yildiz;
            }
        }
        public bool getInternet
        {
            get
            {
                return internet;
            }
        }

        public bool getSporSalonu
        {
            get
            {
                return sporSalonu;
            }
        }

        public bool getOyunPark
        {
            get
            {
                return oyunParki;
            }
        }

        public bool getSauna
        {
            get
            {
                return sauna;
            }
        }
        public bool getSpa
        {
            get
            {
                return spa;
            }
        }
        public bool getHavuz
        {
            get
            {
                return havuz;
            }
        }
        public bool getacikBufe
        {
            get
            {
                return acikBufe;
            }
        }
        public Otel(string ad,string sehir,string yildiz,bool sauna,bool acikBufe,bool spa,bool havuz,bool oyunParki,bool internet,bool sporSalonu)
        {
            this.yildiz = yildiz;
            this.ad = ad;
            this.sauna = sauna;
            this.spa = spa;
            this.acikBufe = acikBufe;
            this.havuz = havuz;
            this.oyunParki = oyunParki;
            this.internet = internet;
            this.sporSalonu = sporSalonu;
        }
        
        public abstract void OdaEkleme(string ad, string sehir, string yildiz, bool sauna, bool acikBufe, bool spa, bool havuz, bool oyunParki, bool internet, bool sporSalonu);
        public abstract void OdaSilme(string ad, string sehir, string yildiz, bool sauna, bool acikBufe, bool spa, bool havuz, bool oyunParki, bool internet, bool sporSalonu);
        public abstract void OdaArama(string ad, string sehir, string yildiz, bool sauna, bool acikBufe, bool spa, bool havuz, bool oyunParki, bool internet, bool sporSalonu);

    }
}
