using MediatR;

namespace TwitterClone.Application.Commands.UserUpdateProfile
{
    public class UpdateProfileCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
