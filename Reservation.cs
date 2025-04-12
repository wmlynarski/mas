using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mas_mp1
{
    class Reservation
    {
        public int ReservationID { get; private set; }
        public Borrower Borrower { get; set; }
        public MediaItem MediaItem { get; set; }
        public DateTime ReservationDate { get; set; }
        public List<Reservation> AllReservations = new List<Reservation>(); //ekstensja trwała i atrybut klasowy
        private static int _nextReservationID = 1; //atrybut klasowy
        public Reservation(Borrower borrower, MediaItem mediaItem)
        {
            ReservationID = _nextReservationID++;
            Borrower = borrower;
            MediaItem = mediaItem;
            ReservationDate = DateTime.Now;
            AllReservations.Add(this);
        }
        public override string ToString() //przesłonięcie
        {
            return $"Reservation [{ReservationID}]: {Borrower.FullName} reserved {MediaItem.Title} on {ReservationDate.ToShortDateString()}";
        }
    }
}
