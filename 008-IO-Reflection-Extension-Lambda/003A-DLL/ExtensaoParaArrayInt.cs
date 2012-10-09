using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _003A_DLL
{
    public static class ExtensaoParaArrayInt
    {
        public static int Somar(this int[] numeros)
        {
            return numeros.Sum();
        }
    }
}
