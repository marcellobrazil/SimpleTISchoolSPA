using System;
using System.Collections.Generic;
using System.Text;

namespace School.DomainServices.IoC
{
    using School.DomainServices.Interfaces;
    using School.DomainServices.Services;

    public static class Module
    {
        public static Dictionary<Type, Type> GetTypes()
        {
            var dic = new Dictionary<Type, Type>();
            dic.Add(typeof(IUserService), typeof(UserService));
            dic.Add(typeof(ICourseService), typeof(CourseService));

            return dic;
        }
    }
}
