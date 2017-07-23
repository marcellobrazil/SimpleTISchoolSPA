using System;
using System.Collections.Generic;
using System.Text;

namespace School.AppServices.IoC
{
    using Interfaces;
    using Services;

    public static class Module
    {
        public static Dictionary<Type, Type> GetTypes()
        {
            var dic = new Dictionary<Type, Type>();
            dic.Add(typeof(IUserAppService), typeof(UserAppService));
            dic.Add(typeof(ICourseAppService), typeof(CourseAppService));

            return dic;
        }
    }
}
