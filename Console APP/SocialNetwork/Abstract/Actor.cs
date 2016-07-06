using System.Collections.Generic;
using SocialNetwork.Contracts.MovieContractrs;
using SocialNetwork.Enums;

namespace SocialNetwork.Abstract
{
    public abstract class Actor : Human, IActor
    {
        protected Actor()
        {
        }

        protected Actor(string name, uint age, Country fromCountry, int rating = 0) :
            base(name, age, fromCountry)
        {
            Rating = rating;
        }

        //TODO: check on one actor can be different types in different movies
        protected Actor(string name, uint age, Country fromCountry, IList<IMovie> starredInMovies, int rating,
            MovieActorType actorType)
            : this(name, age, fromCountry, rating)

        {
            ActorType = actorType;
            StarredInMovies = starredInMovies;
        }

        public IList<IMovie> StarredInMovies { get; }

        public int Rating { get; }
        //Can be between 0 and 10, initial is always 0 
        // Make it changeable by users based on average
        //TODO: Implement Custom Exception


        public MovieActorType ActorType { get; }
    }
}