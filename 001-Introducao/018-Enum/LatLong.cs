using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _018_Enum
{
    struct LatLong
    {
        internal int g; //graus
        internal int m; //minutos
        internal PontoCardeal d; //N E S W

        public override string ToString()
        {
            return String.Format("{0} {1} {2}", g, m, d);
        }
    }
}
