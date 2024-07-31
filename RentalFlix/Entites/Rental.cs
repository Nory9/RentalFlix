using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml;

namespace RentalFlix.Entites
{
    internal class Rental
    {
//        RentalID(PK) : Unique identifier for each rental record.
//CustomerID(FK) : ID of the customer who rented the movie.
//FormatID(FK): ID of the movie format that was rented.
//RentalDate: Date when the movie was rented.
//DueDate: The date when the movie is due to be returned.
//ReturnDate: Date when the movie was returned (nullable).

        public int RentalID { get; set; }
        public int CustomerID { get; set; }
        public int FormatID { get; set; }
        public DateOnly RentalDate { get; set; }
        public DateOnly DueDate { get; set; }
        public DateOnly? ReturnDate { get; set; }

    }
}
