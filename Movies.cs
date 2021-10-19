using System;
using System.Collections.Generic;
using System.Text;

namespace MovieList
{
    class Movies
    {
        public string Title { get; set; }
        public string Category { get; set; }
        

        public Movies (string Title, string Category)
        {
            this.Title = Title;
            this.Category = Category;
        }

        public override string ToString()
        {
            string output = $"Title: {Title} \n";
            output += $"Genre: {Category}\n";
            

            return output; ;
        }

    }
}
