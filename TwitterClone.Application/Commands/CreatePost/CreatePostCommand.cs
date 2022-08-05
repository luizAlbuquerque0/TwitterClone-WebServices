using MediatR;
using TwitterClone.Application.ViewModels;

namespace TwitterClone.Application.Commands.CreatePost
{
    public class CreatePostCommand : IRequest<PostViewModel>
    {
        public string Content { get;  set; }
        public int IdOwner { get;  set; }
        public string OwnerName { get; set; }
    }
}
