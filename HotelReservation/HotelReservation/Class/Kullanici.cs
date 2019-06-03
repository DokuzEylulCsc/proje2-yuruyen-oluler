using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
   public class Kullanici
    {
        public Forms.KullanıcıKayıtFormu KullanıcıKayıtFormu = new Forms.KullanıcıKayıtFormu();
        private static List<Kullanici> KullaniciList = new List<Kullanici>();
        public List<Rezervasyon> Rezervasyonlar { get; set; }//1 Kişi birden fazla rezervasyon yapabilir.
        private DateTime gelistarihi, donustarihi;
        public DateTime getgelistarihi
        {
            get { return getgelistarihi; }
        }
        public DateTime getdonustarihi
        {
            get { return getdonustarihi; }
        }
        public Kullanici()
        {
            Rezervasyonlar = new List<Rezervasyon>();
        }
        public static List<Kullanici> GetKullaniciList
        {
            get
            {
                return KullaniciList;
            }
        }
     
        private string id,adi,telno,mail;
       
        private string sifre;

        public string  GetSifre
        {
            get { return sifre; }
            set { sifre = value; }
        }

        public string getId
        {
            get { return id; }
        }
        public string getadi
        {
            get { return adi; }
        }
        public string getTelNo
        {
            get { return telno; }
        }
        public string getMail
        {
            get { return mail; }
        }

        internal Rezervasyon Rezervasyon
        {
            get => default(Rezervasyon);
            set
            {
            }
        }

        public Kullanici(string id,string adi,string sifre, string telno, string mail,DateTime gelistarihi,DateTime donustarihi)
        {
            this.id = id;
            this.adi = adi;
            this.mail = mail;
            this.telno = telno;

            this.gelistarihi = gelistarihi;
            this.donustarihi = donustarihi;

        }
        public void rezervasyonYap()
        {

        }
        public void rezervasyonSil()
        {

        }
        public void rezervasyonduzenle()
        {

        }
        public void rezervasyonaara()
        {
            //Burada rez numarasına göre rezervasyon detayları verilcek.
        }

    }
}
   