namespace Pingvinas.Event.Core.Features.User;

public interface IUserRepository
{
    /// <summary>
    /// Lets a user see his/her own user details.
    /// User id is collected from claims.
    /// </summary>
    /// <returns>User details.</returns>
    Task<User> GetOwnDetails();

    /// <summary>
    /// Add a new user to the system.
    /// This should only be available for system administrators.
    /// </summary>
    /// <param name="user">User details.</param>
    /// <returns>A success flag.</returns>
    Task<bool> CreateUser(User user);

    /// <summary>
    /// Update a user in the system.
    /// This should only be available for system administrators and the user itself.
    /// </summary>
    /// <param name="user">User details.</param>
    /// <returns>A success flag.</returns>
    Task<bool> UpdateUser(User user);

    /// <summary>
    /// Marks a user as deactivated.
    /// This should only be available for system administrators.
    /// </summary>
    /// <param name="userId">The id of the user that will be deactivated.</param>
    /// <returns>A success flag.</returns>
    Task<bool> DeactivateUser(string userId);
}