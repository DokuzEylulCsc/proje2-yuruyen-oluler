﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    class ButikOtel : Otel
    {
        public ButikOtel(string id, string yildiz, bool sauna, bool acikbufe, bool spa, bool havuz) : base(id, yildiz, sauna, acikbufe, spa, havuz)
        {

        }
    }
}
