namespace TwitterClone.Core.Entites
{
    public class PostComment : BaseEntity
    {
        public PostComment(string content, int idPost, int idCommentOwner)
        {
            Content = content;
            IdPost = idPost;
            IdCommentOwner = idCommentOwner;
        }

        public string Content { get; private set; }
        public int IdPost { get; private set; }
        public Post Post { get; private set; }
        public int IdCommentOwner { get; private set; }
        public User CommentOwner { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}
