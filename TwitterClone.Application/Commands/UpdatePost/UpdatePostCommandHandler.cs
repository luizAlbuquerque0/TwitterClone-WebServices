using MediatR;
using TwitterClone.Core.Repositories;

namespace TwitterClone.Application.Commands.UpdatePost
{
    public class UpdatePostCommandHandler : IRequestHandler<UpdatePostCommand, Unit>
    {
        private readonly IPostRepository _postRepository;
        public UpdatePostCommandHandler(IPostRepository projectRepository)
        {
            _postRepository = _postRepository;
        }
        public async Task<Unit> Handle(UpdatePostCommand request, CancellationToken cancellationToken)
        {

            var post = await _postRepository.GetDetailsByIdAsync(request.Id);

            post.Update(request.Content);

            await _postRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
