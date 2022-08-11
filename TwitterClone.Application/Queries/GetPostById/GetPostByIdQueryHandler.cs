using MediatR;
using TwitterClone.Application.ViewModels;
using TwitterClone.Core.Repositories;

namespace TwitterClone.Application.Queries.GetPostById
{
    public class GetPostByIdQueryHandler : IRequestHandler<GetPostByIdQuery, PostDetailsViewModel>
    {
        private readonly IPostRepository _postRepository;
        public GetPostByIdQueryHandler(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public async Task<PostDetailsViewModel> Handle(GetPostByIdQuery request, CancellationToken cancellationToken)
        {
            var post = await _postRepository.GetDetailsByIdAsync(request.Id);

            if(post == null) return null;

            var postViewModel = new PostDetailsViewModel(post.Content,post.OwnerName , post.Comments,post.OwnerProfilePic,post.IdPostOwner);

            return postViewModel;
        }
    }
}
