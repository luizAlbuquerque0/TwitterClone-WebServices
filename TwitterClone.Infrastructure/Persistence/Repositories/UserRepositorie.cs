using Microsoft.EntityFrameworkCore;
using TwitterClone.Core.Entites;
using TwitterClone.Core.Repositories;

namespace TwitterClone.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly TwitterCloneDbContext _dbContext;
        public UserRepository(TwitterCloneDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task CreateUserAsync(User user)
        {
            await _dbContext.Users.AddAsync(user);
        }

        public async Task<User> GetUser(int id)
        {
            return await _dbContext.Users.SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<User> GetUserByEmailAndPasswordAsync(string email, string passwordHash)
        {
            return await _dbContext.Users.SingleOrDefaultAsync(u => u.Email == email && u.Password == passwordHash);
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
