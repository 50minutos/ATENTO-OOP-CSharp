using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001_TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //erro em tempo de design
            //compilador não divide por zero
            //Console.WriteLine(1 / 0);

            //a execução causa uma Exception em tempo de execução
            //DivideByZeroException
            //int x = 0;
            //Console.WriteLine(1/x);

            int x = 0;

            try //tentativa de execução
            {
                Console.WriteLine(1 / x);
            }
            catch (Exception ex) //captura as Exceptions
            {
                Console.WriteLine("ERRO!!!");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            finally //sempre é executado
            {
                Console.ReadKey();
            }

            //try - finally - OK
            //try - catch - finally - NOK

            Console.ReadKey();
        }
    }
}
