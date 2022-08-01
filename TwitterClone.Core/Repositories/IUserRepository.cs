using TwitterClone.Core.Entites;

namespace TwitterClone.Core.Repositories
{
    public interface IUserRepository
    {
        Task CreateUserAsync(User user);
        Task<User> GetUser(int id);
        Task<User> GetUserByEmailAndPasswordAsync(string email, string passwordHash);
        Task SaveChangesAsync();
    }
}
