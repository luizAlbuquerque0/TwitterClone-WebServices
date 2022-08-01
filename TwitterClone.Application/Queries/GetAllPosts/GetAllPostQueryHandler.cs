using MediatR;
using TwitterClone.Core.Entites;
using TwitterClone.Core.Repositories;

namespace TwitterClone.Application.Queries.GetAllPosts
{
    public class GetAllPostQueryHandler : IRequestHandler<GetAllPostQuery, List<Post>>
    {
        private readonly IPostRepository _postRepository;
        public GetAllPostQueryHandler(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public async Task<List<Post>> Handle(GetAllPostQuery request, CancellationToken cancellationToken)
        {
            var posts = await _postRepository.GetAllAsync();

            //ViewModel
        }
    }
}
