using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mas_mp1
{
    class Book : MediaItem
    {
        public Publisher? Publisher { get; set; } //atrybut opcjonalny
        public int NumberOfPages { get; set; } 
        public Book(string title, int publicationYear, List<Author> authors, Publisher? publisher, int numberOfPages, string? edition = null) : base(title, publicationYear, authors, edition)
        {
            Publisher = publisher;
            NumberOfPages = numberOfPages;
        }
        public override string GetMediaType() => "Book";
        public string GetDetailedInfo(bool includePublisher) //przesłoięcie
        {
            if(includePublisher && Publisher != null)
            {
                return $"{base.ToString()} - Publisher: {Publisher.Name}";
            }
            else
            {
                return base.ToString();
            }
        }
    }
}
