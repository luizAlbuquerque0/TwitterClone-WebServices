using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.Core.Entites;

namespace TwitterClone.Application.ViewModels
{
    public class PostDetailsViewModel
    {
        public PostDetailsViewModel(string content, string postOwner, List<PostComment> comments, string ownerProfilePic, int ownerId)
        {
            Content = content;
            PostOwner = postOwner;
            Comments = comments;
            OwnerProfilePic = ownerProfilePic;
            OwnerId = ownerId;
        }

        public string Content { get; private set; }
        public string PostOwner { get; private set; }
        public List<PostComment> Comments { get; private set; }
        public string  OwnerProfilePic { get; private set; }
        public int OwnerId { get; private set; }

    }
}
