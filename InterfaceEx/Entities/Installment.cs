using System;

namespace InterfaceEx.Entities
{
    public class Installment
    {
        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public DateTime DueDate { get; set; }
        public double Amount { get; set; }
    }
}