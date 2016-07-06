using System;
using System.Collections.Generic;
using SocialNetwork.Abstract;
using SocialNetwork.Contracts.MovieContractrs;
using SocialNetwork.Enums;

namespace SocialNetwork.Classes
{
    internal class Movie : IMovie
    {
        private string movieName;

        public Movie()
        {
        }

        public Movie(string movieName)
        {
            MovieName = movieName;
        }


        public Movie(string movieName, MovieGenre mainMovieGenre,
            Country countryMade, MovieType movieType, IEnumerable<Actor> actors) : this(movieName)
        {
            MainMovieGenre = mainMovieGenre;
            CountryMade = countryMade;
            MovieType = movieType;
            Actors = actors;
        }

        public Movie(string movieName, MovieGenre mainMovieGenre, IList<MovieGenre> secondaryGenres,
            Country countryMade, MovieType movieType, IEnumerable<Actor> actors)
            : this(movieName, mainMovieGenre, countryMade, movieType, actors)
        {
            SecondaryGenres = secondaryGenres;
        }

        public string MovieName
        {
            get { return movieName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException($"Movie has to have a name");
                    //TODO: possibly implement custom exception
                }
                movieName = value;
            }
        }

        public MovieGenre MainMovieGenre { get; }

        public IList<MovieGenre> SecondaryGenres { get; }

        public Country CountryMade { get; }

        public MovieType MovieType { get; }

        public IEnumerable<Actor> Actors { get; }
    }
}