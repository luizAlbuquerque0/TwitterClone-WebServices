using MediatR;

namespace TwitterClone.Application.Commands.CreateComment
{
    public class CreateCommentCommand : IRequest<Unit>
    {
        public string Content { get; private set; }
        public int IdPost { get; private set; }
        public int IdCommentOwner { get; private set; }
    }
}
