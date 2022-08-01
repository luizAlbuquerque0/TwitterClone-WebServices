using MediatR;
using TwitterClone.Core.Entites;
using TwitterClone.Core.Repositories;

namespace TwitterClone.Application.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly IUserRepository _useRepository;
        public CreateUserCommandHandler(IUserRepository userRepository)
        {
            _useRepository = userRepository;
        }
        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User(request.FullName, request.Email, request.Password);

            await _useRepository.CreateUserAsync(user);

            return user.Id;
        }
    }
}
