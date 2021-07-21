using _1811060535_HuaVyNhan_BigSchool.Models;
using System.Collections.Generic;

namespace _1811060535_HuaVyNhan_BigSchool.Controllers
{
    internal class FollowingViewModel
    {
        public List<ApplicationUser> Followings { get; set; }
        public bool ShowAction { get; set; }
    }
}