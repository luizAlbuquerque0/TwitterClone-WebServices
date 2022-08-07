using MediatR;
using TwitterClone.Application.ViewModels;
using TwitterClone.Core.Repositories;

namespace TwitterClone.Application.Commands.UpdatePost
{
    public class UpdatePostCommandHandler : IRequestHandler<UpdatePostCommand, UpdatePostViewModel>
    {
        private readonly IPostRepository _postRepository;
        public UpdatePostCommandHandler(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public async Task<UpdatePostViewModel> Handle(UpdatePostCommand request, CancellationToken cancellationToken)
        {

            var post = await _postRepository.GetDetailsByIdAsync(request.Id);

            post.Update(request.Content);

            await _postRepository.SaveChangesAsync();

            return new UpdatePostViewModel(request.Content,request.Id);
        }
    }
}
