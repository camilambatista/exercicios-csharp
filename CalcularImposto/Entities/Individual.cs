using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace CalcularImposto.Entities
{
    internal class Individual : TaxPayers
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {

        }

        public Individual(string name, double income, double healthExpenditures) : base(name, income)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double CalculateTax()
        {
            double tax = (Income < 20000.00) ? Income * 0.15 : Income * 0.25;

            if(HealthExpenditures > 0)
            {
                tax -= HealthExpenditures * 0.5;
            }

            return tax;
        }
    }
}
