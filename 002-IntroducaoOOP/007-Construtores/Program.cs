using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _007_Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro();

            Console.WriteLine(livro.Codigo);
            Console.WriteLine(livro.Titulo);
            Console.WriteLine(livro.QuantidadePaginas);
            Console.WriteLine(livro.Preco);

            livro.Codigo = 1;
            livro.Titulo = "ABC do Truco";
            livro.QuantidadePaginas = 452;
            livro.Preco = 23.54;

            Console.WriteLine();

            Console.WriteLine(livro.Codigo);
            Console.WriteLine(livro.Titulo);
            Console.WriteLine(livro.QuantidadePaginas);
            Console.WriteLine(livro.Preco);

            Console.WriteLine();

            Livro outro = new Livro(2, "Porrinha sem Mistério", 342, 21.8);

            Console.WriteLine(outro.Codigo);
            Console.WriteLine(outro.Titulo);
            Console.WriteLine(outro.QuantidadePaginas);
            Console.WriteLine(outro.Preco);

            Console.ReadKey();
        }
    }

    class Livro
    {
        public int Codigo { get; set; }
        public String Titulo { get; set; }
        public int QuantidadePaginas { get; set; }
        public double Preco { get; set; }

        //minha implementação para o construtor default
        public Livro()
            : this(0, null, 0, 0)
        {
            //this representa a instância da classe (objeto)
            //this(***) é uma chamada para um construtor desta classe
            //this.*** é uma chamada para um membro desta classe 
        }

        public Livro(int codigo, String titulo, int qtd, double preco)
        {
            Codigo = codigo;
            Titulo = titulo;
            QuantidadePaginas = qtd;
            Preco = preco;
        }

        //sobrecarga (overload) é quando temos mais de uma versão do mesmo membro do tipo (por exemplo: métodos, construtores e operadores)
        //na sobrecarga os membros sobrecarregados DEVEM ter assinaturas diferentes
        //Livro() e Livro(int, String, int, int) são sobrecargas de construtor
    }
}
