using System.Data.Common;
using System.Globalization;
using System.Reflection.Metadata;

namespace Arquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string sourcePath = @"C:\temp\file.csv";
                string targetPath = @"C:\temp\out\summary.csv";

                Directory.CreateDirectory(Path.Combine(new FileInfo(sourcePath).DirectoryName, "out"));

                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        string[] columns = line.Split(';');
                        double totalPrice = int.Parse(columns[2]) * double.Parse(columns[1]);

                        sw.WriteLine($"{columns[0]};{totalPrice.ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}