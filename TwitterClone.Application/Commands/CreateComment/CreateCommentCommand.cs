using MediatR;

namespace TwitterClone.Application.Commands.CreateComment
{
    public class CreateCommentCommand : IRequest<Unit>
    {
        public string Content { get;  set; }
        public int IdPost { get;  set; }
        public int IdCommentOwner { get;  set; }
    }
}
