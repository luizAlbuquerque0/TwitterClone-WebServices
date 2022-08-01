using MediatR;
using TwitterClone.Application.ViewModels;

namespace TwitterClone.Application.Queries.GetUser
{
    public class GetUserQuery : IRequest<UserViewModel>
    {
        public GetUserQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }

    }
}
