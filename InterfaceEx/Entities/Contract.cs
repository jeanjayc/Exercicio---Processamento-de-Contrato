using System;
using System.Collections.Generic;

namespace InterfaceEx.Entities
{
    public class Contract
    {
        public Contract(int number, DateTime date, double totalValue, List<Installment> installments)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = installments;
        }

        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; }
    }
}