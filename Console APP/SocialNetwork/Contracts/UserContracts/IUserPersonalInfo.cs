using System.Collections.Generic;
using SocialNetwork.Contracts.GeneralContracts;
using SocialNetwork.Contracts.MovieContractrs;
using SocialNetwork.Enums;

namespace SocialNetwork.Contracts.UserContracts
{
    public interface IUserPersonalInfo:IPersonalInfo, IAddOrRemoveMovie
        //TODO: users only
    {
        string Username { get;   } //could add validation for it as well
        IList<MovieGenre> FavouriteMovieGenres { get;  }
        IList<MovieType> FavouriteMovieTypes { get;  }
        IList<IMovie> FavouriteMovies { get;  }

    }
}