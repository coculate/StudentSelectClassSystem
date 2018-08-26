using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentSelectClassLibrary;
using StudentSelectClassLibrary.DA;
using StudentSelectClassLibrary.Models;
using StudentSelectClassLibrary.Query;

namespace SelectClassApplication.Controllers
{
    public class HomeController : Controller
    {
        public XuanKeDBContext DBContext { get; set; }
        public HomeController(XuanKeDBContext dBContext)
        {
            DBContext = dBContext;
        }
        public IActionResult StudentResult()
        {
            ViewBag.Title = "学生选课系统-学生端-学生信息";
            var query = new TblStudentQuery();
            var stucode = HttpContext.Session.GetString(SessionCode.username);
            if (string.IsNullOrEmpty(stucode))
            {
                return Redirect("../Login/LoginResult");
            }
            var da = new StudentDa
            {
                XuanKeDB = DBContext
            };
            query.StudentNum = stucode;
            var student = da.GetStudentDetail(query);
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