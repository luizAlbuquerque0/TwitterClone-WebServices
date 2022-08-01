using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Application.Commands.CreatePost
{
    public class CreatePostCommand : IRequest<int>
    {
        public string Content { get;  set; }
        public int IdOwner { get;  set; }
    }
}
