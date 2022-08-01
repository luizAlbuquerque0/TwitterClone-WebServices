using TwitterClone.Core.Entites;

namespace TwitterClone.Application.ViewModels
{
    public class PostViewModel
    {
        public PostViewModel(int id, string content, User postOwner, DateTime createdAt)
        {
            Id = id;
            Content = content;
            PostOwner = postOwner;
            CreatedAt = createdAt;
        }

        public int Id { get; private set; }
        public string Content { get; private set; }
        public User PostOwner { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}
