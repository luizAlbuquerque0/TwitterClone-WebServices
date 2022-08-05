using MediatR;
using TwitterClone.Application.ViewModels;
using TwitterClone.Core.Repositories;

namespace TwitterClone.Application.Queries.GetUserPosts
{
    public class GetUserPostsQueryHandler : IRequestHandler<GetUserPostsQuery, List<PostViewModel>>
    {
        private readonly IPostRepository _postRepository;
        public GetUserPostsQueryHandler(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public async Task<List<PostViewModel>> Handle(GetUserPostsQuery request, CancellationToken cancellationToken)
        {
            var posts = await _postRepository.GetUserPostsAsync(request.Id);

            var postViewModel = posts.Select(p => new PostViewModel(p.Id, p.Content, p.OwnerName, p.CreatedAt.ToString("d"))).ToList();

            return postViewModel;
        }
    }
}
