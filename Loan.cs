using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mas_mp1
{
    public class Loan
    {
        public int LoanID { get; private set; }
        public Borrower Borrower { get; set; }
        public MediaItem MediaItem { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
        public static List<Loan> AllLoans = new List<Loan>(); //ekstensja trwała
        private static int _nextLoanID = 1; //atrybut klasowy
        private const int DefaultLoanPeriodDays = 14;
        public Loan(Borrower borrower, MediaItem mediaItem) : this(borrower, mediaItem, DefaultLoanPeriodDays){}
        public Loan(Borrower borrower, MediaItem mediaItem, int loanPeriodDays) //Przeciążenie
        {
            LoanID = _nextLoanID++;
            Borrower = borrower;
            MediaItem = mediaItem;
            BorrowDate = DateTime.Now;
            DueDate = BorrowDate.AddDays(loanPeriodDays);
            AllLoans.Add(this);
        }
        public decimal Fine
        {
            get
            {
                if (DateTime.Now <= DueDate)
                {
                    return 0;
                }
                else
                {
                    int overdueDays = (DateTime.Now - DueDate).Days;
                    return overdueDays * 0.5m;
                }
            }
        }
        public override string ToString() //przesłonięcie
        {
            return $"Loan [{LoanID}]: {Borrower.FullName} borrowed {MediaItem.Title} on {BorrowDate.ToShortDateString()} due on {DueDate.ToShortDateString()}, Fine: {Fine:C}";
        }
    }
}
