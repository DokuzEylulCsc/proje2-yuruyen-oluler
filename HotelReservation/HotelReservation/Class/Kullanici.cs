using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
   public class Kullanici
    {
        private List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();
        public Kullanici()
        {
            Rezervasyonlar= new List<Rezervasyon>();
            Kullanicilar = new List<Kullanici>();
        }
       

        private int id, telNo;
        private string adi,mail;
        private string sifre;
        public int Id { get => id; set => id = value; }
        public int TelNo { get => telNo; set => telNo = value; }
        public string Adi { get => adi; set => adi = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Sifre { get => sifre; set => sifre = value; }
        private static List<Kullanici> Kullanicilar;


        public static List<Kullanici> GetKullanici
        {
            get { return Kullanicilar; }
            set { Kullanicilar = value; }
        }

        public List<Rezervasyon> Rezervasyonlar { get => rezervasyonlar; set => rezervasyonlar = value; }

        public Kullanici(int id,string adi,string sifre, string mail ,int telno)
        {
            this.Id = id;
            this.Adi = adi;
            this.Mail = mail;
            this.TelNo = telno;
            this.Sifre = sifre;
            Rezervasyonlar = new List<Rezervasyon>();


        }
       
    }
}
   