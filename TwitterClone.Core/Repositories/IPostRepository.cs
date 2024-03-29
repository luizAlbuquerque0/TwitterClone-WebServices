﻿using TwitterClone.Core.Entites;

namespace TwitterClone.Core.Repositories
{
    public interface IPostRepository
    {
        Task CreatePostAsync(Post post);
        Task AddCommentAsync(PostComment postComment);
        Task<List<Post>> GetAllPostAsync();
        Task<Post> GetDetailsByIdAsync(int id);
        Task<List<Post>> GetUserPostsAsync(int id);
        Task DeletePostAsync(int id);
        Task SaveChangesAsync();
    }
}
