using MediatR;
using TwitterClone.Application.ViewModels;

namespace TwitterClone.Application.Queries.GetAllPosts
{
    public class GetAllPostQuery : IRequest<List<PostViewModel>>
    {
    }
}
