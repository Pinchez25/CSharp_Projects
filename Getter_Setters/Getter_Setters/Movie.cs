using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Getter_Setters
{
    class Movie
    {
        public string title, director;

        // Only code inside this class can access and/or modify the rating
        private string rating;

        public Movie(string aTitle, string aDirector, string aRating) {
            title = aTitle;
            director = aDirector;
            //rating = aRating;
            Rating = aRating;
        }
        // Getter and Setter for rating
        public string Rating {
            get {
                return rating;
            
            }
            set {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "R")
                {

                    rating = value;
                }
                else {
                    rating = "NR";
                
                
                }
            }
        }
    }
}
