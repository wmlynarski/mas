using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mas_mp1
{
    class Library
    {
        public string Name { get; set; }
        public Catalog Catalog { get; set; }
        public Library(string name)
        {
            Name = name;
            Catalog = new Catalog();
        }
        public void showCatalog()
        {
            Console.WriteLine($"Catalog of {Name}:");
            Catalog.DisplayAllMediaItems();
        }
    }
}
