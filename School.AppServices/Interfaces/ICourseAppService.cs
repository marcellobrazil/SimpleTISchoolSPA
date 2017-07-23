using System;
using System.Collections.Generic;
using System.Text;

namespace School.AppServices.Interfaces
{
    using DTOs;

    public interface ICourseAppService
    {
        IEnumerable<CourseDTO> List();

    }
}
