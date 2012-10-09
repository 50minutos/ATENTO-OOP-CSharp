using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _003_Catches
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");

            try
            {
                int x = Int32.Parse(Console.ReadLine());

                Console.WriteLine(1 / x);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("divisão por zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("formato incorreto");
            }
            catch (OverflowException)
            {
                Console.WriteLine("valor fora de faixa");
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
