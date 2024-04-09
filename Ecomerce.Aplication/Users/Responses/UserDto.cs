using Ecomerce.Domain.Models;

namespace Ecomerce.Aplication.Users.Responses
{
    public class UserDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public static UserDto FromUser(User user)
        {
            return new UserDto
            {
                Id = user.Id,
                Name = user.Name,
            };
        }
    }
}
