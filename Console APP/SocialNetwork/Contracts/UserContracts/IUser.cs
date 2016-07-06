using SocialNetwork.Contracts.GeneralContracts;

namespace SocialNetwork.Contracts.UserContracts
{
    public interface IUser: IUserPersonalInfo, IRateActor, IRateMovie,IHuman
    {
        
    }
}