

using Ecomerce.Aplication.Abstractions;
using Ecomerce.Domain.Models;

namespace Ecomerce.Infrastructure
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> _users = new ();
        public User Create(User user)
        {
            _users.Add(user);
            return user;
        }

        public List<User> GetAll()
        {
            return _users;
        }

        public User GetById(int id)
        {
            return _users.FirstOrDefault(b => b.Id == id);
        }

        public int GetLastId()
        {
            if(_users.Count == 0) return 1;
            var lastId = _users.Max(b => b.Id);
            return lastId + 1;
        }
    }
}
