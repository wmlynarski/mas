using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mas_mp1
{
    class DVD : MediaItem, ILoanable, IReservable
    {
        public TimeSpan Duration { get; set; }
        public DVD(string title, int publicationYear, List<Author> authors, TimeSpan duration, string? edition = null) : base(title, publicationYear, authors, edition)
        {
            Duration = duration;
        }
        public void LoanTo(Borrower borrower)
        {
            new Loan(borrower, this);
        }

        public void ReserveBy(Borrower borrower)
        {
            new Reservation(borrower, this);
        }
        public override string GetMediaType() => "DVD";
        public override string ToString() //przesłonięcie
        {
            return base.ToString() + $", duration: {Duration}";
        }
    }
}
