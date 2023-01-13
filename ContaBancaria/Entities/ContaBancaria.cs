using System.Globalization;
using OperacoesContaBancaria.Entities.Exceptions;

namespace OperacoesContaBancaria.Entities
{
    internal class ContaBancaria
    {
        public string Holder { get; set; }
        public int Number { get; private set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; set; }

        public ContaBancaria()
        {
          
        }

        public ContaBancaria(string holder, int number, double initialBalance, double withdrawLimit)
        {
            Holder = holder;
            Number = number;
            WithdrawLimit = withdrawLimit;
            Depositar(initialBalance);
        }

        public string Titular
        {
            get { return Holder; }
            set
            {
                if (value != null && value.Length > 1)
                    Holder = value;
            }
        }

        public void Depositar(double amount)
        {
            Balance += amount;
        }

        public void Sacar(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }

            if (amount > Balance)
            {
                throw new DomainException("Not enough balance");
            }
            Balance -= amount;
        }
        public override string ToString()
        {
            return $"Conta {Number}, Titular: {Holder}, Saldo: $ {Balance.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
