using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mas_mp1
{
    public abstract class MediaItem
    {
        public int MediaItemID { get; private set; }
        public string Title { get; set; }
        public int PublicationYear { get; set; }
        public List<Author> Authors { get; set; } //atrybut powtarzalny
        public string? Edition { get; set; } //atrybut opcjonalny
        public static List<MediaItem> AllMediaItems = new List<MediaItem>(); //ekstensja trwała i atrybut klasowy
        private static int _nextMediaItemID = 1; //atrybut klasowy
        public MediaItem(string title, int publicationYear, List<Author> authors, string? edition = null)
        {
            MediaItemID = _nextMediaItemID++;
            Title = title;
            PublicationYear = publicationYear;
            Authors = authors;
            Edition = edition;
            AllMediaItems.Add(this);
        }
        public int Age
        {
            get
            {
                return DateTime.Now.Year - PublicationYear; //atrybut pochodny
            }
        }
        public static List<MediaItem> SearchByTitle(string title) //metoda klasowa
        {
            return AllMediaItems.Where(m => m.Title.Contains(title, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public abstract string GetMediaType();
        public override string ToString() //przesłonięcie
        {
            string authors = string.Join(", ", Authors);
            return $"{GetMediaType()} [{MediaItemID}]: {Title} by {authors}  published in {PublicationYear}, Age: {Age} years";
        }

    }
}
