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
        public PostDetailsViewModel(string content, User postOwner, List<PostComment> comments)
        {
            Content = content;
            PostOwner = postOwner;
            Comments = comments;
        }

        public string Content { get; private set; }
        public User PostOwner { get; private set; }
        public List<PostComment> Comments { get; private set; }

    }
}
