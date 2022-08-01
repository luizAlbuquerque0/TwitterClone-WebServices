using FluentValidation;
using TwitterClone.Application.Commands.CreateComment;

namespace TwitterClone.Application.Validators
{
    public class CreateCommentCommandValidator : AbstractValidator<CreateCommentCommand>
    {
        public CreateCommentCommandValidator()
        {
            RuleFor(p => p.Content)
                .NotEmpty()
                .NotNull()
                .WithMessage("O conteúdo é obrigatorio");

            RuleFor(p => p.IdPost)
                .NotEmpty()
                .NotNull()
                .WithMessage("O Id é obrigatorio");

            RuleFor(p => p.IdCommentOwner)
                .NotEmpty()
                .NotNull()
                .WithMessage("O Id do dono do comentario é obrigatorio");
        }
    }
}
