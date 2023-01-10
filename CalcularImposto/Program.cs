using System.Globalization;
using System.Runtime.Serialization.Json;
using CalcularImposto.Entities;

namespace CalcularImposto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayers> list = new List<TaxPayers>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, income, healthExpenditures));
                }
                else
                {
                    Console.Write("number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, income, employees));
                }
                Console.WriteLine();
            }

            Console.WriteLine("TAXES PAID: ");
            double sum = 0;
            foreach (var item in list)
            {
                Console.WriteLine(item.Name + ": $" + item.CalculateTax().ToString("F2", CultureInfo.InvariantCulture));
                sum += item.CalculateTax();
            }

            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}