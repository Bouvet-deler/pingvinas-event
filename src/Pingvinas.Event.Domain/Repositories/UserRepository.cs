namespace Pingvinas.Event.Core.Features.User;

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