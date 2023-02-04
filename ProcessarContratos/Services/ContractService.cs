using System.Drawing;
using ProcessarContratos.Entities;

namespace ProcessarContratos.Services
{
    internal class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService { get; set; }
        

        public ContractService(IOnlinePaymentService taxService)
        {
            _onlinePaymentService = taxService;
        }

        public void ProcessInstallments(Contract contract, int months)
        {
            double value = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = value + _onlinePaymentService.Interest(value, i);
                double fullQuota = updatedQuota + _onlinePaymentService.PaymentFee(updatedQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
