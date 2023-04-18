using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using EntertainmentApp.Models;
namespace EntertainmentApp.Helpers
{
    public static class DbInitializer
    {
        public static void Initialize(DataContext context)
        {
            context.Database.EnsureCreated();
            if (!context.Movies.Any())
            {
                SeedMoviesFromJsonFile(context);
            }
            if (!context.TvShows.Any())
            {
                SeedTvShowsFromJsonFile(context);
            }
        }
        private static void SeedMoviesFromJsonFile(DataContext context)
        {
            // Read the JSON file
            string jsonFilePath = "./movies.json";
            string jsonString = File.ReadAllText(jsonFilePath);
            var jsonObj = JsonSerializer.Deserialize<List<Movie>>(jsonString, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            Dictionary<int, Movie> moviesDict = new Dictionary<int, Movie>();
            foreach (var movie in jsonObj)
            {
                if (!moviesDict.ContainsKey(movie.Id))
                {
                    moviesDict[movie.Id] = movie;
                }
            }
            context.ChangeTracker.Clear();
            context.Movies.AddRange(moviesDict.Values);
            // Save the changes
            context.SaveChanges();
        }
        private static void SeedTvShowsFromJsonFile(DataContext context)
        {
            // Read the JSON file
            string jsonFilePath = "./tvShows.json";
            string jsonString = File.ReadAllText(jsonFilePath);
            var jsonObj = JsonSerializer.Deserialize<List<TvShow>>(jsonString, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            context.ChangeTracker.Clear();
            Dictionary<int, TvShow> tvShowsDict = new Dictionary<int, TvShow>();
            foreach (var tvShow in jsonObj)
            {
                if (!tvShowsDict.ContainsKey(tvShow.Id))
                {
                    tvShowsDict[tvShow.Id] = tvShow;
                }
            }
            context.TvShows.AddRange(tvShowsDict.Values);
            // Save the changes
            context.SaveChanges();
        }
    }
}