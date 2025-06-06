﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mas_mp1
{
    public class Loan
    {
        public int LoanID { get; private set; }
        public BorrowerLibrarian BorrowerLibrarian { get; set; }
        public MediaItem MediaItem { get; set; }
        public DateTime DueDate { get; set; }
        public static List<Loan> AllLoans = new List<Loan>();
        private static int _nextLoanID = 1;
        private const int DefaultLoanPeriodDays = 30;
        private const int HonoraryLoanPeriodDays = 60;
        private Status Status { get; set; } = Status.Borrowed;
        public Loan(BorrowerLibrarian borrowerLibrarian, MediaItem mediaItem)
      : this(borrowerLibrarian, mediaItem, borrowerLibrarian.IsHonorable() ? HonoraryLoanPeriodDays : DefaultLoanPeriodDays)
        {
        }
        public Loan(Person person, MediaItem mediaItem, int loanPeriodDays)
        {
            LoanID = _nextLoanID++;
            BorrowerLibrarian = person as BorrowerLibrarian ?? throw new ArgumentException("Person must be a BorrowerLibrarian", nameof(person));
            MediaItem = mediaItem;
            DueDate = DateTime.Now.AddDays(loanPeriodDays);
            AllLoans.Add(this);
        }
        public decimal Fine => CountFine();
        public decimal CountFine()
        {
            if (DateTime.Now <= DueDate)
                return 0;
            int overdueDays = (DateTime.Now - DueDate).Days;
            return overdueDays * 0.5m;
        }
        public override string ToString()
        {
            return $"Loan [{LoanID}]: {BorrowerLibrarian.FirstName} borrowed {MediaItem.Title} due on {DueDate.ToShortDateString()}, Fine: {Fine:C}";
        }
        public void SetStatusBorrowed()
        {
            Status = Status.Borrowed;
        }

        public void SetStatusReturnedInTime()
        {
            Status = Status.ReturnedInTime;
        }

        public void SetStatusReturnedLateFineNotPayed()
        {
            Status = Status.ReturnedLateFineNotPayed;
        }

        public void SetStatusReturnedLateFinePayed()
        {
            Status = Status.ReturnedLateFinePayed;
        }
        public Status GetStatus
        {
            get { return Status; }
        }
    }
}
