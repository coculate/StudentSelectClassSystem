using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using SelectClassApplication.Models;
using StudentSelectClass.DA;
using StudentSelectClass.Models;

namespace SelectClassApplication.Controllers
{
    public class AdminController : Controller
    {
        public XuanKeDBContext DBContext { get; set; }
        public IHostingEnvironment HostingEnvironment { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="hostingEnvironment">路径</param>
        public AdminController(IHostingEnvironment hostingEnvironment, XuanKeDBContext db)
        {
            HostingEnvironment = hostingEnvironment;
            DBContext = db;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "学生选课系统-后台管理-首页";
            return View();
        }

        public IActionResult StudentResult()
        {
            ViewBag.Title = "学生选课系统-后台管理-学生管理";
            StudentDa da = new StudentDa
            {
                XuanKeDB = DBContext
            };
            List<TblStudent> students = da.GetStudentsList();
            ViewBag.students = students;
            return View();
        }

        public IActionResult CourseResult()
        {
            ViewBag.Title = "学生选课系统-后台管理-课程管理";
            return View();
        }

        public IActionResult DeptResult()
        {
            ViewBag.Title = "学生选课系统-后台管理-院系管理";
            return View();
        }

        public IActionResult MajorResult()
        {
            ViewBag.Title = "学生选课系统-后台管理-专业管理";
            return View();
        }

        public IActionResult ManagerResult()
        {
            ViewBag.Title = "学生选课系统-后台管理-管理员";
            return View();
        }

        public IActionResult SettingResult()
        {
            ViewBag.Title = "学生选课系统-后台管理-设置";
            return View();
        }

        public IActionResult TeacherResult()
        {
            ViewBag.Title = "学生选课系统-后台管理-教师管理";
            return View();
        }

        public IActionResult SelectClassInfoResult()
        {
            ViewBag.Title = "学生选课系统-后台管理-选课信息管理";
            return View();
        }

        public IActionResult StudentDetailResult()
        {
            ViewBag.Title = "学生选课系统-后台管理-学生详情";
            return View();
        }

        public IActionResult CourseDetailResult()
        {
            return View();
        }

        public IActionResult DeptDetailResult()
        {
            return View();
        }

        public IActionResult MajorDetailResult()
        {
            return View();
        }

        public IActionResult ManagerDetailResult()
        {
            return View();
        }

        public IActionResult SettingDetailResult()
        {
            return View();
        }

        public IActionResult TeacherDetailResult()
        {
            return View();
        }

        public IActionResult SelectClassInfoDetailResult()
        {
            return View();
        }

        public IActionResult AddCourseResult()
        {
            return View();
        }

        public IActionResult AddDeptResult()
        {
            return View();
        }

        public IActionResult AddMajorResult()
        {
            return View();
        }

        public IActionResult AddManagerResult()
        {
            return View();
        }

        public IActionResult AddSettingResult()
        {
            return View();
        }

        public IActionResult AddTeacherResult()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
