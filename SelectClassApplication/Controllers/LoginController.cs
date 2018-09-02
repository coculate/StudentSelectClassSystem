using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentSelectClassLibrary;
using StudentSelectClassLibrary.DA;
using StudentSelectClassLibrary.Dtos;
using StudentSelectClassLibrary.Models;

namespace SelectClassApplication.Controllers
{
    public class LoginController : Controller
    {
        public XuanKeDBContext XuanKeDB { get; set; }

        public LoginController(XuanKeDBContext xuanKeDB)
        {
            XuanKeDB = xuanKeDB;
        }

        public IActionResult LoginResult()
        {
            ViewBag.Title = "学生选课系统-学生端-登录";
            return View();
        }

        public IActionResult LoginAdminResult()
        {
            ViewBag.Title = "学生选课系统-后台管理-登录";
            return View();
        }

        /// <summary>
        /// 前端退出登录
        /// </summary>
        /// <returns></returns>
        public IActionResult LoginOutResult()
        {
            HttpContext.Session.SetString(SessionCode.username, "");
            return Redirect("../Login/LoginResult");
        }

        /// <summary>
        /// 后端退出登录
        /// </summary>
        /// <returns></returns>
        public IActionResult LoginOutAdminResult()
        {
            HttpContext.Session.SetString(SessionCode.adminname, "");
            return Redirect("../Login/LoginAdminResult");
        }

        /// <summary>
        /// 前端登录接口
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult LoginSubmit()
        {
            string xuehao = Request.Form["username"].ToString();
            string password = Request.Form["password"].ToString();
            if (string.IsNullOrEmpty(xuehao) || string.IsNullOrEmpty(password) || string.IsNullOrWhiteSpace(xuehao) || string.IsNullOrWhiteSpace(password))
            {
                return Redirect("../Login/LoginResult");
            }
            TblStudentDto dto = new TblStudentDto
            {
                StudentNum = xuehao,
                StudentPassword = password
            };
            StudentDa da = new StudentDa {
                XuanKeDB = XuanKeDB
            };
            var flag = da.StudentLogin(dto);
            if (flag)
            {
                HttpContext.Session.SetString(SessionCode.username, xuehao);
                return Redirect("../Home/StudentResult");
            }
            return Redirect("../Login/LoginResult");
        }

        /// <summary>
        /// 后端登录接口
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult LoginAdminSubmit()
        {
            string xuehao = Request.Form["username"].ToString();
            string password = Request.Form["password"].ToString();
            if (string.IsNullOrEmpty(xuehao) || string.IsNullOrEmpty(password) || string.IsNullOrWhiteSpace(xuehao) || string.IsNullOrWhiteSpace(password))
            {
                return Redirect("../Login/LoginAdminResult");
            }
            HttpContext.Session.SetString(SessionCode.adminname, xuehao);
            return Redirect("../Admin/Index");
        }
    }
}