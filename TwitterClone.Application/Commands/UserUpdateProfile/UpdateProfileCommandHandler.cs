using MediatR;
using TwitterClone.Application.ViewModels;
using TwitterClone.Core.Repositories;

namespace TwitterClone.Application.Commands.UserUpdateProfile
{
    public class UpdateProfileCommandHandler : IRequestHandler<UpdateProfileCommand, UserViewModel>
    {
        private readonly IUserRepository _userRepsoitory;
        public UpdateProfileCommandHandler(IUserRepository userRepository)
        {
            _userRepsoitory = userRepository;
        }
        public async Task<UserViewModel> Handle(UpdateProfileCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepsoitory.GetUser(request.Id);

            user.AddDescription(request.Description);
            user.AddBirthDate(request.BirthDate);
            user.AddHomeTown(request.HomeTown);
            user.AddProfilePic(request.ProfilePic);

            await _userRepsoitory.SaveChangesAsync();

            var userViewModel = new UserViewModel(user.FullName, user.Email, user.CreatedAt.ToString("d"), user.BirthDate, user.HomeTown, user.Description, user.Profilepic);

            return userViewModel;
        }
    }
}
