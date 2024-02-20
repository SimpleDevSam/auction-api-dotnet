using RockSeatAuction.API.Entities;

namespace RockSeatAuction.API.Contracts;

public interface IUserRepository
{
    bool ExistUserWithEmail(string email);
    User GetUserByEmail(string email);
}
