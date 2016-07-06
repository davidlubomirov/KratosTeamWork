using SocialNetwork.Abstract;
using SocialNetwork.Contracts.GeneralContracts;

namespace SocialNetwork.Contracts.AdminContracts
{
    public interface IAdmin:IHuman
    {
        string SpecialUsername { get; }
        string SpecialPassword { get;  }
    }

    
}