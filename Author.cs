using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mas_mp1
{
    public class Author : Person
    {
        public DateTime BirthDate { get; set; }
        public static List<Author> AllAuthors = new List<Author>(); //ekstensja trwała i atrybut klasowy
        public Author(string firstName, string lastName, DateTime birthDate) : base(firstName, lastName)
        {
            BirthDate = birthDate;
            AllAuthors.Add(this);
        }
        public override string ToString() //przesłonięcie
        {
            return $"{FirstName} {LastName}";
        }
    }
}
