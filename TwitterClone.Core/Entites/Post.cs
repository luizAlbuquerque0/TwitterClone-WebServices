namespace TwitterClone.Core.Entites
{
    public class Post : BaseEntity
    {
        public Post(string content, int idPostOwner)
        {
            Content = content;
            IdPostOwner = idPostOwner;
            CreatedAt = DateTime.Now;
            Comments = new List<PostComment>();
        }

        public string Content { get; private set; }
        public int IdPostOwner { get; private set; }
        public User PostOwner { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public List<PostComment> Comments { get; private set; }

    }
}
