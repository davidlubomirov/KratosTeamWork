using System.Collections.Generic;
using SocialNetwork.Contracts.GeneralContracts;
using SocialNetwork.Enums;

namespace SocialNetwork.Contracts.MovieContractrs
{
    public interface IActor:IHuman
    {
        MovieActorType ActorType { get; }
        int Rating { get; }
        IList<IMovie> StarredInMovies { get; }
    }
}