using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.Repositories
{
    using Entities;

    public interface IUserRepository: IRepository<User>
    {
        User GetByLogin(string login);
    }
}
