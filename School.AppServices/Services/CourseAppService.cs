
using System;
using System.Collections.Generic;
using System.Text;
using School.DomainServices.Interfaces;

namespace School.AppServices.Services
{
    using Interfaces;
    using DTOs;
    using Extensions;

    internal class CourseAppService : ICourseAppService
    {
        private readonly ICourseService service;

        public CourseAppService(ICourseService service)
        {
            this.service = service;
        }
        public IEnumerable<CourseDTO> List()
        {
            return service.List().EnumerableTo<CourseDTO>();
        }
    }
}
