using System;
using System.Collections.Generic;

namespace InterfaceEx.Entities
{
    public class Contract
    {
        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Installment>();
        }

        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}