using System;

namespace MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;

            while (goOn == true)
            {

                MoviesDB movieDB = new MoviesDB();

                Console.WriteLine("Welcome to the Movie List Application!");
                Console.WriteLine();
                Console.WriteLine("There are 10 movies in this List");

                string category = movieDB.GetUserInput("What category are you interested in?");

                movieDB.SearchCategory(movieDB.Movie, category);

                Console.WriteLine("Continue? (y/n)");


                string name1 = Console.ReadLine();

                if (name1 == "Y" || name1 == "y")
                {
                    goOn = true;
                }
                else 
                {
                    goOn = false;
                    Console.WriteLine($"Bye!");
                    continue;
                }


            }
 

        }


    }


    }

