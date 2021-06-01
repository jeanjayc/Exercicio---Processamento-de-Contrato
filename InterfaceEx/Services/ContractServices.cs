using System;

using InterfaceEx.Entities;

namespace InterfaceEx.Services
{
    public class ContractServices
    {
        private IOnlinePaymentService _onlinePayment;

        public ContractServices(IOnlinePaymentService onlinePayment)
        {
            _onlinePayment = onlinePayment;
        }

        public void ProcessContract(Contract contract, int months)
        {
            //Recebendo o valor do contrato e divindo esse valor pelas quantidades de meses
            double basicQuota = contract.TotalValue/months;
            //Realizando o processamento de cada parcela, de acordo com a quantidade gerada
            for(int i =1; i <= months; i++ )
            {
                //Acrescentando um mês após a data da realização do contrato 
                DateTime date = contract.Date.AddMonths(i);
                //aplicando o juros sobre a parcela
                double updateQuota = basicQuota + _onlinePayment.Interest(basicQuota, i);
                double fullQuota = updateQuota + _onlinePayment.PaymentFee(updateQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}