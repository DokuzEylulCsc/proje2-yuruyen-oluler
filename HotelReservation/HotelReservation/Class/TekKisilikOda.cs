using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    class TekKisilikOda:Oda
    {
        public TekKisilikOda(string id, string fiyat, bool miniBar, bool jakuzi, bool denizManzara, bool tv): base(id,fiyat,miniBar,jakuzi,denizManzara,
            tv)
        {

        }
    }
}
