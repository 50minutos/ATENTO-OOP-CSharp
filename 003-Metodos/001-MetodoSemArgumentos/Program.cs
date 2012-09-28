using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001_MetodoSemArgumentos
{
    class Program
    {
        //estrutura do método:
        //modificadores TipoDoRetorno Nome(lista de argumentos) {implementação}
        //lista de argumentos: Tipo1 nome1, Tipo2 nome2, ...

        //return -> retorna o processamento para a linha que "chamou o método"
        //se o TipoDoRetorno != void, obrigatoriamente teremos um return

        static void Main(String[] args)
        {
            var c = new Classe();
            
            var x = GerarNumero();

            c.Escrever();
            c.Escrever();

            Classe.EscreverMeuNome();
            Classe.EscreverMeuNome();

            Console.ReadKey();
        }

        static double GerarNumero() { return 4.45; }
    }

    class Classe
    {
        //private é o default para membros de tipo
        internal void Escrever()
        {
            Console.WriteLine("qualquer coisa");
        }

        //static indica que o método é acessado usando o tipo (classe Classe)
        internal static void EscreverMeuNome()
        {
            Console.WriteLine("agnaldo");
        }
    }
}
