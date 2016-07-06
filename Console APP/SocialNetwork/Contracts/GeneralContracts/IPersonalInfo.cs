namespace SocialNetwork.Contracts.GeneralContracts
{
    public interface IPersonalInfo:IHuman
    {
        string Email { get; set; } //need to add validation for email
        string Password { get; set; } // need to add validation for password


    }
}