using System;
using System.Collections.Generic;
using System.Text;
using School.Domain.Entities;
using School.Domain.Repositories;
using Microsoft.Extensions.Configuration;
using Dapper;

namespace School.Data.Repositories
{
    internal class UserRepository: RepositoryBase, IUserRepository
    {
        public UserRepository(IConfigurationRoot configuration) : base(configuration)
        {
        }

        public User GetByLogin(string login)
        {
            var result = Connection.QueryFirstOrDefault<User>("exec p_school_user_getbylogin @login", new { login = login });
            return result;
        }

        public IEnumerable<User> List()
        {
            var result = Connection.Query<User>("exec p_school_user_list");

            return result;
        }
    }
}
