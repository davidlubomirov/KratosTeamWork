using System;
using SocialNetwork.Contracts;
using SocialNetwork.Contracts.GeneralContracts;
using SocialNetwork.Enums;

namespace SocialNetwork.Abstract
{
    public abstract class Human : IHuman
    {
        private string name;
        private uint age;

        protected Human() { }
        protected Human(string name, uint age, Country fromCountry)
        {
            this.Name = name;
            this.Age = age;
            this.FromCountry = fromCountry;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Name cannot be null");
                }
                name = value;
            }
        }

        public uint Age
        {
            get { return age; }
            set
            {
                if (value>113) //TODO: Add to validationConstants

                {
                    throw new ArgumentOutOfRangeException("Cannot be more than 113, " +
                                                          "oldest person in the world is 113");
                }
                age = value;
            }
        }

        public Country FromCountry { get; }
    }
}