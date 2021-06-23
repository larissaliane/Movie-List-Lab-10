using System;
using System.Collections.Generic;
using System.Linq;

namespace Movie_List_Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MovieTitles
            string continueFlag;

            Console.WriteLine("There are 4 categories in this list, please choose one (animated, drama, horror, scifi)");
            do
            {
                var animated = new Movies 
                {
                    Category = "animated", 
                    Title = "Coco", 
                  

                };
                var animated1 = new Movies 
                {
                    Category = "animated",
                    Title = "Toy Story", 
                    

                };
                var animated2 = new Movies 
                {
                    Category = "animated",
                    Title = "Spider Man", 


                };
                var drama = new Movies 
                {
                    Category = "drama",
                    Title = "Titanic",
                
                };
                var drama1 = new Movies 
                {
                    Category = "drama",
                    Title = "The Dark Knight",

                };
                var drama2 = new Movies 
                {
                    Category = "drama",
                    Title = "Black Panther",

                };
                var horror = new Movies 
                {
                    Category = "horror", 
                    Title = "The Shinning",
             
                };
                var horror1 = new Movies 
                {
                    Category = "horror", 
                    Title = "I am Legend",

                };

                var scifi = new Movies
                {
                    Category = "scifi",
                    Title = "Star Wars"
                };

                var scifi1 = new Movies
                {
                    Category = "scifi",
                    Title = "Back to the Future"
                };


                List<Movies> movies = new List<Movies> { };
                movies.Add(animated);
                movies.Add(animated1);
                movies.Add(animated2);
                movies.Add(drama);
                movies.Add(drama1);
                movies.Add(drama2);
                movies.Add(horror);
                movies.Add(horror1);
                movies.Add(scifi);
                movies.Add(scifi1);



                GetTitles(movies);


                #endregion
            continueFlag = GetUserInput("Do you want to continue (y/n)");
            
            } while (continueFlag == "y");
            
        }

        static string GetUserInput(string message)
        {
            string input;
            do
            {
                
                Console.WriteLine(message);
                
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Invalid input");
                }
                
            } while (string.IsNullOrWhiteSpace(input));
            return input;
        }

        public static void GetTitles(List<Movies> movies)
        {
            
            string input = GetUserInput("What category are you interested in?");
            
            var results = movies.Where(movie => movie.Category == input);
            
            foreach (var movie in results) 
            {
                Console.WriteLine($"{movie.Title}");
            }
           
        }
    
    }
}
