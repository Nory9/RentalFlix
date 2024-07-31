using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml;

namespace RentalFlix.Entites
{
    public enum FormatType {
        DVD,
        Blu_ray,
        Digital
    }
    internal class MovieFormat
    {
//        FormatID(PK) : Unique identifier for each movie format.
//MovieID(FK): Identifier of the movie.
//FormatType: Type of format (DVD, Blu-ray, Digital).
//QuantityAvailable: Number of copies available for rent.

        public int FormatID { get; set; }
        public int MovieID { get; set; }
        public FormatType FormatType { get; set; }
        public int QuantityAvailable { get; set; }

    }
}
