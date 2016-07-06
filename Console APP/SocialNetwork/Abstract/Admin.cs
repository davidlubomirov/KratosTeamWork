using SocialNetwork.Contracts.AdminContracts;
using SocialNetwork.Enums;

namespace SocialNetwork.Abstract
{
    //TODO:ToFinishAbstractAdmin
    public abstract class Admin : IAdmin
    {
        private string name;
        private uint age;
        private Country fromCountry;
        private string specialUsername;
        private string specialPassword;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public uint Age
        {
            get { return age; }
            set { age = value; }
        }

        public Country FromCountry
        {
            get { return fromCountry; }
        }

        public virtual string SpecialUsername
        {
            get { return specialUsername; }
            set { specialUsername = value; }
        }

        public virtual string SpecialPassword
        {
            get { return specialPassword; }
            set { specialPassword = value; }
        }
    }
}