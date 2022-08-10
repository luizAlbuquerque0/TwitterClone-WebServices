using MediatR;
using TwitterClone.Application.ViewModels;

namespace TwitterClone.Application.Commands.UserUpdateProfile
{
    public class UpdateProfileCommand : IRequest<UserViewModel>
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string BirthDate { get; set; }
        public string HomeTown { get; set; }
        public string ProfilePic { get; set; }
    }
}
