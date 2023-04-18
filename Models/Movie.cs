using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace EntertainmentApp.Models;
public class Movie
{
    public int Id { get; set; }
    [JsonPropertyName("adult")]
    public bool Adult { get; set; }
    [JsonPropertyName("backdrop_path")]
    public string? BackdropPath { get; set; }
    [JsonPropertyName("original_language")]
    public string? OriginalLanguage { get; set; }
    [JsonPropertyName("original_title")]
    public string? OriginalTitle { get; set; }
    [JsonPropertyName("overview")]
    public string? Overview { get; set; }
    [JsonPropertyName("popularity")]
    public double Popularity { get; set; }
    [JsonPropertyName("poster_path")]
    public string? PosterPath { get; set; }
    public DateTime? ReleaseDate { get; set; }
    [JsonPropertyName("title")]
    public string? Title { get; set; }
    [JsonPropertyName("video")]
    public bool Video { get; set; }
    [JsonPropertyName("vote_average")]
    public double VoteAverage { get; set; }
    [JsonPropertyName("vote_count")]
    public int VoteCount { get; set; }
}