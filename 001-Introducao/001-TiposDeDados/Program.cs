using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001_TiposDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            //value types
            //tipos básicos (simples)
            //tamanho fixo
            //structure

            //CLS-COMPLIANT

            //inteiros: byte, short, int, long
            //decimais: decimal
            //ponto flutuante: float, double
            //caracteres: char
            //boolean: bool
            //data/hora: DateTime

            //NON CLS-COMPLIANT
            //inteiros: sbyte, ushort, uint, ulong

            //System.Byte -> estrutura que armazena números inteiros de 8 bits sem sinal (de 0000 0000 a 1111 1111) -> apelido byte

            //System.Single -> estrutura que armazena números de ponto flutuante com sinal de 32 bits -> apelido float

            Console.WriteLine("CLS COMPLIANT");

            Console.WriteLine("Tipo byte:\n\tde {0}\n\taté {1}", Byte.MinValue, byte.MaxValue);

            Console.WriteLine("Tipo short:\n\tde {0}\n\taté {1}", Int16.MinValue, short.MaxValue);

            Console.WriteLine("Tipo int:\n\tde {0}\n\taté {1}", Int32.MinValue, int.MaxValue);

            Console.WriteLine("Tipo long:\n\tde {0}\n\taté {1}", Int64.MinValue, long.MaxValue);

            Console.WriteLine();

            Console.WriteLine("Tipo decimal:\n\tde {0}\n\taté {1}", Decimal.MinValue, decimal.MaxValue);

            Console.WriteLine();

            Console.WriteLine("Tipo float:\n\tde {0}\n\taté {1}", Single.MinValue, float.MaxValue);

            Console.WriteLine("Tipo double:\n\tde {0}\n\taté {1}", Double.MinValue, double.MaxValue);

            Console.WriteLine();

            Console.WriteLine("Tipo char:\n\tde {0}\n\taté {1}", Char.MinValue, char.MaxValue);

            Console.WriteLine();

            Console.WriteLine("Tipo bool:\n\t{0}\n\tou {1}", Boolean.TrueString, bool.FalseString);

            Console.WriteLine();

            Console.WriteLine("Tipo DateTime:\n\tde {0}\n\taté {1}", DateTime.MinValue, DateTime.MaxValue);

            Console.WriteLine();

            Console.WriteLine("NON CLS COMPLIANT");

            Console.WriteLine("Tipo sbyte:\n\tde {0}\n\taté {1}", SByte.MinValue, sbyte.MaxValue); //signed

            Console.WriteLine("Tipo ushort:\n\tde {0}\n\taté {1}", UInt16.MinValue, ushort.MaxValue); //unsigned

            Console.WriteLine("Tipo uint:\n\tde {0}\n\taté {1}", UInt32.MinValue, uint.MaxValue);

            Console.WriteLine("Tipo ulong:\n\tde {0}\n\taté {1}", UInt64.MinValue, ulong.MaxValue);

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
