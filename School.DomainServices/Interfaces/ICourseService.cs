using School.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.DomainServices.Interfaces
{
    public interface ICourseService
    {
        IEnumerable<Course> List();
    }
}
