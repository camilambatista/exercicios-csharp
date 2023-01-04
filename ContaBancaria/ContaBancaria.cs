using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    internal class ContaBancaria
    {
        private string _titular;
        public int Numero { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(string titular, int numero)
        {
            _titular = titular;
            Numero = numero;
        }

        public ContaBancaria(string titular, int numero, double depositoInicial) : this(titular, numero)
        {
            Depositar(depositoInicial);
        }

        public string Titular
        {
            get { return _titular; }   
            set
            {
                if (value != null && value.Length > 1)
                    _titular = value;
            }
        }

        public void Depositar(double quantia)
        {
            Saldo += quantia;
        }

        public void Sacar(double quantia)
        {
            Saldo -= quantia + 5.0;
        }
        public override string ToString()
        {
            return $"Conta {Numero}, Titular: {_titular}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
