using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mas_mp1
{
    class Librarian : Person
    {
        public int LibrarianId { get; private set; }
        public static List<Librarian> AllLibrarians = new List<Librarian>(); //ekstensja trwała i atrybut klasowy
        public Librarian(int id, string firstName, string lastName, Address? address = null) : base(firstName, lastName, address)
        {
            LibrarianId = id;
            AllLibrarians.Add(this);
        }
        public override string ToString() //przesłonięcie
        {
            return $"Librarian {LibrarianId}: {FullName}";
        }
    }
}
