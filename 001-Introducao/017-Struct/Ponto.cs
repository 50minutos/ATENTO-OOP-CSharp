using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _017_Struct
{
    //por default tipos são sempre internal

    //moderadores de acesso: private, internal, protected, protected internal, public 

    struct Ponto //value type
    {
        //por default membros de tipo são sempre privados

        internal int x; //field (campo)
        internal int y; //field (campo)

        //CTRL+R, CTRL+R -> REFACTOR, RENAME


        //override -> sobreposição (substituição)
        public override String ToString()
        {
            return String.Format("({0}, {1})", x, y);
        }
    }

    struct Ponto3D
    {
        internal int x; 
        internal int y; 
        internal int z;

        public override String ToString()
        {
            return String.Format("({0}, {1}, {2})", x, y, z);
        }
    }
}
