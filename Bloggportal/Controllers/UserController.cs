using Bloggportal.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;

namespace Bloggportal.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            List<UserDetail> UserList = new List<UserDetail>();
            UserMethods um = new UserMethods();
            string error = "";

            UserList = um.GetUserList(out error);

            ViewBag.error = error;
            return View(UserList);
        }

        public IActionResult UserInfo()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.Id = userId;
            return View();
        }

        public IActionResult ShowUser(string userId)
        {
            List<PostDetail> PostList = new List<PostDetail>();
            UserMethods um = new UserMethods();
            string error = "";
            ViewBag.test = userId;
            PostList = um.GetUserPosts(out error, userId);

            ViewBag.error = error;
            return View(PostList);
        }

    }
}