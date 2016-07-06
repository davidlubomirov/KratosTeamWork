namespace SocialNetwork.Contracts.GeneralContracts
{
    public interface IPersonalInfo:IHuman
    {
        string Email { get;  } //need to add validation for email
        string Password { get; } // need to add validation for password


    }
}