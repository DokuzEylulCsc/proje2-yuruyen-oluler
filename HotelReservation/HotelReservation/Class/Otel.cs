using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
  public abstract class Otel
    {
        
        private string ad,yildiz,sehir;
        private int id;
        private bool sauna,acikBufe,spa,havuz,internet,sporSalonu,oyunParki;
       
        public Otel()
        {
            Odalar = new List<Oda>();
        }
        private List<Oda> odalar = new List<Oda>();

        public int Id { get => id; set => id = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Yildiz { get => yildiz; set => yildiz = value; }
        public string Sehir { get => sehir; set => sehir = value; }
        public bool Sauna { get => sauna; set => sauna = value; }
        public bool AcikBufe { get => acikBufe; set => acikBufe = value; }
        public bool Spa { get => spa; set => spa = value; }
        public bool Havuz { get => havuz; set => havuz = value; }
        public bool Internet { get => internet; set => internet = value; }
        public bool SporSalonu { get => sporSalonu; set => sporSalonu = value; }
        public bool OyunParki { get => oyunParki; set => oyunParki = value; }
        public List<Oda> Odalar { get => odalar; set => odalar = value; }

        public Otel(int id,string ad,string sehir,string yildiz,bool sauna,bool acikBufe,bool spa,bool havuz,bool oyunParki,bool internet,bool sporSalonu)
        {
            this.id = id;
            this.Yildiz = yildiz;
            this.Ad = ad;
            this.Sehir = sehir;
            this.Sauna = sauna;
            this.Spa = spa;
            this.AcikBufe = acikBufe;
            this.Havuz = havuz;
            this.OyunParki = oyunParki;
            this.Internet = internet;
            this.SporSalonu = sporSalonu;
            Odalar = new List<Oda>();
        }
     
    }
}
