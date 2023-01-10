using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularImposto.Entities
{
    abstract class TaxPayers
    {
        public string Name { get; set; }
        public double Income { get; set; }

        public TaxPayers()
        {

        }

        public TaxPayers(string name, double income)
        {
            Name = name;
            Income = income;
        }

        public abstract double CalculateTax();
    }
}
