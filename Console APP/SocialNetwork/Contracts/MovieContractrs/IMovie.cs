using System.Collections.Generic;
using SocialNetwork.Abstract;
using SocialNetwork.Classes;
using SocialNetwork.Enums;

namespace SocialNetwork.Contracts.MovieContractrs
{
    public interface IMovie
    {
        string MovieName { get;  }
        MovieGenre MainMovieGenre { get; }
        IList<MovieGenre> SecondaryGenres { get; } //best to use Ilist so we can add or remove genres due to possible changes
        Country CountryMade { get; }
        MovieType MovieType { get; }
        IEnumerable<Actor> Actors { get; }
    }

 
}