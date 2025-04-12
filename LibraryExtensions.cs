using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mas_mp1
{
    public static class LibraryExtensions //klasa rozszerzająca
    {
        public static string GetExtendedInfo(this MediaItem mediaItem) //metoda rozszerzająca
        {
            return $"{mediaItem.Title} (Age: {mediaItem.Age}";
        }
        public static bool IsOverdue(this Loan loan) //metoda rozszerzająca
        {
            return DateTime.Now > loan.DueDate;
        }

    }
}
