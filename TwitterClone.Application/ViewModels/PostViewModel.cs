using TwitterClone.Core.Entites;

namespace TwitterClone.Application.ViewModels
{
    public class PostViewModel
    {
        public PostViewModel(int id, string content, string ownerName, string createdAt)
        {
            Id = id;
            Content = content;
            OwnerName = ownerName;
            CreatedAt = createdAt;
        }

        public int Id { get; private set; }
        public string Content { get; private set; }
        public string OwnerName { get; private set; }
        public string CreatedAt { get; private set; }
    }
}
