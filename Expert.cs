using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mas_mp1
{
    class Expert : Person
    {
        public int ReadBooksCount { get; private set; }
        public int WrittenReviewsCount { get; private set; }
        public Expert(string firstName, string lastName, Address? address = null)
         : base(firstName, lastName, address)
        {
        }
        public void ReadBook(MediaItem item)
        {
            Console.WriteLine($"{FullName} czyta {item.Title}");
            ReadBooksCount++;
        }

        public void WriteReview(MediaItem item, string review)
        {
            Console.WriteLine($"{FullName} ocenia {item.Title}: {review}");
            WrittenReviewsCount++;
        }
        public override string GetRole() => "Expert";
    }
}
