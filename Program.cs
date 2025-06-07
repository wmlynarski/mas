using mas_mp1;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Address libAddress = new Address("ul. Książkowa 1", "Warszawa", "00-001", "Polska");
        Library library = new Library("Biblioteka Główna", libAddress);

        Address userAddress = new Address("ul. Czytelnicza 2", "Warszawa", "00-002", "Polska");
        var user = new BorrowerLibrarian("Anna", "Kowalska", userAddress, new DateOnly(1990, 5, 12));
        List<string> phoneNumbers = new List<string> { "+48123456789", "+48987654321" };
        user.AddBorrowerRole("B-001", phoneNumbers);
        user.AddLibrarianRole("L-001", library);
        user.AddMembership(user, library, DateTime.Now);

        var catalog = new Catalog("Główna kolekcja", library);
        library.AddCatalog(catalog);

        var author = new Author("Adam", "Mickiewicz", new DateOnly(1798, 12, 24), new DateOnly(1855, 11, 26), null);
        var authors = new List<Author> { author };

  
        var book = new Book("Pan Tadeusz", 1834, authors, 400, catalog);
        var dvd = new DVD("Krótki film o miłości", 1990, TimeSpan.FromMinutes(87), catalog);
        var magazine = new Magazine("Wiedza i Życie", 2023, 5, catalog);
  
        user.Borrow(book);
        user.Borrow(dvd);

        Console.WriteLine("Lista mediów:");
        Catalog.DisplayAllMediaItems();

        Console.WriteLine("\nLista wypożyczeń:");
        foreach (var loan in user.Loans)
        {
            Console.WriteLine(loan);
        }
    }
}
