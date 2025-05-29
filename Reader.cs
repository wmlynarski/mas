using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mas_mp1
{
    class Reader : Person
    {
        public List<MediaItem> ReadItems { get; } = new List<MediaItem>();
        public Reader(string firstName, string lastName, Address? address = null)
          : base(firstName, lastName, address)
        {
        }
        public void Read(MediaItem item)
        {
            Console.WriteLine($"{FullName} czyta {item.Title}");
            ReadItems.Add(item);
        }
        public override string GetRole() => "Reader";
    }
}
