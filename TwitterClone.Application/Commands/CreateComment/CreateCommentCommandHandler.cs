using MediatR;
using TwitterClone.Core.Entites;
using TwitterClone.Core.Repositories;

namespace TwitterClone.Application.Commands.CreateComment
{
    public class CreateCommentCommandHandler : IRequestHandler<CreateCommentCommand, Unit>
    {
        private readonly IPostRepository _postRepository;
        public CreateCommentCommandHandler(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public async Task<Unit> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            var comment = new PostComment(request.Content, request.IdPost, request.IdCommentOwner);

            await _postRepository.AddCommentAsync(comment);

            await _postRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
