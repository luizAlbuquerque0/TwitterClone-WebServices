using MediatR;
using TwitterClone.Core.Repositories;

namespace TwitterClone.Application.Commands.UserUpdateProfile
{
    public class UpdateProfileCommandHandler : IRequestHandler<UpdateProfileCommand, Unit>
    {
        private readonly IUserRepository _userRepsoitory;
        public UpdateProfileCommandHandler(IUserRepository userRepository)
        {
            _userRepsoitory = userRepository;
        }
        public async Task<Unit> Handle(UpdateProfileCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepsoitory.GetUser(request.Id);

            user.AddDescription(request.Description);
            user.AddBirthDate(request.BirthDate);
            user.AddHomeTown(request.HomeTown);

            await _userRepsoitory.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
