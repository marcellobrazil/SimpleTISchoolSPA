using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Spa.Mappings
{
    public static class AutoMapperConfiguration
    {

        public static void Initialize()
        {
            AutoMapper.Mapper.Initialize((config) =>
            {
                config.AddProfiles(School.IoC.AutoMapperConfiguration.GetAutoMapperProfiles());
            });
        }
    }
}