using System.Globalization;

namespace AtualizaEstoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto: ");

            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade no Estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            //Adicionar Produtos
            Console.Write("Digite a quantidade de produtos a serem adicionadas no estoque: ");
            int qte = int.Parse(Console.ReadLine());

            p.AdicionarProdutos(qte);

            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();

            //Remover Produtos
            Console.Write("Digite a quantidade de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());

            p.RemoverProdutos(qte);

            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}