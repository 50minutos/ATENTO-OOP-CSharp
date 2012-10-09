﻿using System;

namespace _001_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Object
            //TODAS as classes e structs herdam de Object
            //Tipo: class e struct (e ...)
            //Membro: campo, propriedade, método, evento (e ...)

            //Tipo nome;
            //nome = new Tipo();
            //new cria uma instância da classe (objeto) Object
            //Object é reference type

            Object o = new Object();

            Console.WriteLine(o.ToString());
            //representação String do objeto
            //Namespace.Tipo

            Console.WriteLine(o.GetHashCode());
            //representação numérica do objeto
            //SE hashcodes de dois objetos são diferentes,
            //os objetos SÃO diferentes 
            //SE os hashcodes forem iguais PODE SER que os
            //objetos sejam iguais

            Console.WriteLine(o.GetType().Name);
            //retorna o Type de um objeto
            //esse type será usado em Reflection,
            //entre outras coisas

            Object p = new Object();

            Console.WriteLine(o.Equals(p));
            //Equals compara dois objetos

            //o = p = null;

            //Não podemos acessar membros de null
            //não há objeto onde buscar esses membros
            //Console.WriteLine(o.Equals(p));
            
            //Equals, ToString, GetHashCode e GetType são
            //métodos de INSTÂNCIA

            Console.WriteLine(Object.Equals(o, p));
            Console.WriteLine(Object.ReferenceEquals(o, p));
            //Equals e ReferenceEquals são métodos static

            Console.ReadKey();
        }
    }
}
