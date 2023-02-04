using System.Globalization;
using ProcessarContratos.Entities;
using ProcessarContratos.Services;

namespace ProcessarContratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data: ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double totalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, totalValue);

            ContractService contractService = new ContractService(new PaypalService());

            contractService.ProcessInstallments(contract, installments);

            Console.WriteLine("Installments: ");
            foreach (var item in contract.Installments)
            {
                Console.WriteLine($"{item.DueDate.ToString("dd/MM/yyyy")} - {item.Amount}");
            }
        }
    }
}