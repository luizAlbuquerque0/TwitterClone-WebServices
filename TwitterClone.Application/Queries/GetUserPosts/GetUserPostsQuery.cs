using MediatR;
using TwitterClone.Application.ViewModels;

namespace TwitterClone.Application.Queries.GetUserPosts
{
    public class GetUserPostsQuery : IRequest<List<PostViewModel>>
    {
        public GetUserPostsQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
