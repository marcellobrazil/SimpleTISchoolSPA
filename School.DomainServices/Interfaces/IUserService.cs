using School.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.DomainServices.Interfaces
{
    public interface IUserService
    {
        User GetByLogin(string login);
        IEnumerable<User> List();

    }
}
