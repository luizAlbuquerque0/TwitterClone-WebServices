using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.Core.Entites;

namespace TwitterClone.Application.Queries.GetPostById
{
    public class GetPostByIdQuery : IRequest<Post>
    {
        public GetPostByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
