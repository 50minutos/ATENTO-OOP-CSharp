using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002_HomemMulher
{
    class Program
    {
        static void Main(string[] args)
        {
            //a declaração define que membros são acessados
            Animal a;

            Console.Write("Você quer criar um [H]omem ou uma [M]ulher? ");
            ConsoleKeyInfo tecla = Console.ReadKey();

            a = tecla.Key == ConsoleKey.H
                ? (Animal)new Homem()
                : tecla.Key == ConsoleKey.M ? (Animal)new Mulher() : null;

            if (a == null) return;

            //early binding - o compilador já sabe o tipo de dado no momento do desenvolvimento
            //Homem h = new Homem();

            //late binding - o compilador decide o tipo do dado no momento da execução
            //Animal a = new Homem();
            //ou 
            //Animal a = new Mulher();

            Console.WriteLine();
            Console.WriteLine();

            a.Acordar();
            a.Comer();
            a.Dormir();

            if (a is Homem) ((Homem)a).PagarPensao();

            //Homem h = new Homem();
            //h.PagarPensao();

            Console.ReadKey();
        }
    }

    class Animal
    {
        public String Nome { get; set; }

        public void Acordar() { Console.WriteLine("o animal acordou"); }
        public virtual void Comer() { Console.WriteLine("o animal comeu"); }
        public void Dormir() { Console.WriteLine("o animal dormiu"); }
    }

    class Homem : Animal
    {
        public void PagarPensao() { Console.WriteLine("o homem pagou pensão"); }

        public override void Comer()
        {
            Console.WriteLine("o homem comeu com a boca aberta, cuspindo comida, falando, babando e rindo...");
        }
    }

    class Mulher : Animal
    {
        public override void Comer()
        {
            Console.WriteLine("a mulher comeu salada");
        }

        public new void Dormir() { Console.WriteLine("deixa eu dormir mais..."); }
    }
}
