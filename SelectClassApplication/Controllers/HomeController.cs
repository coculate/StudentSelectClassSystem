using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SelectClassApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult StudentResult()
        {
            ViewBag.Title = "学生选课系统-学生端-学生信息";
            return View();
        }

        public IActionResult CourseResult()
        {
            ViewBag.Title = "学生选课系统-学生端-课程信息";
            return View();
        }

        public IActionResult SelectClassResult()
        {
            ViewBag.Title = "学生选课系统-学生端-选课信息";
            return View();
        }

    }
}