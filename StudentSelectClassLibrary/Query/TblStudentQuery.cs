using System;
using System.Collections.Generic;
using System.Text;

namespace StudentSelectClassLibrary.Query
{
    public class TblStudentQuery
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        public int StudentId { get; set; }

        /// <summary>
        /// 学生编号
        /// </summary>
        public string StudentNum { get; set; }

        /// <summary>
        /// 学生姓名
        /// </summary>
        public string StudentName { get; set; }

        /// <summary>
        /// 专业编号
        /// </summary>
        public string MajorNum { get; set; }

        /// <summary>
        /// 学生性别
        /// </summary>
        public string StudentSex { get; set; }

        /// <summary>
        /// 生日开始时间
        /// </summary>
        public DateTime StudentStartBirthday { get; set; }

        /// <summary>
        /// 生日结束时间
        /// </summary>
        public DateTime StudentEndBirthday { get; set; }

        /// <summary>
        /// 学生密码
        /// </summary>
        public string StudentPassword { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// 创建开始时间
        /// </summary>
        public DateTime CreateStartTime { get; set; }

        /// <summary>
        /// 创建结束时间
        /// </summary>
        public DateTime CreateEndTime { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public string ModifyBy { get; set; }

        /// <summary>
        /// 修改开始时间
        /// </summary>
        public DateTime ModifyStartTime { get; set; }

        /// <summary>
        /// 修改结束时间
        /// </summary>
        public DateTime ModifyEndTime { get; set; }

        /// <summary>
        /// 第几页
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// 查询的页数
        /// </summary>
        public int Page { get; set; }
    }
}
