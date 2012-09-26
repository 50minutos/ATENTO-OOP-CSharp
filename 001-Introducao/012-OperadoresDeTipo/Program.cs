using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _012_OperadoresDeTipo
{
    class Program
    {
        static void Main(string[] args)
        {
            //is as ... extra: typeof() e GetType()

            Object s = "qualquer coisa";

            Console.WriteLine(s is String); //true
            Console.WriteLine(s is Random); //false

            String x = s as String;
            Console.WriteLine(x);

            Random r = s as Random; //String não é Random... então r = null
            Console.WriteLine(r);

            Console.WriteLine();

            Console.WriteLine(typeof(String)); //retorna um Type
            Console.WriteLine(s.GetType()); //retorna um Type

            //var colunaDeTabela = new System.Data.DataColumn("Codigo", typeof(int));

            //Type t = typeof(int);

            //foreach (var item in t.GetMembers())
            //{
            //    Console.WriteLine(item);
            //}

            Console.ReadKey();
       }
    }
}
