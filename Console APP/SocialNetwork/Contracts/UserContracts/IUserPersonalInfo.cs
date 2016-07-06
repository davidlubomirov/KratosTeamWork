using System.Collections.Generic;
using SocialNetwork.Contracts.GeneralContracts;
using SocialNetwork.Contracts.MovieContractrs;
using SocialNetwork.Enums;

namespace SocialNetwork.Contracts.UserContracts
{
    public interface IUserPersonalInfo:IPersonalInfo, IAddOrRemoveMovie
        //TODO: users only
    {
        string Username { get; set; } //could add validation for it as well
        IList<MovieGenre> FavouriteMovieGenres { get; set; }
        IList<MovieType> FavouriteMovieTypes { get; set; }
        IList<IMovie> FavouriteMovies { get; set; }

    }
}