using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.Core.Entites;
using TwitterClone.Core.Repositories;

namespace TwitterClone.Application.Commands.CreatePost
{
    public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, int>
    {
        private readonly IPostRepository _postRepository;
        public CreatePostCommandHandler(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public async Task<int> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            var post = new Post(request.Content, request.IdOwner);

            await _postRepository.CreatePostAsync(post);

            await _postRepository.SaveChangesAsync();

            return post.Id;
        }
    }
}
