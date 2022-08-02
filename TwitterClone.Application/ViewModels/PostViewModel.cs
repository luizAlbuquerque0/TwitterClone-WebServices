using TwitterClone.Core.Entites;

namespace TwitterClone.Application.ViewModels
{
    public class PostViewModel
    {
        public PostViewModel(int id, string content, string ownerName, DateTime createdAt)
        {
            Id = id;
            Content = content;
            OwnerName = ownerName;
            CreatedAt = createdAt;
        }

        public int Id { get; private set; }
        public string Content { get; private set; }
        public string OwnerName { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}
