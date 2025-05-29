using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mas_mp1
{
    public class Librarian : Person
    {
        public int LibrarianId { get; private set; }
        public static List<Librarian> AllLibrarians = new List<Librarian>(); //ekstensja trwała i atrybut klasowy
        public Library _library;
        public Library Library
        {
            get => _library;
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(value));
                if (_library != null)
                    _library.RemoveLibrarian(this);
                _library = value;
                if (!value.Librarians.Contains(this))
                    value.Librarians.Add(this);
            }
        }
        public Librarian(int id, string firstName, string lastName, Library library, Address? address = null) : base(firstName, lastName, address)
        {
            LibrarianId = id;
            Library = library;
            AllLibrarians.Add(this);
        }
        public override string ToString() //przesłonięcie
        {
            return $"Librarian {LibrarianId}: {FullName}" + (Library != null ? $" @ {Library.Name}" : "");
        }
        public override string GetRole() => "Librarian";
    }
}
