using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _018_Enum
{
    struct Coordenada
    {
        //resharper (tools - extension manager - online)
        internal LatLong latitude;
        internal LatLong longitude;

        public override string ToString()
        {
            return String.Format("{0}, {1}", latitude, longitude);
        }
    }
}
