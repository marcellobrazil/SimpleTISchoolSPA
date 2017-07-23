using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace School.AppServices.Mappings
{ 
    using DTOs;
    using School.Domain.Entities;

    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<UserDTO, User>().ReverseMap();
            CreateMap<CourseDTO, Course>().ReverseMap();
        }
    }
}
