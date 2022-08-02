using MediatR;

namespace TwitterClone.Application.Commands.UpdatePost
{
    public class UpdatePostCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string Content { get; set; }
    }
}
