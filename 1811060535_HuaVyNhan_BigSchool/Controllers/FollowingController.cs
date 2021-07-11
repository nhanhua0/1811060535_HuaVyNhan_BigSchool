using _1811060535_HuaVyNhan_BigSchool.Models;
using _1811060535_HuaVyNhan_BigSchool.DTOs;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _1811060535_HuaVyNhan_BigSchool.Controllers.Api
{
    
        // GET: Following
        public class FollowingsController : ApiController
        {
            private ApplicationDbContext _dbContext;

            public FollowingsController()
            {
                _dbContext = new ApplicationDbContext();
            }

            [HttpPost]
            public IHttpActionResult Follow(FollowingDTO followingDTO)
            {
                var userId = User.Identity.GetUserId();
                if (_dbContext.Followings.Any(f => f.FolloweeId == userId && f.FolloweeId == followingDTO.FolloweeId))
                    return BadRequest("Following already exists!");

                var following = new Following
                {
                    FollowerId = userId,
                    FolloweeId = followingDTO.FolloweeId
                };

                _dbContext.Followings.Add(following);
                _dbContext.SaveChanges();

                return Ok();

            }
        }
    }
