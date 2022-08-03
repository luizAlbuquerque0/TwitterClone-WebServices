using MediatR;
using TwitterClone.Core.Repositories;

namespace TwitterClone.Application.Commands.DeletePost
{
    public class DeletePostCommandHandler : IRequestHandler<DeletePostCommand, Unit>
    {
        private readonly IPostRepository _postRepository;
        public DeletePostCommandHandler(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public async Task<Unit> Handle(DeletePostCommand request, CancellationToken cancellationToken)
        {
            await _postRepository.DeletePostAsync(request.Id);
            await _postRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
