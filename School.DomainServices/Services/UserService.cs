using System;
using System.Collections.Generic;
using System.Text;

namespace School.DomainServices.Services
{
    using Interfaces;
    using School.Domain.Entities;
    using School.Domain.Repositories;

    internal class UserService: IUserService
    {
        private readonly IUserRepository repository;

        public UserService(IUserRepository repository)
        {
            this.repository = repository;
        }

        public User GetByLogin(string login)
        {
            return repository.GetByLogin(login);
        }

        public IEnumerable<User> List()
        {
            return repository.List();
        }
    }
}
