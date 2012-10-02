using System;
using System.Collections; //coleções de Object
using System.Collections.Generic; //coleções específicas
using System.Linq;
using System.Text;

namespace _004_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("agnaldo");
            arrayList.Add(1);
            arrayList.Add(10.1205);

            Console.WriteLine(arrayList.Count);

            foreach (var item in arrayList)
                Console.WriteLine(item);
            
            Console.WriteLine();

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(11);
            list.Add(11);
            list.Add(11);
            list.Add(11);
            list.Add(111);
            //list.Add(11.11);

            Console.WriteLine(list.Count);

            foreach (var item in list)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
