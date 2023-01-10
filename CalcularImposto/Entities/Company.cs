using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularImposto.Entities
{
    internal class Company : TaxPayers
    {
        public int Employees { get; set; }

        public Company()
        {

        }

        public Company(string name, double income, int employees) : base(name, income)
        {
            Employees = employees;
        }

        public override double CalculateTax()
        {
            return (Employees > 10) ? Income * 0.14 : Income * 0.16;
        }
    }
}
