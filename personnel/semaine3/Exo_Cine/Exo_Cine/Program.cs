using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

public class Movie {

    public string Title{ get; set; }
    public string Genre{ get; set; }
    public double Rating{ get; set; }
    public int Year { get; set; }
    public string[] LanguageOptions { get; set; }
    public string[] StreamingPlatforms { get; set; }
    public Movie() { }

    public override string ToString()
    {
        return Title;
    }
}

internal class Program
{
    static List<Movie> frenchMovies = new List<Movie>() {
    new Movie() { Title = "Le fabuleux destin d'Amélie Poulain", Genre = "Comédie", Rating = 8.3, Year = 2001, LanguageOptions = new string[] {"Français", "English"}, StreamingPlatforms = new string[] {"Netflix", "Hulu"} },
    new Movie() { Title = "Intouchables", Genre = "Comédie", Rating = 8.5, Year = 2011, LanguageOptions = new string[] {"Français"}, StreamingPlatforms = new string[] {"Netflix", "Amazon"} },
    new Movie() { Title = "The Matrix", Genre = "Science-Fiction", Rating = 8.7, Year = 1999, LanguageOptions = new string[] {"English", "Español"}, StreamingPlatforms = new string[] {"Hulu", "Amazon"} },
    new Movie() { Title = "La Vie est belle", Genre = "Drame", Rating = 8.6, Year = 1946, LanguageOptions = new string[] {"Français", "Italiano"}, StreamingPlatforms = new string[] {"Netflix"} },
    new Movie() { Title = "Gran Torino", Genre = "Drame", Rating = 8.2, Year = 2008, LanguageOptions = new string[] {"English"}, StreamingPlatforms = new string[] {"Hulu"} },
    new Movie() { Title = "La Haine", Genre = "Drame", Rating = 8.1, Year = 1995, LanguageOptions = new string[] {"Français"}, StreamingPlatforms = new string[] {"Netflix"} },
    new Movie() { Title = "Oldboy", Genre = "Thriller", Rating = 8.4, Year = 2003, LanguageOptions = new string[] {"Coréen", "English"}, StreamingPlatforms = new string[] {"Amazon"} },
    new Movie() { Title = "Blade Runner", Genre = "Science-Fiction", Rating = 6.9, Year = 1982, LanguageOptions = new string[] {"English", "Español"}, StreamingPlatforms = new string[] {"Hulu", "Amazon"}
    } };
    static void Main(string[] args) 
    {
        //// exo 1
        //List<Movie> movies1 = frenchMovies.Where(x => (x.Genre != "Comédie" && x.Genre != "Drame")).ToList();
        //movies1.ForEach(Console.WriteLine);


        //// exo 2
        //List<Movie> movies2 = frenchMovies.Where(x => (x.Rating < 7)).ToList();
        //movies2.ForEach(Console.WriteLine);


        //// exo 3
        //List<Movie> movies3 = frenchMovies.Where(x => (x.Year < 2000)).ToList();
        //movies3.ForEach(Console.WriteLine);


        //// exo 4
        //List<Movie> movies4 = frenchMovies.Where(x => x.LanguageOptions.All(x => x is not "Français")).ToList();
        //movies4.ForEach(Console.WriteLine);


        //// exo 5 
        //List<Movie> movies5 = frenchMovies.Where(x => x.StreamingPlatforms.All(x => x is not "Netflix")).ToList();
        //movies5.ForEach(Console.WriteLine);


        // exo 6
        //List<Movie> movies6 = new List<Movie> { };
        //    movies6 = frenchMovies.Where(x => 
        //    (x.Genre != "Comédie" && x.Genre != "Drame") && 
        //    (x.Rating < 7 && x.Year < 2000) && 
        //    (x.LanguageOptions.All(x => x is not "Français")) &&
        //    (x.StreamingPlatforms.All(x => x is not "Netflix"))
        //    ).ToList();

        //movies6.ForEach(Console.WriteLine);

        
    }
}
