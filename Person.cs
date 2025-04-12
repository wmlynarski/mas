using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace mas_mp1
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address? Address { get; set; } //atrybut opcjonaly i złożony
        public string FullName => $"{FirstName} {LastName}"; //atrybut pochodny
        public Person(string firstName, string lastName, Address? address = null)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }
        public override string ToString() //przesłonięcie
        {
            return $"{FirstName} {LastName}";
        }
    }
}
