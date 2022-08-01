﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using TwitterClone.Application.Commands.CreateComment;
using TwitterClone.Application.Commands.CreatePost;
using TwitterClone.Application.Queries.GetAllPosts;
using TwitterClone.Application.Queries.GetPostById;

namespace TwitterClone.API.Controllers
{
    [Route("api/posts")]
    public class PostController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PostController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPosts(string query)
        {
            var getPostQuery = new GetAllPostQuery(query);

            var posts = await _mediator.Send(getPostQuery);

            return Ok(posts);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetPostByIdQuery(id);

            var post = await _mediator.Send(query);

            if (post == null) return NotFound();

            return Ok(post);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePost([FromBody] CreatePostCommand command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }

        [HttpPost("{id}/comments")]
        public async Task<IActionResult> CreateComment([FromBody] CreateCommentCommand command)
        {
            await _mediator.Send(command);

            return NoContent();
        }
    }
}