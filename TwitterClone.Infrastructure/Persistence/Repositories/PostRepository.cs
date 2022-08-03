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
            var post = await _dbContext.Posts.SingleOrDefaultAsync(p => p.Id == id);

            var comments = await _dbContext.PostComments
                .Where(p => p.IdPost == post.Id)
                .Include(p => p.Post)
                .ToListAsync();
                
            post.AddComments(comments);

            return post;
        }

        public async Task<List<Post>> GetUserPostsAsync(int id)
        {
            var posts = await _dbContext.Posts
                .Where(p => p.IdPostOwner == id)
                .ToListAsync();

            if(posts == null) return null;

            return posts;
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
