using System.Globalization;

namespace AtualizaEstoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            Produto p = new Produto("TV", 500.00, 10);

            Console.WriteLine(p.Nome);

            p.Nome = "TV 4K";

            Console.WriteLine(p.Nome);
        }
    }
}