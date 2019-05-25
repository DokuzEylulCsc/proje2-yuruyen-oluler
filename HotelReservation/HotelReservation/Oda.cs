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
        private bool minibar,tv,jakuzi,denizmanzara;

        public Oda(string id, string fiyat, bool minibar,bool jakuzi,bool denizmanzara,bool tv)
        {
            this.id = id;
            this.fiyat = fiyat;
            this.minibar = minibar;
            this.jakuzi = jakuzi;
            this.denizmanzara = denizmanzara;
            this.tv = tv;
        }

    }
}
