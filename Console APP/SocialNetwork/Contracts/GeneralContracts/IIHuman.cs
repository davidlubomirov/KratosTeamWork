using System.Dynamic;
using SocialNetwork.Enums;

namespace SocialNetwork.Contracts.GeneralContracts
{
    public interface IHuman
    {
        string Name { get;  }
        uint Age { get;  }
        Country FromCountry { get; }
    }
}
    