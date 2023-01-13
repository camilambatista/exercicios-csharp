using System.Globalization;
using OperacoesContaBancaria.Entities;
using OperacoesContaBancaria.Entities.Exceptions;

namespace OperacoesContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data: ");

                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                ContaBancaria contaBancaria = new ContaBancaria(holder, number, amount, withdrawLimit);

                Console.Write("Enter amount for withdraw: ");
                double amountWithdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                contaBancaria.Sacar(amountWithdraw);

                Console.WriteLine("New balance: " + contaBancaria.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch(DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}