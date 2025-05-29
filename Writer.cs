using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mas_mp1
{
    class Writer : Person
    {
        public List<string> Reviews { get; } = new List<string>();
        public Writer(string firstName, string lastName, Address? address = null)
    : base(firstName, lastName, address)
        {
        }
        public void WriteReview(MediaItem item, string review)
        {
            Console.WriteLine($"{FullName} ocenia {item.Title}: {review}");
            Reviews.Add($"{item.Title}: {review}");
        }
        public override string GetRole() => "Writer";
    }
}
