using Conjuntos.Entities;

namespace Conjuntos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> courseA = new HashSet<Student>();
            HashSet<Student> courseB = new HashSet<Student>();
            HashSet<Student> courseC = new HashSet<Student>();

            Console.Write("How many students for course A? ");
            int n1 = int.Parse(Console.ReadLine());

            for (int i = 0; i < n1; i++)
            {
                int enrollment = int.Parse(Console.ReadLine());
                courseA.Add(new Student { Enrollment = enrollment });
            }


            Console.Write("How many students for course B? ");
            int n2 = int.Parse(Console.ReadLine());

            for (int i = 0; i < n2; i++)
            {
                int enrollment = int.Parse(Console.ReadLine());
                courseB.Add(new Student { Enrollment = enrollment });
            }

            Console.Write("How many students for course C? ");
            int n3 = int.Parse(Console.ReadLine());

            for (int i = 0; i < n3; i++)
            {
                int enrollment = int.Parse(Console.ReadLine());
                courseC.Add(new Student { Enrollment = enrollment });
            }

            HashSet<Student> all = new HashSet<Student>(courseA);
            all.UnionWith(courseB);
            all.UnionWith(courseC);

            Console.WriteLine($"Total students: {all.Count}");
        }
    }
}