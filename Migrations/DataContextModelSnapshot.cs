﻿// <auto-generated />
using System;
using EntertainmentApp.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace entertainment_app.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("EntertainmentApp.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Adult")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "adult");

                    b.Property<string>("BackdropPath")
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "backdrop_path");

                    b.Property<string>("OriginalLanguage")
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "original_language");

                    b.Property<string>("OriginalTitle")
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "original_title");

                    b.Property<string>("Overview")
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "overview");

                    b.Property<double>("Popularity")
                        .HasColumnType("REAL")
                        .HasAnnotation("Relational:JsonPropertyName", "popularity");

                    b.Property<string>("PosterPath")
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "poster_path");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "title");

                    b.Property<bool>("Video")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "video");

                    b.Property<double>("VoteAverage")
                        .HasColumnType("REAL")
                        .HasAnnotation("Relational:JsonPropertyName", "vote_average");

                    b.Property<int>("VoteCount")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "vote_count");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("EntertainmentApp.Models.TvShow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    b.Property<string>("BackdropPath")
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "backdrop_path");

                    b.Property<DateTime?>("FirstAirDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "name");

                    b.Property<string>("OriginCountry")
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "origin_country");

                    b.Property<string>("OriginalLanguage")
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "original_language");

                    b.Property<string>("OriginalName")
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "original_name");

                    b.Property<string>("Overview")
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "overview");

                    b.Property<double>("Popularity")
                        .HasColumnType("REAL")
                        .HasAnnotation("Relational:JsonPropertyName", "popularity");

                    b.Property<string>("PosterPath")
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "poster_path");

                    b.Property<double>("VoteAverage")
                        .HasColumnType("REAL")
                        .HasAnnotation("Relational:JsonPropertyName", "vote_average");

                    b.Property<int>("VoteCount")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "vote_count");

                    b.HasKey("Id");

                    b.ToTable("TvShows");
                });
#pragma warning restore 612, 618
        }
    }
}
