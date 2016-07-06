using System.Collections.Generic;
using SocialNetwork.Contracts.MovieContractrs;
using SocialNetwork.Contracts.UserContracts;
using SocialNetwork.Enums;

namespace SocialNetwork.Abstract
{
    //TODO: to finish

    public abstract class User : Human, IUser, 
        IUserPersonalInfo, IRateActor, IRateMovie, IAddOrRemoveMovie 
        //not needed explicitly but just to be seen
    {
        private string email;
        private string password;
        private string username;
        private IList<MovieGenre> favouriteMovieGenres;
        private IList<MovieType> favouriteMovieTypes;
        private IList<IMovie> favouriteMovies;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public  void AddMovie()
        {
            throw new System.NotImplementedException();
        }

        public  void RemoveMovie()
        {
            throw new System.NotImplementedException();
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public IList<MovieGenre> FavouriteMovieGenres
        {
            get { return favouriteMovieGenres; }
            set { favouriteMovieGenres = value; }
        }

        public IList<MovieType> FavouriteMovieTypes
        {
            get { return favouriteMovieTypes; }
            set { favouriteMovieTypes = value; }
        }

        public IList<IMovie> FavouriteMovies
        {
            get { return favouriteMovies; }
            set { favouriteMovies = value; }
        }

        public virtual void RateActor()
            //TODO: Different users have differnetly based vote
            //more enhanced users have a stronger vote, therefore method is virtual so we can override it
        {
            throw new System.NotImplementedException();
        }

        public virtual void RateMovie()
        {
            throw new System.NotImplementedException();
        }
    }
}