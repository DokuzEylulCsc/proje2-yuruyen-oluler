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
        public string getid
        {
            get { return id; }
        }
        public string getadi
        {
            get { return adi; }
        }
        public string gettelno
        {
            get { return telno; }
        }
        public string getmail
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
        public void rezervasyonyap()
        {

        }
        public void rezervasyonsil()
        {

        }
        public void bilgidegistirme()
        {

        }
    }
}
