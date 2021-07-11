using _1811060535_HuaVyNhan_BigSchool.DTOs;
using _1811060535_HuaVyNhan_BigSchool.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _1811060535_HuaVyNhan_BigSchool.Controllers.Api
{
    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _dbContext;

        public AttendancesController()
        {
            _dbContext = new ApplicationDbContext();
        }

        //[HttpPost]
        //public IHttpActionResult Attend([FromBody] int courseId)
        //{
        //    //var userId = User.Identity.GetUserId();
        //    //if (_dbContext.Attendances.Any(a => a.AttendeeId == userId && a.CourseId == courseId))
        //    //{
        //    //    return BadRequest("The Attendance already exits");
        //    //}
        //    var attendance = new Attendance
        //    {
        //        CourseId = courseId,
        //        AttendeeId = User.Identity.GetUserId()
        //    };

        //    _dbContext.Attendances.Add(attendance);
        //    _dbContext.SaveChanges();

        //    return Ok();

        //}

        [HttpPost]
        public IHttpActionResult Attend(AttendanceDTO attendanceDTO)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Attendances.Any(a => a.AttendeeId == userId && a.CourseId == attendanceDTO.CourseId))
            {
                return BadRequest("The Attendance already exits");
            }
            var attendance = new Attendance
            {
                CourseId = attendanceDTO.CourseId,
                AttendeeId = userId
            };

            _dbContext.Attendances.Add(attendance);
            _dbContext.SaveChanges();

            return Ok();
        }
    }
}
