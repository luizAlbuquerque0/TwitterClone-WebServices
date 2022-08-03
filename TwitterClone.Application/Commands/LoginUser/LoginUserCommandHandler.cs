using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.Application.ViewModels;
using TwitterClone.Core.Repositories;
using TwitterClone.Core.Services;

namespace TwitterClone.Application.Commands.LoginUser
{
    public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, LoginUserViewModel>
    {
        private readonly IAuthService _authService;
        private readonly IUserRepository _userRepository;
        public LoginUserCommandHandler(IAuthService authService, IUserRepository userRepository)
        {
            _authService = authService;
            _userRepository = userRepository;
        }
        public async Task<LoginUserViewModel> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            var passwordHash = _authService.ComputeSha256Hash(request.Password);

            var user = await _userRepository.GetUserByEmailAndPasswordAsync(request.Email, passwordHash);

            if(user == null) return null;

            var token = _authService.GenereteJwtToken(user.Email);

            return new LoginUserViewModel(user.Email, token, user.Id);

            
        }
    }
}
