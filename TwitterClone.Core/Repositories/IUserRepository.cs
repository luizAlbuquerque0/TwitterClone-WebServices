using TwitterClone.Core.Entites;

namespace TwitterClone.Core.Repositories
{
    public interface IUserRepository
    {
        Task CreateUserAsync(User user);

    }
}
