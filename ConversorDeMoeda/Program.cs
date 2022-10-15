using System.Globalization;

namespace ConversorDeMoeda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double quantidadeDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Valor a ser pago em reais: R${ConversorDeMoeda.ConverterMoeda(cotacaoDolar, quantidadeDolar).ToString("F2")}");
        }
    }
}