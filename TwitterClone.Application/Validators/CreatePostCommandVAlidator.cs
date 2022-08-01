using FluentValidation;
using TwitterClone.Application.Commands.CreatePost;

namespace TwitterClone.Application.Validators
{
    internal class CreatePostCommandVAlidator : AbstractValidator<CreatePostCommand>
    {
        public CreatePostCommandVAlidator()
        {
            RuleFor(p => p.Content)
               .NotEmpty()
               .NotNull()
               .WithMessage("O conteúdo é obrigatorio");

            RuleFor(p => p.IdOwner)
               .NotEmpty()
               .NotNull()
               .WithMessage("O id é obrigatorio");
        }
    }
}
