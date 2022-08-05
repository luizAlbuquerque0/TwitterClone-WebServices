using MediatR;
using TwitterClone.Application.ViewModels;
using TwitterClone.Core.Entites;
using TwitterClone.Core.Repositories;

namespace TwitterClone.Application.Commands.CreatePost
{
    public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, PostViewModel>
    {
        private readonly IPostRepository _postRepository;
        public CreatePostCommandHandler(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public async Task<PostViewModel> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            var post = new Post(request.Content, request.IdOwner, request.OwnerName);

            await _postRepository.CreatePostAsync(post);

            await _postRepository.SaveChangesAsync();


            return new PostViewModel(post.Id, post.Content, post.OwnerName, post.CreatedAt.ToString("p"));
        }
    }
}
