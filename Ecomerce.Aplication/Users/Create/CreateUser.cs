
using Ecomerce.Aplication.Abstractions;
using Ecomerce.Aplication.Users.Responses;
using Ecomerce.Domain.Models;
using MediatR;

namespace Ecomerce.Aplication.Users.Create;
    public record CreateUser(string Name) : IRequest<UserDto>
{
    public class CreateUserHandler : IRequestHandler<CreateUser, UserDto>
    {
        public readonly IUserRepository _userRepository;
        public CreateUserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<UserDto> Handle(CreateUser request, CancellationToken cancellationToken)
        {
            var user = new User() { Name = request.Name, Id = GetNextId() };
            var createdUser = _userRepository.Create(user);
            return Task.FromResult(UserDto.FromUser(createdUser));
        }

        private int GetNextId()
        {
            return _userRepository.GetLastId();
        }
    }
}
