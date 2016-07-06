namespace SocialNetwork.Contracts.UserContracts
{
    public interface IAddOrRemoveMovie
        //TODO: can be used both for actors and users
    {
        void AddMovie();
        void RemoveMovie();
    }
}