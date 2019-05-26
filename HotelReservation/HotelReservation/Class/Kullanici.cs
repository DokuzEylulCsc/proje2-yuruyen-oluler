using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    class Kullanici
    {
        private string id,adi,telno,mail;
        public string getId
        {
            get { return id; }
        }
        public string getid
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
        public Kullanici(string id,string adi, string telno, string mail)
        {
            this.id = id;
            this.adi = adi;
            this.mail = mail;
            this.telno = telno;

        }
        public void rezervasyonYap()
        {

        }
        public void rezervasyonSil()
        {

        }
        public void bilgiDegistirme()
        {

        }
    }
}
   