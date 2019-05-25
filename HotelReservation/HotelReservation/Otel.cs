using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
   abstract class Otel
    {
        private string id,yildiz;
        private bool sauna, acikbufe, spa,havuz;
        public string getid
        {
            get
            {
                return id;

            }
        }
        public string getyildiz
        {
            get
            {
                return yildiz;
            }
        }
        public bool getsauna
        {
            get
            {
                return sauna;
            }
        }
        public bool getspa
        {
            get
            {
                return spa;
            }
        }
        public bool gethavuz
        {
            get
            {
                return havuz;
            }
        }
        public bool getacikbufe
        {
            get
            {
                return acikbufe;
            }
        }
        public Otel(string id,string yildiz,bool sauna,bool acikbufe,bool spa,bool havuz)
        {
            this.yildiz = yildiz;
            this.id = id;
            this.sauna = sauna;
            this.spa = spa;
            this.acikbufe = acikbufe;
            this.havuz = havuz;
        }
    }
}
