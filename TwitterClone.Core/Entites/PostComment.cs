using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Core.Entites
{
    public class PostComment : BaseEntity
    {
        public string Content { get; private set; }
        public int IdPost { get; private set; }
        public int IdCommentOwner { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}
