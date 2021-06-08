using System;
using System.Collections.Generic;

namespace MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>();
            Movie m1 = new Movie("Spirited Away", Genre.Animated);
            movies.Add(m1);

            Movie m2 = new Movie("my Neighbor Totoro", Genre.Animated);
            movies.Add(m2);

            Movie m3 = new Movie("Die Hard", Genre.Action);
            movies.Add(m3);

            Movie m4 = new Movie("Super Cop", Genre.Action);
            movies.Add(m4);

            Movie m5 = new Movie("Blade Runner", Genre.Scifi);
            movies.Add(m5);

            Movie m6 = new Movie("The Matrix", Genre.Scifi);
            movies.Add(m6);

            Movie m7 = new Movie("The VVitch", Genre.Horror);
            movies.Add(m7);

            Movie m8 = new Movie("The Thing", Genre.Horror);
            movies.Add(m8);

            Movie m9 = new Movie("Lost in Translation", Genre.Drama);
            movies.Add(m9);

            Movie m10 = new Movie("Leon: The Professional", Genre.Action);
            movies.Add(m10);

            while (true)
            {

                Genre[] trueGenres = (Genre[])Enum.GetValues(typeof(Genre));

                foreach (Genre g in trueGenres)
                {
                    Console.WriteLine(g);
                }

                Console.WriteLine("Please input a movie genre.");
                string input = Console.ReadLine();

                Genre inputGenre = (Genre)Enum.Parse(typeof(Genre), input);
                foreach (Movie m in movies)
                {
                        Console.WriteLine(m);
                    ////Movie m = movies[i];
                    //if (m.Genre == inputGenre)
                    //{
                    //        //if (m.Movie == inputGenre)
                    //    //{
                    //    //    Console.WriteLine(m.Title);
                    //    //}
                    //}

                    //Console.WriteLine("Would you like to pick another genre? y/n");
                    //string userResponse = Console.ReadLine();
                    //Console.ReadLine();
                    //if (userResponse == "y")
                    //{

                    //}
                    //else
                    //{
                    //    System.Environment.Exit(0);
                    //}
                }

            }
        }
    }
}
