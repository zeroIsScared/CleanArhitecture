using System;
using System.Collections.Generic;
using System.Linq;
using Ecomerce.Domain.Models;


namespace Ecomerce.Aplication.Abstractions
{
    public interface IUserRepository
    {
        User Create(User user);
        User GetById(int id);
        List<User> GetAll();
        int GetLastId();
    }
}
