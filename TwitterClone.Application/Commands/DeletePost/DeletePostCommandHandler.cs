using MediatR;
using TwitterClone.Core.Repositories;

namespace TwitterClone.Application.Commands.DeletePost
{
    public class DeletePostCommandHandler : IRequestHandler<DeletePostCommand, int>
    {
        private readonly IPostRepository _postRepository;
        public DeletePostCommandHandler(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public async Task<int> Handle(DeletePostCommand request, CancellationToken cancellationToken)
        {
            await _postRepository.DeletePostAsync(request.Id);
            await _postRepository.SaveChangesAsync();

            return request.Id;
        }
    }
}
