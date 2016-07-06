using System.Dynamic;
using SocialNetwork.Enums;

namespace SocialNetwork.Contracts.GeneralContracts
{
    public interface IHuman
    {
        string Name { get; set; }
        uint Age { get; set; }
        Country FromCountry { get; }
    }
}
    