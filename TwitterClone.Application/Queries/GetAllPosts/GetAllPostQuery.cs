using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.Core.Entites;
using TwitterClone.Core.Repositories;

namespace TwitterClone.Application.Queries.GetAllPosts
{
    public class GetAllPostQuery : IRequest<List<Post>>
    {
    }
}
