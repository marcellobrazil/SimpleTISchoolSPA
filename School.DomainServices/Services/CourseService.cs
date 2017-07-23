using System;
using System.Collections.Generic;
using System.Text;

namespace School.DomainServices.Services
{
    using Interfaces;
    using School.Domain.Entities;
    using School.Domain.Repositories;

    internal class CourseService : ICourseService
    {
        private readonly ICourseRepository repository;

        public CourseService(ICourseRepository repository)
        {
            this.repository = repository;
        }
        public IEnumerable<Course> List()
        {
            return repository.List();
        }
    }
}
