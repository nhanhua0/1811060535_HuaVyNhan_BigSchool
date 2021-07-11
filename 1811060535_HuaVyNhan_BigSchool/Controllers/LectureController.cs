﻿using _1811060535_HuaVyNhan_BigSchool.Models;
using _1811060535_HuaVyNhan_BigSchool.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeQuocBao_1811062386.Controllers
{

    public class LectureController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public LectureController()
        {
            _dbContext = new ApplicationDbContext();
        }


        [Authorize]
        public ActionResult Follow()
        {
            var userId = User.Identity.GetUserId();


            var courses = _dbContext.Attendances
                .Where(a => a.AttendeeId == userId)
                .Select(a => a.Course)
                .Include(l => l.Lecturer)
                .Include(c => c.Category)
                .ToList();

            var viewModel = new CoursesViewModel
            {
                UpcommingCourses = courses,
                ShowAction = User.Identity.IsAuthenticated
            };

            return View(viewModel);



        }
    }

}