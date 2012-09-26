using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _006_HerancaModificadoresAcesso
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new Derivada();
            d._public = d._protectedInternal = d._internal = 1;

            //aqui não vemos private (somente Base tem acesso) nem
            //protect (somente Base e suas derivadas tem 
            //         acesso - Program não herda de Base
            //         nem de Derivada)
        }
    }

    /*
     * moderadores de acesso para membros de tipo:
     *    - private: somente outros membros do mesmo tipo tem acesso 
     *    - protected: membros de tipos derivados tem acesso
     *    - internal: membros de tipos que estão no mesmo assembly tem acesso
     *    - protected internal: membros de tipos derivados 
     *      ou de tipos que estão no mesmo assembly tem acesso
     *    - public: qualquer membro de qualquer classe tem acesso
     */

    class Base
    {
        private int _private;
        protected int _protected;
        internal int _internal;
        protected internal int _protectedInternal;
        public int _public;

        public Base()
        {
            //aqui vemos todos os membros...
        }
    }

    class Derivada : Base
    {
        public Derivada()
        {
            //aqui não vemos private (somente Base tem acesso)
        }
    }
}
