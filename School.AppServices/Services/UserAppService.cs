using System;
using System.Collections.Generic;
using System.Text;
using School.DomainServices.Interfaces;

namespace School.AppServices.Services
{
    using Interfaces;
    using DTOs;
    using Extensions;

    internal class UserAppService : IUserAppService
    {
        private readonly IUserService service;

        public UserAppService(IUserService service)
        {
            this.service = service;
        }
        public UserDTO GetByLogin(string login)
        {
            return service.GetByLogin(login).MapTo<UserDTO>();
        }

        public IEnumerable<UserDTO> List()
        {
            return service.List().EnumerableTo<UserDTO>();
        }
    }
}
