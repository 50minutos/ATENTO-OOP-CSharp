using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002_Throw
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0;

            try
            {
                if (x == 0) throw new DivideByZeroException("você não pode dividir por zero");
                Console.WriteLine(1 / x);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
