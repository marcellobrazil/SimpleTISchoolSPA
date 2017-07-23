using System;
using System.Collections.Generic;
using System.Text;

namespace School.AppServices.Interfaces
{
    using DTOs;

    public interface IUserAppService
    {
        UserDTO GetByLogin(string login);
        IEnumerable<UserDTO> List();
    }
}
