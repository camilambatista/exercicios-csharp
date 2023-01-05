namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] line = Console.ReadLine().Split(' ');
            int m = int.Parse(line[0]);
            int n = int.Parse(line[1]);

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(mat[i, j] == number)
                    {
                        Console.WriteLine($"Position: {i},{j} ");

                        if(j + 1 < n)
                            Console.WriteLine($"Right: {mat[i, j + 1]} ");
                        if (j - 1 >= 0)
                            Console.WriteLine($"Left: {mat[i, j - 1]} ");
                        if (i + 1 < m)
                            Console.WriteLine($"Down: {mat[i+1, j]} ");
                        if (i - 1 >= 0)
                            Console.WriteLine($"Up: {mat[i - 1, j]} ");
                        Console.WriteLine();
                    }
                }
            }

            /*
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);   
                }
            }

            Console.WriteLine("Main diagonal");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                        count++;
                }
            }

            Console.WriteLine("Negative numbers: " + count);*/
        }
    }
}