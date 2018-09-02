using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SelectClassApplication.Models;
using StudentSelectClassLibrary;
using StudentSelectClassLibrary.DA;
using StudentSelectClassLibrary.Models;
using StudentSelectClassLibrary.Query;

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
            var admincode = HttpContext.Session.GetString(SessionCode.adminname);
            if (string.IsNullOrEmpty(admincode))
            {
                return Redirect("../Login/LoginAdminResult");
            }
            return View();
        }

        public IActionResult StudentResult()
        {
            ViewBag.Title = "学生选课系统-后台管理-学生管理";
            var admincode = HttpContext.Session.GetString(SessionCode.adminname);
            if (string.IsNullOrEmpty(admincode))
            {
                return Redirect("../Login/LoginAdminResult");
            }
            StudentDa da = new StudentDa
            {
                XuanKeDB = DBContext
            };
            var query = new TblStudentQuery
            {
                PageIndex = 1,
                Page = 20
            };
            List<TblStudent> students = da.GetStudentsList(query);
            ViewBag.students = students;
            return View();
        }

        public IActionResult CourseResult()
        {
            ViewBag.Title = "学生选课系统-后台管理-课程管理";
            var admincode = HttpContext.Session.GetString(SessionCode.adminname);
            if (string.IsNullOrEmpty(admincode))
            {
                return Redirect("../Login/LoginAdminResult");
            }
            return View();
        }

        public IActionResult DeptResult()
        {
            ViewBag.Title = "学生选课系统-后台管理-院系管理";
            var admincode = HttpContext.Session.GetString(SessionCode.adminname);
            if (string.IsNullOrEmpty(admincode))
            {
                return Redirect("../Login/LoginAdminResult");
            }
            return View();
        }

        public IActionResult MajorResult()
        {
            ViewBag.Title = "学生选课系统-后台管理-专业管理";
            var admincode = HttpContext.Session.GetString(SessionCode.adminname);
            if (string.IsNullOrEmpty(admincode))
            {
                return Redirect("../Login/LoginAdminResult");
            }
            return View();
        }

        public IActionResult ManagerResult()
        {
            ViewBag.Title = "学生选课系统-后台管理-管理员";
            var admincode = HttpContext.Session.GetString(SessionCode.adminname);
            if (string.IsNullOrEmpty(admincode))
            {
                return Redirect("../Login/LoginAdminResult");
            }
            return View();
        }

        public IActionResult SettingResult()
        {
            ViewBag.Title = "学生选课系统-后台管理-设置";
            var admincode = HttpContext.Session.GetString(SessionCode.adminname);
            if (string.IsNullOrEmpty(admincode))
            {
                return Redirect("../Login/LoginAdminResult");
            }
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
            var admincode = HttpContext.Session.GetString(SessionCode.adminname);
            if (string.IsNullOrEmpty(admincode))
            {
                return Redirect("../Login/LoginAdminResult");
            }
            return View();
        }

        public IActionResult StudentDetailResult()
        {
            ViewBag.Title = "学生选课系统-后台管理-学生详情";
            var admincode = HttpContext.Session.GetString(SessionCode.adminname);
            if (string.IsNullOrEmpty(admincode))
            {
                return Redirect("../Login/LoginAdminResult");
            }
            return View();
        }

        public IActionResult CourseDetailResult()
        {
            ViewBag.Title = "学生选课系统-后台管理-课程详情";
            var admincode = HttpContext.Session.GetString(SessionCode.adminname);
            if (string.IsNullOrEmpty(admincode))
            {
                return Redirect("../Login/LoginAdminResult");
            }
            return View();
        }

        public IActionResult DeptDetailResult()
        {
            ViewBag.Title = "学生选课系统-后台管理-院系详情";
            var admincode = HttpContext.Session.GetString(SessionCode.adminname);
            if (string.IsNullOrEmpty(admincode))
            {
                return Redirect("../Login/LoginAdminResult");
            }
            return View();
        }

        public IActionResult MajorDetailResult()
        {
            ViewBag.Title = "学生选课系统-后台管理-班级详情";
            var admincode = HttpContext.Session.GetString(SessionCode.adminname);
            if (string.IsNullOrEmpty(admincode))
            {
                return Redirect("../Login/LoginAdminResult");
            }
            return View();
        }

        public IActionResult ManagerDetailResult()
        {
            ViewBag.Title = "学生选课系统-后台管理-管理员详情";
            var admincode = HttpContext.Session.GetString(SessionCode.adminname);
            if (string.IsNullOrEmpty(admincode))
            {
                return Redirect("../Login/LoginAdminResult");
            }
            return View();
        }

        public IActionResult SettingDetailResult()
        {
            ViewBag.Title = "学生选课系统-后台管理-设置详情";
            var admincode = HttpContext.Session.GetString(SessionCode.adminname);
            if (string.IsNullOrEmpty(admincode))
            {
                return Redirect("../Login/LoginAdminResult");
            }
            return View();
        }

        public IActionResult TeacherDetailResult()
        {
            ViewBag.Title = "学生选课系统-后台管理-教师详情";
            var admincode = HttpContext.Session.GetString(SessionCode.adminname);
            if (string.IsNullOrEmpty(admincode))
            {
                return Redirect("../Login/LoginAdminResult");
            }
            return View();
        }

        public IActionResult SelectClassInfoDetailResult()
        {
            ViewBag.Title = "学生选课系统-后台管理-选课信息详情";
            var admincode = HttpContext.Session.GetString(SessionCode.adminname);
            if (string.IsNullOrEmpty(admincode))
            {
                return Redirect("../Login/LoginAdminResult");
            }
            return View();
        }

        public IActionResult AddStudentResult()
        {
            ViewBag.Title = "学生选课系统-后台管理-新增学生信息";
            var admincode = HttpContext.Session.GetString(SessionCode.adminname);
            if (string.IsNullOrEmpty(admincode))
            {
                return Redirect("../Login/LoginAdminResult");
            }
            return View();
        }

        public IActionResult AddCourseResult()
        {
            ViewBag.Title = "学生选课系统-后台管理-新增课程信息";
            var admincode = HttpContext.Session.GetString(SessionCode.adminname);
            if (string.IsNullOrEmpty(admincode))
            {
                return Redirect("../Login/LoginAdminResult");
            }
            return View();
        }

        public IActionResult AddDeptResult()
        {
            ViewBag.Title = "学生选课系统-后台管理-新增院系信息";
            var admincode = HttpContext.Session.GetString(SessionCode.adminname);
            if (string.IsNullOrEmpty(admincode))
            {
                return Redirect("../Login/LoginAdminResult");
            }
            return View();
        }

        public IActionResult AddMajorResult()
        {
            ViewBag.Title = "学生选课系统-后台管理-新增班级信息";
            var admincode = HttpContext.Session.GetString(SessionCode.adminname);
            if (string.IsNullOrEmpty(admincode))
            {
                return Redirect("../Login/LoginAdminResult");
            }
            return View();
        }

        public IActionResult AddManagerResult()
        {
            ViewBag.Title = "学生选课系统-后台管理-新增管理员信息";
            var admincode = HttpContext.Session.GetString(SessionCode.adminname);
            if (string.IsNullOrEmpty(admincode))
            {
                return Redirect("../Login/LoginAdminResult");
            }
            return View();
        }

        public IActionResult AddSettingResult()
        {
            ViewBag.Title = "学生选课系统-后台管理-新增设置信息";
            var admincode = HttpContext.Session.GetString(SessionCode.adminname);
            if (string.IsNullOrEmpty(admincode))
            {
                return Redirect("../Login/LoginAdminResult");
            }
            return View();
        }

        public IActionResult AddTeacherResult()
        {
            ViewBag.Title = "学生选课系统-后台管理-新增教师信息";
            var admincode = HttpContext.Session.GetString(SessionCode.adminname);
            if (string.IsNullOrEmpty(admincode))
            {
                return Redirect("../Login/LoginAdminResult");
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
