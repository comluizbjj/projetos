using ModuloXIV___Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloXIV___Interfaces.Services
{
    class ContractServices
    {
        private IValueJuros _valueJuros;

        public ContractServices(IValueJuros valueJuros)
        {
            _valueJuros = valueJuros;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double baseQuota = contract.TotalValue / months;

            for(int cont = 1; cont <= months; cont++)
            {
                DateTime date = contract.Date.AddMonths(cont);
                double fullQuota = baseQuota + _valueJuros.Interest(baseQuota, cont);
                fullQuota = fullQuota + _valueJuros.PaymentFee(fullQuota);
                contract.Installments.Add(new Installment(date, fullQuota)) ;
            }
        }
    }
}
