using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    abstract class Oda
    {
        private string id,fiyat;
        private bool miniBar,tv,jakuzi,denizManzara;
        public string getId
        {
            get
            {
                return id;
            }
        }

        public string getFiyat
        {
            get
            {
                return fiyat;
            }
        }

        public bool getminiBar
        {
            get
            {
                return miniBar;
            }
        }

        public bool getTv
        {
            get
            {
                return tv;
            }
        }
        public bool getJakuzi
        {
            get
            {
                return jakuzi;
            }
        }
        public bool getDenizManzara
        {
            get
            {
                return denizManzara;
            }
        }

        public Oda(string id, string fiyat, bool miniBar,bool jakuzi,bool denizManzara,bool tv)
        {
            this.id = id;
            this.fiyat = fiyat;
            this.miniBar = miniBar;
            this.jakuzi = jakuzi;
            this.denizManzara = denizManzara;
            this.tv = tv;
        }

    }
}
