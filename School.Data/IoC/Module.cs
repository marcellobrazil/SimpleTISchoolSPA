using System;
using System.Collections.Generic;
using System.Text;

namespace School.Data.IoC
{
    using School.Data.Repositories;
    using School.Domain.Repositories;

    public static class Module
    {
        public static Dictionary<Type, Type> GetTypes()
        {
            var dic = new Dictionary<Type, Type>();
            dic.Add(typeof(IUserRepository), typeof(UserRepository));
            dic.Add(typeof(ICourseRepository), typeof(CourseRepository));

            return dic;
        }
    }
}
