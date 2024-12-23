using System.Globalization;

namespace Construtores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500, 10);

            p.Nome = "Tv 4k";
            //p.Preco = 400; // readonly value 

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
        }
    }
}
