using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    public abstract class Oda
    {
        private int otelId,odaId,fiyat;
        private bool miniBar,tv,jakuzi,denizManzara;
        private OdaDurumu odadurum;

        public OdaDurumu OdaDurumu
        {
            get { return odadurum; }
            set {
                switch (value)
                {
                    case OdaDurumu.Bos:
                        break;
                    case OdaDurumu.Dolu:
                        break; 
                    case OdaDurumu.Tadilatta:
                        break;
                    default:
                        break;
                }
            }
        }

        public bool MiniBar { get => miniBar; set => miniBar = value; }
        public bool Tv { get => tv; set => tv = value; }
        public bool Jakuzi { get => jakuzi; set => jakuzi = value; }
        public bool DenizManzara { get => denizManzara; set => denizManzara = value; }
        public int OtelId { get => otelId; set => otelId = value; }
        public int OdaId { get => odaId; set => odaId = value; }
        public int Fiyat { get => fiyat; set => fiyat = value; }

        public Oda(int OdaId)
        {
            this.OdaId = odaId;
        }

        protected Oda(OdaDurumu odaDurumu, bool miniBar, bool tv)
        {
            OdaDurumu = odaDurumu;
            MiniBar = miniBar;
            Tv = tv;
        }

        public Oda(int otelId,int odaId, int fiyat, bool miniBar,bool jakuzi,bool denizManzara,bool tv)
        {
            OdaId = odaId;
            OtelId = otelId;
            this.Fiyat = fiyat;
            this.MiniBar = miniBar;
            this.Jakuzi = jakuzi;
            this.DenizManzara = denizManzara;
            Tv = tv;
        }


        public string oda()
        {
            return $"{OdaId} {Fiyat} {MiniBar} {Jakuzi} {DenizManzara} {Tv}";
           }
    }
    public enum OdaDurumu 
    {
        Bos,
        Dolu,
        Tadilatta,
    }

   
}
