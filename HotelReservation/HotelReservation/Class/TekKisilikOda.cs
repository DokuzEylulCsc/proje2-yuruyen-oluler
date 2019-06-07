using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    class TekKisilikOda:Oda
    {
        public TekKisilikOda(int OtelId, int OdaId, int fiyat, bool miniBar, bool jakuzi, bool denizManzara, bool tv) : base(OtelId, OdaId, fiyat, miniBar, jakuzi, denizManzara, tv)
        {

        }
    }
}
