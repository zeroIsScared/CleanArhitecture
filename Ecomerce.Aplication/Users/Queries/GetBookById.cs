

using Ecomerce.Aplication.Abstractions;
using Ecomerce.Aplication.Users.Responses;
using MediatR;

namespace Ecomerce.Aplication.Users.Queries;
public record GetUserById(int userId) : IRequest<UserDto>;

public class GetUserByIdHandler : IRequestHandler<GetUserById, UserDto>
{
    private readonly IUserRepository _userRepository;

    public GetUserByIdHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public Task<UserDto> Handle(GetUserById request, CancellationToken cancellationToken)
    {
        var user = _userRepository.GetById(request.userId);
        if (user == null)
        {
            throw new ApplicationException("User not found");
        }
        return Task.FromResult(UserDto.FromUser(user));
    }
}

