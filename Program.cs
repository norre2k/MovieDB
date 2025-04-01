namespace MovieDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>();
            List<Actor> actors = new List<Actor>();
            actors.Add(new Actor("Tom Cruise", 1969));
            actors.Add(new Actor("Kevin Heart", 1979));

           
            movies.Add(new Comedy("Jumanji", 160, actors, 20));
            movies.Add(new Action("Top Gun", 175, actors, 400));
            movies.Add(new SciFi("Oblivion", 210, actors, 7));
            movies.Add(new SciFi("scooby", 75, actors, 13));
            movies.Add(new Comedy("King Kong", 140, actors, 2));

            
                foreach (Movie movie in movies)
                {
                if (movie is Comedy)
                {
                    movie.ShowMovieInfo();
                }
                else if (movie is Action)
                {
                    movie.ShowMovieInfo();
                }
                else if(movie is SciFi)
                {
                    movie.ShowMovieInfo();
                }
                    
                }
            
        }
    }
}
