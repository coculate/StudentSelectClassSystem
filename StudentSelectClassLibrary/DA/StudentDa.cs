﻿using System;
using System.Collections.Generic;
using System.Linq;
using StudentSelectClassLibrary.Dtos;
using StudentSelectClassLibrary.Models;
using StudentSelectClassLibrary.Query;

namespace StudentSelectClassLibrary.DA
{
    public class StudentDa
    {
        /// <summary>
        /// 上下文连接
        /// </summary>
        public XuanKeDBContext XuanKeDB { get; set; }

        #region 增

        /// <summary>
        /// 是否存在该学号,如果存在就新增，不存在就提示错误
        /// </summary>
        /// <param name="stucode"></param>
        /// <returns></returns>
        public bool ExistsStuCode(string stucode)
        {
            var student = XuanKeDB.TblStudent.Find(stucode);
            if (student == null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 学生登录
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public bool StudentLogin(TblStudentDto dto)
        {
            var student = XuanKeDB.TblStudent.FirstOrDefault(s => s.StudentNum == dto.StudentNum && s.StudentPassword == dto.StudentPassword);
            if (student == null)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 新增学生信息
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public void AddStudents(TblStudentDto dto)
        {
            var entity = dto.ToEntity();
            XuanKeDB.TblStudent.Add(entity);
            XuanKeDB.SaveChanges();
        }

        #endregion

        #region 删

        /// <summary>
        /// 删除学生信息
        /// </summary>
        /// <param name="stucode">学号</param>
        /// <returns></returns>
        public int DeleteStudent(string stucode)
        {
            var student = XuanKeDB.TblStudent.Find(stucode);
            if (student == null)
            {
                return 0;
            }
            else
            {
                student.IsDeleted = true;
                student.DeleteBy = "admin";
                student.DeleteTime = DateTime.Now;
                return XuanKeDB.SaveChanges();
            }
        }

        #endregion

        #region 改

        public void ModifyStudent(TblStudentDto dto)
        {
            var entity = dto.ToEntity();
            XuanKeDB.TblStudent.Update(entity);
            XuanKeDB.SaveChanges();
        }

        #endregion

        #region 查

        /// <summary>
        /// 查询所有数据
        /// </summary>
        /// <returns></returns>
        public List<TblStudent> GetStudentsList(TblStudentQuery query)
        {
            List<TblStudent> students = new List<TblStudent>();
            students = XuanKeDB.TblStudent
                .Skip(query.Page * (query.PageIndex - 1))
                .Take(query.Page)
                .OrderByDescending(s => s.CreateTime)
                .ToList();
            return students;
        }

        /// <summary>
        /// 获取学生详细信息
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public TblStudent GetStudentDetail(TblStudentQuery query)
        {
            if (string.IsNullOrEmpty(query.StudentNum))
            {
                return new TblStudent();
            }
            var student = XuanKeDB.TblStudent.FirstOrDefault(s => s.StudentNum == query.StudentNum);
            return student;
        }

        #endregion
    }
}
