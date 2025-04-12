using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mas_mp1
{
    class Publisher
    {
        public string Name { get; set; }
        public Address Address { get; set; } //atrybut złożony
        public static List<Publisher> AllPublishers = new List<Publisher>(); //ekstensja trwała i atrybut klasowy
        public Publisher(string name, Address address)
        {
            Name = name;
            Address = address;
            AllPublishers.Add(this);
        }
        public override string ToString() //przesłonięcie
        {
            return $"{Name}, {Address}";
        }
    }
}
