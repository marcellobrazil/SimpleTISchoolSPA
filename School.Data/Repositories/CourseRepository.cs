using School.Domain.Entities;
using School.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace School.Data.Repositories
{
    internal class CourseRepository : RepositoryBase, ICourseRepository
    {
        public CourseRepository(IConfigurationRoot configuration) : base(configuration)
        {
        }

        public IEnumerable<Course> List()
        {
            var result = Connection.Query<Course>("exec p_school_course_list");

            return result;
        }
    }
}
