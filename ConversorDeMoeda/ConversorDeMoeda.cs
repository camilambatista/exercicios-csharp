using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeMoeda
{
    internal class ConversorDeMoeda
    {
        public static double Iof = 6.0;
        public static double ConverterMoeda(double cotacaoDolar, double quantidadeDolar)
        {
            double totalDolar = (cotacaoDolar * quantidadeDolar);
            return totalDolar + totalDolar * Iof / 100.0;
        }
    }
}
