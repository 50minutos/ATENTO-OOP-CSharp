using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _011_OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            //&& || !

            /*
             * &&    true  false
             * true  true  false
             * false false false
             * 
             * ||    true  false
             * true  true  true
             * false true  false
             * 
             * !     true  false
             *       false true
             */

            Console.WriteLine(true && 10 > 4); //true
            Console.WriteLine(false || 10 != 10); //false
            Console.WriteLine(!true); //false
            Console.WriteLine(!!true); //true

            Console.ReadKey();

            //short-circuit

            //c1 = false
            //c2 = true
            //c1 && c2 -> não avalia c2
            //c2 || c1 -> não avalia c1
        }
    }
}
