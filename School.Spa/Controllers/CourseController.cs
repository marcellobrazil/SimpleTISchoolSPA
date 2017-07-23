using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using School.AppServices.DTOs;
using School.AppServices.Interfaces;

namespace School_Spa.Controllers
{
    [Route("api/[controller]")]
    public class CourseController : Controller
    {
        private readonly ICourseAppService service;

        public CourseController(ICourseAppService service)
        {
            this.service = service;

        }

        //[HttpGet]
        //[Authorize("Bearer")]
        public IEnumerable<CourseDTO> ListAuth()
        {
            var list = this.service.List();

            return list;
        }

        [HttpGet]
        public IEnumerable<CourseDTO> List()
        {
            var list = this.service.List();

            return list;
        }

    }
}
