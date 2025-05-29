using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mas_mp1
{
    interface IReservable
    {
        void ReserveBy(Borrower borrower);
    }
}
