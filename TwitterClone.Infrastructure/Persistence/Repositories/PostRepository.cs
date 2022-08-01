using Microsoft.EntityFrameworkCore;
using TwitterClone.Core.Entites;
using TwitterClone.Core.Repositories;

namespace TwitterClone.Infrastructure.Persistence.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly TwitterCloneDbContext _dbContext;
        public PostRepository(TwitterCloneDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddCommentAsync(PostComment postComment)
        {
            await _dbContext.PostComments.AddAsync(postComment);
            await _dbContext.SaveChangesAsync();
        }

        public async Task CreatePostAsync(Post post)
        {
            await _dbContext.Posts.AddAsync(post);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Post>> GetAllPostAsync()
        {
            return await _dbContext.Posts.ToListAsync();
        }

        public async Task<Post> GetDetailsByIdAsync(int id)
        {
            return await _dbContext.Posts.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
