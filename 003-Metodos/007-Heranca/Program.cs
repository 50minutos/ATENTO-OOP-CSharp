using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _007_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            var batman = new Morcego();

            batman.Acordar();
            batman.Comer();
            batman.Voar();
            batman.Mamar();
            batman.Dormir();

            Console.ReadKey();
        }
    }

    class Animal
    {
        public void Acordar() { Console.WriteLine("Animal.Acordar()"); }

        //virtual indica que o método PODE SER sobreposto
        public virtual void Comer() { Console.WriteLine("Animal.Comer()"); }

        public void Dormir() { Console.WriteLine("Animal.Dormir()"); }
    }

    class Mamifero : Animal
    {
        public void Mamar() { Console.WriteLine("Mamifero.Mamar()"); }
    }

    class Cao : Mamifero
    {
        public void Morder() { Console.WriteLine("Cao.Morder()"); }
    }

    class Morcego : Mamifero
    {
        public void Voar() { Console.WriteLine("Morcego.Voar()"); }

        //new indica que o método desta classe esconde o método com 
        //a mesma assinatura que veio da classe base
        public new void Dormir() { Console.WriteLine("Morcego.Dormir()"); }

        //override indica que o método desta classe é uma nova versão
        //do método com a mesma assinatura que veio por herança, ou seja:
        //é uma sobreposição (substituição)
        public override void Comer()
        {
            Console.WriteLine("Morcego.Comer()");
        }
    }

    class Reptil : Animal
    {
        public void Rastejar() { Console.WriteLine("Reptil.Rastejar()"); }

        //sealed indica que o mesmo não pode ser sobreposto
        public sealed override void Comer(){ Console.WriteLine("Reptil.Comer()"); }
    }

    //sealed indica que esta classe não pode ser herdada
    sealed class Sogra : Reptil
    {
        public void DoerDente() { Console.WriteLine("eheheheheh"); }
    }

    class Elefante : Mamifero
    {
        public void Bramir() { Console.WriteLine("Elefante.Bramir()"); }
    }

    //class Esposa : Sogra { }
}
