using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mas_mp1
{
    public class Borrower : Person
    {
        public int BorrowerId { get; private set; }
        public List<string> PhoneNumbers { get; set; } //atrybut powtarzalny
        public static List<Borrower> AllBorrowers = new List<Borrower>(); //ekstensja trwała i atrybut klasowy
        public List<Membership> Memberships { get; set; } = new List<Membership>(); 
        public Borrower(int id, string firstName, string lastName, Address? address = null) : base(firstName, lastName, address)
        {
            BorrowerId = id;
            PhoneNumbers = new List<string>();
            AllBorrowers.Add(this);
        }
        public override string ToString() //przesłonięcie
        {
            return $"Borrower {BorrowerId}: {FullName}";
        }

    }
}
