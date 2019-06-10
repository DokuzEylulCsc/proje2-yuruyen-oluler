using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    public enum OtelType
    {
        ButikOtel=1,
        LuksOtel=2,
        PansiyonOtel=3,
        TatilKöyüOtel=4
    }
    public interface IOtelFactory
    {
        IOtel ProduceOtel(OtelType type);
    }
}
