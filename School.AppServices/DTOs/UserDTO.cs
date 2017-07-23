using System;
using System.Collections.Generic;
using System.Text;

namespace School.AppServices.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }

    }
}
