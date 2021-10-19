using System;
using System.Collections.Generic;
using System.Text;

namespace MovieList
{
    class MoviesDB
    {
        //1) setup a for loop going through the movie list 
        //2) if statement in the loop, check if currentmovie.Category == "horror", 
        //   print the movie title 
        //    if no, skip the current movie

        public List<Movies> Movie { get; set; } = new List<Movies>();

        public MoviesDB()
        {
            Movie.Add(new Movies("Star Wars", "Scifi"));
            Movie.Add(new Movies("Coach Carter", "Sports"));
            Movie.Add(new Movies("Billy Madison", "Comedy"));
            Movie.Add(new Movies("Yes Man", "Comedy"));
            Movie.Add(new Movies("Harry Potter", "Scifi"));
            Movie.Add(new Movies("Hitch", "Romantic Comedy"));
            Movie.Add(new Movies("Grown Ups", "Comedy"));
            Movie.Add(new Movies("Conjuring", "Horror"));
            Movie.Add(new Movies("Remeber the Titans", "Sports"));
            Movie.Add(new Movies("Serious Case of Benjaminin Button", "Drama"));

        }

        public void PrintMovie()
        {
            for (int i = 0; i < Movie.Count; i++)
            {
                Movies t = Movie[i];
                Console.WriteLine($"{i}: {t.Title}");
                Console.WriteLine($"{i}: {t.Category}");
            }
        }

        public void SearchCategory(List<Movies> Movie, string name)
        {

            for (int i = 0; i < Movie.Count; i++)
            {
                Movies ms = Movie[i];

                if (ms.Category.ToLower() == name.ToLower())
                {
                    Console.WriteLine(ms.Title);
                }
            }

        }

        public string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();

            return input;
        }

        

    }
}

