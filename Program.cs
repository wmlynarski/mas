using mas_mp1;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("Main St 1", "Warsaw", "00-001", "Poland");
        Address addr2 = new Address("Second St 22", "Krakow", "30-002", "Poland");

        Borrower borrower1 = new Borrower(1, "Jan", "Kowalski", addr1);
        borrower1.PhoneNumbers.Add("123456789");
        borrower1.PhoneNumbers.Add("987654321");

        Library library = new Library("Miejska Biblioteka");

        Catalog MainCatalog = new Catalog(library);

        Membership membership1 = new Membership(borrower1, library, DateTime.Now);

        Librarian librarian1 = new Librarian(1, "Anna", "Nowak", library, addr2);

        Author author1 = new Author("Adam", "Mickiewicz", new DateTime(1798, 12, 24));
        Author author2 = new Author("Henryk", "Sienkiewicz", new DateTime(1846, 5, 5));

        Publisher pub1 = new Publisher("PWN", addr1);

        Book book1 = new Book("Pan Tadeusz", 1834, new List<Author> { author1 }, pub1, 350);
        Magazine mag1 = new Magazine("Tech Today", 2020, new List<Author> { author2 }, 5);
        DVD dvd1 = new DVD("Inception", 2010, new List<Author> { author2 }, TimeSpan.FromMinutes(148));

        MainCatalog.LoadFromFile();
        if (MainCatalog.MediaItems.Count == 0)
        {
            MainCatalog.AddMediaItem(book1);
            MainCatalog.AddMediaItem(mag1);
            MainCatalog.AddMediaItem(dvd1);
        }

        MediaItem found = MainCatalog.GetById(book1.MediaItemID);
        Console.WriteLine(found != null ? $"Found by qualifier: {found}" : "Not found");

        Loan loan1 = new Loan(borrower1, book1);
        Console.WriteLine(loan1);
        Console.WriteLine("Is the loan overdue? " + loan1.IsOverdue());

        Reservation reservation1 = new Reservation(borrower1, dvd1);
        Console.WriteLine(reservation1);

        Console.WriteLine(book1.GetExtendedInfo());

        foreach (var lib in library.Librarians)
            Console.WriteLine(lib);

        foreach (var m in library.Memberships)
            Console.WriteLine($"{m.Borrower.FullName} member since {m.Since:d}");

        library.showCatalog();

        Console.WriteLine(book1.GetDetailedInfo(true));
    }
}
