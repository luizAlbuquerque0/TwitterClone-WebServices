﻿using MediatR;
using TwitterClone.Application.ViewModels;

namespace TwitterClone.Application.Queries.GetPostById
{
    public class GetPostByIdQuery : IRequest<PostDetailsViewModel>
    {
        public GetPostByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
