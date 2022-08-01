using MediatR;
using TwitterClone.Application.ViewModels;
using TwitterClone.Core.Repositories;

namespace TwitterClone.Application.Queries.GetAllPosts
{
    public class GetAllPostQueryHandler : IRequestHandler<GetAllPostQuery, List<PostViewModel>>
    {
        private readonly IPostRepository _postRepository;
        public GetAllPostQueryHandler(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public async Task<List<PostViewModel>> Handle(GetAllPostQuery request, CancellationToken cancellationToken)
        {
            var posts = await _postRepository.GetAllPostAsync();

            var projectsViewModel = posts.Select(p => new PostViewModel(p.Id, p.Content, p.PostOwner, p.CreatedAt)).ToList();

            return projectsViewModel;
        }
    }
}
