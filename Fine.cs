using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mas_mp1
{
    class Fine
    {
        public int FineID { get; private set; }
        public Loan Loan { get; set; }
        public decimal Amount { get; set; }
        public static List<Fine> AllFines = new List<Fine>(); //ekstensja trwała i atrybut klasowy
        private static int _nextFineID = 1; //atrybut klasowy
        public Fine(Loan loan, decimal amount)
        {
            FineID = _nextFineID++;
            Loan = loan;
            Amount = amount;
            AllFines.Add(this);
        }
        public override string ToString() //przesłonięcie
        {
            return $"Fine [{FineID}]: {Loan.Borrower.FullName} owes {Amount:C} for loan {Loan.LoanID}";
        }
    }
}
