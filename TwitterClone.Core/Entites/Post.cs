namespace TwitterClone.Core.Entites
{
    public class Post : BaseEntity
    {
        public Post(string content, int idPostOwner, string ownerName, string ownerProfilePic)
        {
            Content = content;
            IdPostOwner = idPostOwner;
            CreatedAt = DateTime.Now;
            Comments = new List<PostComment>();
            OwnerName = ownerName;
            OwnerProfilePic = ownerProfilePic;
        }

        public string Content { get; private set; }
        public int IdPostOwner { get; private set; }
        public string OwnerName { get; private set; }
        public string  OwnerProfilePic { get; private set; }
        public User PostOwner { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public List<PostComment> Comments { get; private set; }

        public void Update(string content)
        {
            Content = content;
        }

        public void AddComments(List<PostComment> comments)
        {
            Comments = comments;
        }
    }
}
