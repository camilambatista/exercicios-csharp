using System.Globalization;

namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string respostaDeposito = Console.ReadLine();

            ContaBancaria contaBancaria;

            if (respostaDeposito.ToLower() == "s")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                contaBancaria = new ContaBancaria(titular, numero, quantia);
            }
            else
            {
                contaBancaria = new ContaBancaria(titular, numero);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(contaBancaria.ToString());
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Depositar(valorDeposito);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contaBancaria.ToString());
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Sacar(valorSaque);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contaBancaria.ToString());
            Console.WriteLine();
        }
    }
}