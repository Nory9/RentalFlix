using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RentalFlix.Entites
{
    internal class Movie
    {
//        MovieID(PK) : Unique identifier for each movie.
//Title: Title of the movie.
//Genre: Genre or category of the movie.
//Director: Director of the movie.
//ReleaseYear: The year the movie was released.
//Rating: Movie rating (e.g., PG, PG-13, R).

        public int MovieID { get; set; }    
        public string Title { get; set; }
        public string Genre { get; set; } 
        public string Director { get; set; } 
        public DateOnly ReleaseYear { get; set; } 
        public string Rating { get; set; } 


    }
}
