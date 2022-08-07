using MediatR;
using TwitterClone.Application.ViewModels;

namespace TwitterClone.Application.Commands.UpdatePost
{
    public class UpdatePostCommand : IRequest<UpdatePostViewModel>
    {
        public int Id { get; set; }
        public string Content { get; set; }
    }
}
