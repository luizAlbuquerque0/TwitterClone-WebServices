using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Core.Entites
{
    public class PostComment : BaseEntity
    {
        public PostComment(string content, int idPost, int idCommentOwener)
        {
            Content = content;
            IdPost = idPost;
            IdCommentOwner = idCommentOwener;
        }

        public string Content { get; private set; }
        public int IdPost { get; private set; }
        public Post Post { get; private set; }
        public int IdCommentOwner { get; private set; }
        public User CommentOwner { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}
