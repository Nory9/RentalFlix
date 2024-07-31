using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml;

namespace RentalFlix.Entites
{
    public enum Status{
        active,
        fulfilled,
        canceled
    }
    internal class Reservation
    {
//        ReservationID(PK) : Unique identifier for each reservation.
//CustomerID(FK): ID of the customer who reserved the movie.
//MovieID(FK): ID of the reserved movie.
//ReservationDate: Date when the reservation was made.
//Status: Status of the reservation (active, fulfilled, canceled).

        public int ReservationID { get; set; }
        public int CustomerID { get; set; }
        public int MovieID { get; set; }
        public string ReservationDate { get; set; }
        public Status Status { get; set; }
    }

}
