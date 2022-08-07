using MediatR;

namespace TwitterClone.Application.Commands.DeletePost
{
    public class DeletePostCommand : IRequest<int>
    {
        public DeletePostCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
