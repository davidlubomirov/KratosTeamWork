using System.Collections.Generic;
using SocialNetwork.Abstract;
using SocialNetwork.Contracts.MovieContractrs;

namespace SocialNetwork.Classes
{
    public class Director:Human
        //TODO: To extend
    {
        public Director(IList<IMovie> moviesDirected)
        {
            MoviesDirected = moviesDirected;
        }

        public IList<IMovie> MoviesDirected { get; }
    }
}