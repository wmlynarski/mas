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
        public Catalog Catalog { get; set; }
        public List<Librarian> Librarians { get; set; } = new List<Librarian>(); //Asocjacja zwykła
        public List<Membership> Memberships { get; set; } = new List<Membership>();
        public Library(string name)
        {
            Name = name;
            Catalog = new Catalog(this); //Asocjacja - kompozycja
        }
        public void showCatalog()
        {
            Console.WriteLine($"Catalog of {Name}:");
            Catalog.DisplayAllMediaItems();
        }
    }
}
