﻿using System.Globalization;

namespace Construtores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500, 10);

            p.SetNome("Tv 4k");

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
        }
    }
}
