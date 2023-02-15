using System.Globalization;
using System.Xml.Linq;
using Lambda.Entities;

namespace Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Empolyee> list = new List<Empolyee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salaryEmploye = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    list.Add(new Empolyee(name, email, salaryEmploye));
                }
            }

            var listEmail = list.Where(p => p.Salary > salary).OrderBy(p => p.Email).Select(p => p.Email);

            Console.WriteLine("Email of people whose salary is more than 2000.00:");
            foreach (var email in listEmail)
            {
                Console.WriteLine(email);
            }

            var sum = list.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);
            Console.WriteLine($"Sum of salary of people whose name starts with 'M': {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}