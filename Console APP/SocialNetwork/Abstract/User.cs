using System;
using System.Collections.Generic;
using SocialNetwork.Contracts.MovieContractrs;
using SocialNetwork.Contracts.UserContracts;
using SocialNetwork.Enums;
using SocialNetwork.Utils;

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

        public string Email
        {
            get { return email; }
           protected set {
              var validated = new ValidateEmail();
               if (!validated.IsValidEmail(value))
               {
                   Console.WriteLine("Email is not in the valid format. Try again!");
               }
               email = value; }
        }

        public string Password
        {
            get { return password; }
            protected set
            {
               var validated = new ValidatePass();
                if (!validated.ValidatePassword(value))
                {
                    Console.WriteLine("Password is is not in the correct format!");
                    Console.WriteLine("At least one lower case letter," +
                                      "\r\n At least one upper case letter," +
                                      "\r\n At least special character," +
                                      "\r\n At least one number" +
                                      "\r\n At least 8 characters length!");
                }
               
                password = value; }
        }

        public string Username
        {
            get { return username; }
            protected set
            {
                var validated = new ValidateUsername();
                if (!validated.ValidateUser(value))
                {
                    Console.WriteLine("Username is not in the correct format.");
                    Console.WriteLine("Username has to have at least one upper and one lower case!");
                }
                username = value;
            }
        }

        public IList<MovieGenre> FavouriteMovieGenres { get; }

        public IList<MovieType> FavouriteMovieTypes { get; }

        public IList<IMovie> FavouriteMovies { get; }

        public  void AddMovie()
        {
            throw new System.NotImplementedException();
        }

        public  void RemoveMovie()
        {
            throw new System.NotImplementedException();
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