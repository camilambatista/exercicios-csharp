using System.Globalization;

namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student[] vect = new Student[10];

            Console.Write("How many rooms will be rented? ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Rent #{i}: ");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                vect[room] = new Student(name, email);
            }

            Console.WriteLine();
            Console.WriteLine("Busy rooms: ");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine($"{i}: {vect[i]}");
                }
            }

            /* int n = int.Parse(Console.ReadLine());
             
            // VETOR DE ELEMENTOS TIPO STRUCT (VALOR)

             double[] vect = new double[n];

             for (int i = 0; i < n; i++)
             {
                 vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             }

             double sum = 0;
             foreach (var item in vect)
             {
                 sum += item;
             }

             double avg = sum / n;

             Console.WriteLine($"AVERAGE HEIGHT: {avg.ToString("F2", CultureInfo.InvariantCulture)}");

             // VETOR DE ELEMENTOS TIPO CLASSE (REFERÊNCIA)
             Product[] vect = new Product[n];

             for (int i = 0; i < n; i++)
             {
                 string name = Console.ReadLine();
                 double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                 vect[i] = new Product { Name = name, Price = price };
             }

             double sum = 0.0;
             for (int i = 0; i < n; i++)
             {
                 sum += vect[i].Price;
             }

             double avg = sum / n;

             Console.WriteLine($"AVERAGE PRICE: {avg.ToString("F2", CultureInfo.InvariantCulture)}");*/
        }
    }
}