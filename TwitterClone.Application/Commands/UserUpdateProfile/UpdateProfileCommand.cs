using MediatR;

namespace TwitterClone.Application.Commands.UserUpdateProfile
{
    public class UpdateProfileCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string BirthDate { get; set; }
        public string HomeTown { get; set; }
    }
}
