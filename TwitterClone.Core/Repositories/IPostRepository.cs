using TwitterClone.Core.Entites;

namespace TwitterClone.Core.Repositories
{
    public interface IPostRepository
    {
        Task CreatePostAsync(Post post);
        Task AddCommentAsync(PostComment postComment);
        Task<List<Post>> GetAllPostAsync();
        Task<Post> GetDetailsByIdAsync(int id);
    }
}
