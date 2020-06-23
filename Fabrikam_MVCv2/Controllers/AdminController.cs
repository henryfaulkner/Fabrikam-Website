using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using Fabrikam_MVCv2.Models;

namespace Fabrikam_MVCv2.Controllers
{
    public class AdminController : Controller
    {
        private BlogEntities _context = new BlogEntities();

        // GET: Admin
        public ActionResult Admin()
        {
            Debug.WriteLine("first line");

            var post = new BlogPost();

            return View(post);
        }

        [HttpPost]
        public ActionResult CreatePost(BlogPost post)
        {
            Debug.WriteLine("second line");
            var postDB = new Post
            {
                Author = post.Author,
                Title = post.Title,
                Body = post.Body,
                DatePublished = DateTime.Now
            };

            _context.Posts.Add(postDB);
            try
            {
                _context.SaveChanges();
                //return View();
                Debug.WriteLine("Totally worked");
                return View("SuccessPost", post);
            }
            catch (DbUpdateException ex)
            {
                Debug.WriteLine("Did not totally work");
                return View("FailurePost", post);
            }
            catch (DbEntityValidationException ex)
            {
                Debug.WriteLine("Did not totally work");
                return View("FailurePost", post);
            }
        }

        public ActionResult SuccessPost()
        {
            return View();
        }

        public ActionResult FailurePost()
        {
            return View();
        }

        public ActionResult SignIn()
        {
            var signin = new AdminAccountObj();

            return View(signin);
        }

        public ActionResult ValidateSignIn(AdminAccountObj signin)
        {
            var query = 
                from c in _context.AdminAccounts
                where c.Username == signin.Username && c.Password == signin.Password
                select c;

            if (query.Any()) return View("Admin");

            return View("SignIn");
        }
    }
}