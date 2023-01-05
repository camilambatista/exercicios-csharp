using System;
using System.Collections.Generic;
using System.Globalization;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int count = int.Parse(Console.ReadLine());

            List<Employee> listEmployees = new List<Employee>();

            for (int i = 1 ; i <= count; i++)
            {
                Console.WriteLine($"Employee #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                listEmployees.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idIncrease = int.Parse(Console.ReadLine());

            Employee emp = listEmployees.Find(x => x.Id == idIncrease);
            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }        

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (var item in listEmployees)
            {
                Console.WriteLine(item);
            }
            
            
            /*List<string> list = new List<string>();

            // Adicionando itens na lista
            list.Add("Camila");
            list.Add("Carol");
            list.Add("Rafael");
            list.Add("Lily");
            list.Add("Reyl");

            //Inserindo nome em uma posição específica
            list.Insert(2, "João");

            // Imprimindo todos os nomes da lista
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

           // Imprimindo a quantidade de itens na lista
            Console.WriteLine("List count: " + list.Count);

            // Imprimindo o primeiro nome conforme a condição
            var s1 = list.Find(x => x[0] == 'C');
            Console.WriteLine("First name: " + s1);

            // Imprimindo o último nome conforme a condição
            var s2 = list.FindLast(x => x[0] == 'C');
            Console.WriteLine("Last name: " + s2);

            // Imprimindo posição do primeiro nome conforme condição
            int pos1 = list.FindIndex(x => x[0] == 'C');
            Console.WriteLine("First position: " + pos1);

            // Imprimindo posição do último nome conforme condição
            int pos2 = list.FindLastIndex(x => x[0] == 'C');
            Console.WriteLine("Last position: " + pos2);

            // Imprimindo todos os nomes conforme a condição
            Console.WriteLine("--------------------------");
            List<string> list2 = list.FindAll(x => x[0] == 'C');
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

            // Removendo um item da lista
            Console.WriteLine("--------------------------");
            list.Remove("João");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // Removendo todos os itens conforme a condição
            Console.WriteLine("--------------------------");
            list.RemoveAll(x => x[0] == 'C');
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // Removendo um item pela posição
            Console.WriteLine("--------------------------");
            list.RemoveAt(2);

            //Removendo um range
            Console.WriteLine("--------------------------");
            list.RemoveRange(2, 2);*/
        }
    }
}