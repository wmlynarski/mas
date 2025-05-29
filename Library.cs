using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mas_mp1
{
    public class Library
    {
        public string Name { get; set; }
        public List<Catalog> Catalogs { get; private set; } = new List<Catalog>(); //Kompozycja
        public List<Librarian> Librarians { get; set; } = new List<Librarian>(); //Asocjacja zwykła
        public List<Membership> Memberships { get; set; } = new List<Membership>();
        public Library(string name)
        {
            Name = name;
        }
        public void showCatalog()
        {
            Console.WriteLine($"Catalog of {Name}:");
            Catalog.DisplayAllMediaItems();
        }
        public void RemoveLibrarian(Librarian librarian)
        {
            Librarians.Remove(librarian);
        }
        public void AddLibrarian(Librarian librarian)
        {
            Librarians.Add(librarian);
        }
        public void AddCatalog(Catalog catalog)
        {
            Catalogs.Add(catalog);
        }
    }
}
