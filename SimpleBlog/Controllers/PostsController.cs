using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Controllers
{
    public class PostsController : Controller
    {
        //Controller like a class, action as a method

        public ActionResult Index()
        {
            return View();
        }

    }
}