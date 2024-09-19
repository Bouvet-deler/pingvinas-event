using Pingvinas.Event.Domain.Models;

namespace Pingvinas.Event.Domain.Repositories;

public class UserRepository :IUserRepository
{
    public Task<User> GetOwnDetails()
    {
        throw new NotImplementedException();
    }

    public Task<bool> CreateUser(User user)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateUser(User user)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeactivateUser(string userId)
    {
        throw new NotImplementedException();
    }
}